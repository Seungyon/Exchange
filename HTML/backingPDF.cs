using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Apps_Exchange
{
    class backingPDF
    {
        public static int EmbedPRC2PDF(string inPRC, string inPDF, string p_outPDF, float bot_left_x, float bot_lef_y, float top_right_x, float top_right_y, List<float> views, List<string> names)
        {
            //0 - Successfull
            //1 - Failed to generate pdf file
            //2 - Output file can not overwrite
            //3 - Input not exist
            if (!File.Exists(inPRC))
                return 3;

            //string inPDF = p_inPDF;
            //if (p_inPDF.Equals(p_outPDF, StringComparison.CurrentCultureIgnoreCase))
            //{
            //    File.Copy(inPDF,   inPDF+"_");
            //    inPDF = inPDF + "_";
            //}

            if (File.Exists(p_outPDF))
            {
                try
                {
                    File.Delete(p_outPDF);
                }
                catch
                {
                    //File.Delete(inPDF + "_");
                    return 2;
                }
            }

            PdfReader reader1 = new PdfReader(inPDF);
            using (FileStream fs = new FileStream(p_outPDF, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfStamper stamper = new PdfStamper(reader1, fs, '1', true);
                {
                    Rectangle _rect = reader1.GetPageSizeWithRotation(1);

                    List<PdfObject> viewRefs = new List<PdfObject>();
                    //add view
                    for (int i = 0; i < views.Count; i++)
                    {
                        float[] c2w = new float[12];
                        views.CopyTo(i, c2w, 0, 12);
                        float _distance = views[i + 12];
                        viewRefs.Add(addView(c2w, 30, _distance, names[i / 13], ref stamper));
                        i += 12;
                    }

                    PdfWriter writer = stamper.Writer;

                    Dictionary<string, PdfLayer> dicLayers = stamper.GetPdfLayers();

                    PdfLayer layer = new PdfLayer("3D View", writer);

                    // Get the ContentByte object
                    PdfContentByte contentBytes = stamper.GetUnderContent(1);

                    // Tell the cb that the next commands should be "bound" to this new layer
                    contentBytes.BeginLayer(layer);

                    // step 4
                    Rectangle rect = new Rectangle(bot_left_x * 0.75f, _rect.Height - top_right_y * 0.75f, top_right_x * 0.75f, _rect.Height - bot_lef_y * 0.75f);
                    rect.Border = Rectangle.BOX;
                    rect.BorderWidth = 2f;
                    rect.BorderColor = new BaseColor(0xFF, 0x00, 0x00);

                    FileStream prcStream = new FileStream(inPRC, FileMode.Open, FileAccess.Read);
                    PdfStream stream3D = new PdfStream(prcStream, writer);
                    stream3D.Put(PdfName.TYPE, new PdfName("3D"));
                    stream3D.Put(PdfName.SUBTYPE, new PdfName("PRC"));
                    stream3D.Put(new PdfName("VA"), new PdfArray(viewRefs));
                    stream3D.Put(new PdfName("VD"), new PdfNumber(0));
                    stream3D.FlateCompress();

                    PdfIndirectReference streamRef = writer.AddToBody(stream3D).IndirectReference;
                    stream3D.WriteLength();

                    PdfDictionary activationDict = new PdfDictionary();
                    activationDict.Put(PdfName.A, new PdfName("PO"));
                    activationDict.Put(new PdfName("DIS"), PdfName.I);

                    // Create appearance
                    PdfAppearance ap = contentBytes.CreateAppearance(rect.Width, rect.Height);
                    ap.BoundingBox = rect;

                    PdfAnnotation annot = new PdfAnnotation(writer, rect);
                    annot.Put(PdfName.CONTENTS, new PdfString("3D Model"));
                    annot.Put(PdfName.SUBTYPE, new PdfName("3D"));
                    annot.Put(PdfName.TYPE, PdfName.ANNOT);
                    annot.Put(new PdfName("3DD"), streamRef);
                    annot.Put(new PdfName("3DI"), new PdfBoolean(true));
                    //annot.Put(new PdfName("3DV"), dictObject.IndirectReference);
                    annot.Put(PdfName.TOOLBAR, new PdfBoolean(false));
                    annot.Put(new PdfName("3DA"), activationDict);
                    annot.Put(new PdfName("3DV"), new PdfName("F"));

                    annot.SetAppearance(PdfAnnotation.APPEARANCE_NORMAL, ap);
                    annot.SetPage();
                    stamper.AddAnnotation(annot, 1);

                    // Close the layer
                    contentBytes.EndLayer();
                    prcStream.Close();
                    stamper.Close();
                }
                fs.Close();
            }
            //try
            //{
                //File.Delete(inPDF);
            //}
            //catch { }
            return 0;
        }

        public static PdfIndirectReference addView(float[] c2w, float fov, float distance, string name, ref PdfStamper stamp)
        {
            ///C2W[-1.0 -0.0000000000000000000000000000000074988 0.000000000000000122465 0.000000000000000122465 -0.0000000000000000612323 1.0 0.0 1.0 0.0000000000000000612323 0.000000000000000000000000000000000000000000000350325 -250.0 0.0]/CO 250.0/IN(fdf23eab-24f8-476b-be96-ac18754694d3)/MS/M/P 53 0 R/Type/3DView/XN(NewView1)
            PdfDictionary bg = new PdfDictionary();
            bg.Put(new PdfName("C"), new PdfArray(new float[3] { 1, 1, 1 }));
            bg.Put(new PdfName("Subtype"), new PdfName("SC"));
            PdfIndirectReference bgRef = stamp.Writer.AddToBody(bg).IndirectReference;

            //light 
            ///Subtype/Day/Type/3DLightingScheme
            PdfDictionary light = new PdfDictionary();
            light.Put(new PdfName("Type"), new PdfName("3DLightingScheme"));
            light.Put(new PdfName("Subtype"), new PdfName("Day"));
            PdfIndirectReference lightRef = stamp.Writer.AddToBody(light).IndirectReference;

            PdfDictionary dict3D = new PdfDictionary();
            dict3D.Put(new PdfName("C2W"),
                new PdfArray(c2w));
            dict3D.Put(PdfName.CO, new PdfNumber(distance));
            dict3D.Put(new PdfName("IN"), new PdfString(Guid.NewGuid().ToString()));
            dict3D.Put(new PdfName("MS"), PdfName.M);


            dict3D.Put(PdfName.TYPE, new PdfName("3DView"));
            dict3D.Put(new PdfName("XN"), new PdfString(name));
            dict3D.Put(new PdfName("BG"), bgRef);
            dict3D.Put(new PdfName("LS"), lightRef);
            PdfIndirectObject dictObject = stamp.Writer.AddToBody(dict3D);

            return dictObject.IndirectReference;

        }
    }
}
