namespace Apps_Exchange
{
    partial class BoxOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_3DOffset = new System.Windows.Forms.Panel();
            this.textBox_OffsetX_sub = new System.Windows.Forms.TextBox();
            this.textBox_offsetX_Add = new System.Windows.Forms.TextBox();
            this.textBox_OffsetY_Sub = new System.Windows.Forms.TextBox();
            this.textBox_offsetY_Add = new System.Windows.Forms.TextBox();
            this.textBox_OffsetZ_Sub = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_offsetZ_Add = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Offset = new System.Windows.Forms.TextBox();
            this.label_unit = new System.Windows.Forms.Label();
            this.label_Increase3DSpace = new System.Windows.Forms.Label();
            this.radioButton_3DOffset = new System.Windows.Forms.RadioButton();
            this.radioButton_Percent = new System.Windows.Forms.RadioButton();
            this.radioButton_Meter = new System.Windows.Forms.RadioButton();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.panel_3DOffset.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_3DOffset
            // 
            this.panel_3DOffset.Controls.Add(this.textBox_OffsetX_sub);
            this.panel_3DOffset.Controls.Add(this.textBox_offsetX_Add);
            this.panel_3DOffset.Controls.Add(this.textBox_OffsetY_Sub);
            this.panel_3DOffset.Controls.Add(this.textBox_offsetY_Add);
            this.panel_3DOffset.Controls.Add(this.textBox_OffsetZ_Sub);
            this.panel_3DOffset.Controls.Add(this.label14);
            this.panel_3DOffset.Controls.Add(this.textBox_offsetZ_Add);
            this.panel_3DOffset.Controls.Add(this.label13);
            this.panel_3DOffset.Controls.Add(this.label10);
            this.panel_3DOffset.Controls.Add(this.label12);
            this.panel_3DOffset.Controls.Add(this.label1);
            this.panel_3DOffset.Controls.Add(this.label9);
            this.panel_3DOffset.Location = new System.Drawing.Point(43, 34);
            this.panel_3DOffset.Name = "panel_3DOffset";
            this.panel_3DOffset.Size = new System.Drawing.Size(256, 66);
            this.panel_3DOffset.TabIndex = 82;
            this.panel_3DOffset.Visible = false;
            // 
            // textBox_OffsetX_sub
            // 
            this.textBox_OffsetX_sub.Location = new System.Drawing.Point(46, 29);
            this.textBox_OffsetX_sub.Name = "textBox_OffsetX_sub";
            this.textBox_OffsetX_sub.Size = new System.Drawing.Size(37, 20);
            this.textBox_OffsetX_sub.TabIndex = 4;
            this.textBox_OffsetX_sub.Text = "0";
            this.textBox_OffsetX_sub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_offsetX_Add_KeyPress);
            // 
            // textBox_offsetX_Add
            // 
            this.textBox_offsetX_Add.Location = new System.Drawing.Point(46, 4);
            this.textBox_offsetX_Add.Name = "textBox_offsetX_Add";
            this.textBox_offsetX_Add.Size = new System.Drawing.Size(37, 20);
            this.textBox_offsetX_Add.TabIndex = 4;
            this.textBox_offsetX_Add.Text = "0";
            this.textBox_offsetX_Add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_offsetX_Add_KeyPress);
            // 
            // textBox_OffsetY_Sub
            // 
            this.textBox_OffsetY_Sub.Location = new System.Drawing.Point(120, 29);
            this.textBox_OffsetY_Sub.Name = "textBox_OffsetY_Sub";
            this.textBox_OffsetY_Sub.Size = new System.Drawing.Size(37, 20);
            this.textBox_OffsetY_Sub.TabIndex = 5;
            this.textBox_OffsetY_Sub.Text = "0";
            this.textBox_OffsetY_Sub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_offsetX_Add_KeyPress);
            // 
            // textBox_offsetY_Add
            // 
            this.textBox_offsetY_Add.Location = new System.Drawing.Point(120, 4);
            this.textBox_offsetY_Add.Name = "textBox_offsetY_Add";
            this.textBox_offsetY_Add.Size = new System.Drawing.Size(37, 20);
            this.textBox_offsetY_Add.TabIndex = 5;
            this.textBox_offsetY_Add.Text = "0";
            this.textBox_offsetY_Add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_offsetX_Add_KeyPress);
            // 
            // textBox_OffsetZ_Sub
            // 
            this.textBox_OffsetZ_Sub.Location = new System.Drawing.Point(202, 29);
            this.textBox_OffsetZ_Sub.Name = "textBox_OffsetZ_Sub";
            this.textBox_OffsetZ_Sub.Size = new System.Drawing.Size(37, 20);
            this.textBox_OffsetZ_Sub.TabIndex = 6;
            this.textBox_OffsetZ_Sub.Text = "0";
            this.textBox_OffsetZ_Sub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_offsetX_Add_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "-X:";
            // 
            // textBox_offsetZ_Add
            // 
            this.textBox_offsetZ_Add.Location = new System.Drawing.Point(202, 4);
            this.textBox_offsetZ_Add.Name = "textBox_offsetZ_Add";
            this.textBox_offsetZ_Add.Size = new System.Drawing.Size(37, 20);
            this.textBox_offsetZ_Add.TabIndex = 6;
            this.textBox_offsetZ_Add.Text = "0";
            this.textBox_offsetZ_Add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_offsetX_Add_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(98, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "-Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "+X:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "-Z:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "+Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "+Z:";
            // 
            // textBox_Offset
            // 
            this.textBox_Offset.Location = new System.Drawing.Point(172, 45);
            this.textBox_Offset.Name = "textBox_Offset";
            this.textBox_Offset.Size = new System.Drawing.Size(57, 20);
            this.textBox_Offset.TabIndex = 81;
            this.textBox_Offset.Text = "0";
            this.textBox_Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_offsetX_Add_KeyPress);
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Location = new System.Drawing.Point(235, 48);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(21, 13);
            this.label_unit.TabIndex = 79;
            this.label_unit.Text = "(m)";
            // 
            // label_Increase3DSpace
            // 
            this.label_Increase3DSpace.AutoSize = true;
            this.label_Increase3DSpace.Location = new System.Drawing.Point(40, 48);
            this.label_Increase3DSpace.Name = "label_Increase3DSpace";
            this.label_Increase3DSpace.Size = new System.Drawing.Size(113, 13);
            this.label_Increase3DSpace.TabIndex = 80;
            this.label_Increase3DSpace.Text = "Increase 3D Space by";
            // 
            // radioButton_3DOffset
            // 
            this.radioButton_3DOffset.AutoSize = true;
            this.radioButton_3DOffset.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_3DOffset.Location = new System.Drawing.Point(257, 12);
            this.radioButton_3DOffset.Name = "radioButton_3DOffset";
            this.radioButton_3DOffset.Size = new System.Drawing.Size(87, 17);
            this.radioButton_3DOffset.TabIndex = 77;
            this.radioButton_3DOffset.Text = "3D Offset (m)";
            this.radioButton_3DOffset.UseVisualStyleBackColor = false;
            this.radioButton_3DOffset.CheckedChanged += new System.EventHandler(this.radioButton_Meter_CheckedChanged);
            // 
            // radioButton_Percent
            // 
            this.radioButton_Percent.AutoSize = true;
            this.radioButton_Percent.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Percent.Location = new System.Drawing.Point(125, 12);
            this.radioButton_Percent.Name = "radioButton_Percent";
            this.radioButton_Percent.Size = new System.Drawing.Size(97, 17);
            this.radioButton_Percent.TabIndex = 78;
            this.radioButton_Percent.Text = "Percentage (%)";
            this.radioButton_Percent.UseVisualStyleBackColor = false;
            this.radioButton_Percent.CheckedChanged += new System.EventHandler(this.radioButton_Meter_CheckedChanged);
            // 
            // radioButton_Meter
            // 
            this.radioButton_Meter.AutoSize = true;
            this.radioButton_Meter.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Meter.Checked = true;
            this.radioButton_Meter.Location = new System.Drawing.Point(17, 12);
            this.radioButton_Meter.Name = "radioButton_Meter";
            this.radioButton_Meter.Size = new System.Drawing.Size(75, 17);
            this.radioButton_Meter.TabIndex = 76;
            this.radioButton_Meter.TabStop = true;
            this.radioButton_Meter.Text = "Length (m)";
            this.radioButton_Meter.UseVisualStyleBackColor = false;
            this.radioButton_Meter.CheckedChanged += new System.EventHandler(this.radioButton_Meter_CheckedChanged);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(264, 108);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 83;
            this.button_Cancel.Text = "Close";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(172, 108);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 83;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // BoxOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 143);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.panel_3DOffset);
            this.Controls.Add(this.textBox_Offset);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.label_Increase3DSpace);
            this.Controls.Add(this.radioButton_3DOffset);
            this.Controls.Add(this.radioButton_Percent);
            this.Controls.Add(this.radioButton_Meter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BoxOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "3D Section";
            this.panel_3DOffset.ResumeLayout(false);
            this.panel_3DOffset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_3DOffset;
        private System.Windows.Forms.TextBox textBox_OffsetX_sub;
        private System.Windows.Forms.TextBox textBox_offsetX_Add;
        private System.Windows.Forms.TextBox textBox_OffsetY_Sub;
        private System.Windows.Forms.TextBox textBox_offsetY_Add;
        private System.Windows.Forms.TextBox textBox_OffsetZ_Sub;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_offsetZ_Add;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Offset;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.Label label_Increase3DSpace;
        private System.Windows.Forms.RadioButton radioButton_3DOffset;
        private System.Windows.Forms.RadioButton radioButton_Percent;
        private System.Windows.Forms.RadioButton radioButton_Meter;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Apply;
    }
}