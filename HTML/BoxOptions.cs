using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apps_Exchange
{
    public partial class BoxOptions : Form
    {
        string unit = "";
        public BoxOptions(string p_unit)
        {

            InitializeComponent();
            switch (p_unit)
            {
                case "Meters":
                    unit = "m";
                    break;
                case "Centimeters":
                    unit = "cm";
                    break;
                case "Millimeters":
                    unit = "mm";
                    break;
                case "Feet":
                    unit = "ft";
                    break;
                case "Inches":
                    unit = "Inch";
                    break;
                default:
                    unit = p_unit;
                    break;
            }
                        
            label_unit.Text = "(" + unit + ")";
            
            radioButton_Meter.Text = radioButton_Meter.Text.Replace("(m)", "(" + unit + ")");
            radioButton_3DOffset.Text = radioButton_3DOffset.Text.Replace("(m)", "(" + unit + ")");
            switch (RVMUtility.offsetType)
            {
                case 0 ://length
                        textBox_Offset.Text = (RVMUtility.offset[0] * 2).ToString();
                        radioButton_Meter.Checked = true;
                        break;
                case 1://percent
                        textBox_Offset.Text = (RVMUtility.offset[0] * 2).ToString();
                        radioButton_Percent.Checked = true;                
                        break;
                case 2:
                        radioButton_3DOffset.Checked = true;
                        textBox_offsetX_Add.Text = RVMUtility.offset[0].ToString();
                        textBox_offsetY_Add.Text = RVMUtility.offset[1].ToString();
                        textBox_offsetZ_Add.Text = RVMUtility.offset[2].ToString();
                        textBox_OffsetX_sub.Text = RVMUtility.offset[3].ToString();
                        textBox_OffsetY_Sub.Text = RVMUtility.offset[4].ToString();
                        textBox_OffsetZ_Sub.Text = RVMUtility.offset[5].ToString();
                        break;
            }
        }

        private void radioButton_Meter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Meter.Checked)
            {
                label_unit.Visible = true;
                textBox_Offset.Visible = true;
                label_Increase3DSpace.Visible = true;
                label_unit.Text = "(" + unit + ")";
                panel_3DOffset.Visible = false;
            }
            else if (radioButton_Percent.Checked)
            {
                label_unit.Visible = true;
                textBox_Offset.Visible = true;
                label_Increase3DSpace.Visible = true;
                label_unit.Text = "(%)";
                panel_3DOffset.Visible = false;
            }
            else if (radioButton_3DOffset.Checked)
            {
                label_unit.Visible = false;
                textBox_Offset.Visible = false;
                label_Increase3DSpace.Visible = false;
                panel_3DOffset.Visible = true;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            if (radioButton_3DOffset.Checked)
                RVMUtility.offsetType = 2;
            else if (radioButton_Meter.Checked)
                RVMUtility.offsetType = 0;
            else if (radioButton_Percent.Checked)
                RVMUtility.offsetType = 1;
            try
            {
                string boundingBoxValue = "";
                switch (RVMUtility.offsetType)
                {
                    case 0://length
                    case 1://percent 
                        RVMUtility.offset[0] = RVMUtility.offset[1] = RVMUtility.offset[2] =
                        RVMUtility.offset[3] = RVMUtility.offset[4] = RVMUtility.offset[5] = float.Parse(textBox_Offset.Text) / 2;
                        boundingBoxValue = RVMUtility.offsetType.ToString() + ";" + textBox_Offset.Text;
                        OptionsForm.BoundingBoxValue = boundingBoxValue;
                        break;
                    case 2:
                        RVMUtility.offset[0] = float.Parse(textBox_offsetX_Add.Text.ToString());
                        RVMUtility.offset[1] = float.Parse(textBox_offsetY_Add.Text.ToString());
                        RVMUtility.offset[2] = float.Parse(textBox_offsetZ_Add.Text.ToString());
                        RVMUtility.offset[3] = float.Parse(textBox_OffsetX_sub.Text.ToString());
                        RVMUtility.offset[4] = float.Parse(textBox_OffsetY_Sub.Text.ToString());
                        RVMUtility.offset[5] = float.Parse(textBox_OffsetZ_Sub.Text.ToString());
                        boundingBoxValue = RVMUtility.offsetType.ToString() + ";" +
                                            RVMUtility.offset[0].ToString() + ":" +
                                            RVMUtility.offset[1].ToString() + ":" +
                                            RVMUtility.offset[2].ToString() + ":" +
                                            RVMUtility.offset[3].ToString() + ":" +
                                            RVMUtility.offset[4].ToString() + ":" +
                                            RVMUtility.offset[5].ToString();
                        OptionsForm.BoundingBoxValue = boundingBoxValue;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void textBox_offsetX_Add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (char.IsDigit(e.KeyChar))
                return;
            if (e.KeyChar == '.')
            {
                if ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
                else
                    return;
            }
            e.Handled = true;
        }
        
    }
}
