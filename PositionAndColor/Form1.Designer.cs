namespace PositionAndColor
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.TBPosX = new System.Windows.Forms.TextBox();
            this.TBPosY = new System.Windows.Forms.TextBox();
            this.TBColorRed = new System.Windows.Forms.TextBox();
            this.TBColorGreen = new System.Windows.Forms.TextBox();
            this.TBColorBlue = new System.Windows.Forms.TextBox();
            this.PanelColor = new System.Windows.Forms.Panel();
            this.TBColorHex = new System.Windows.Forms.TextBox();
            this.RBSeperate = new System.Windows.Forms.RadioButton();
            this.RBCombined = new System.Windows.Forms.RadioButton();
            this.TBPosCombined = new System.Windows.Forms.TextBox();
            this.TBColorCombined = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 1);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBPosX
            // 
            this.TBPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPosX.Location = new System.Drawing.Point(12, 12);
            this.TBPosX.Name = "TBPosX";
            this.TBPosX.Size = new System.Drawing.Size(90, 45);
            this.TBPosX.TabIndex = 1;
            // 
            // TBPosY
            // 
            this.TBPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPosY.Location = new System.Drawing.Point(108, 12);
            this.TBPosY.Name = "TBPosY";
            this.TBPosY.Size = new System.Drawing.Size(90, 45);
            this.TBPosY.TabIndex = 2;
            // 
            // TBColorRed
            // 
            this.TBColorRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBColorRed.Location = new System.Drawing.Point(12, 63);
            this.TBColorRed.Name = "TBColorRed";
            this.TBColorRed.Size = new System.Drawing.Size(70, 45);
            this.TBColorRed.TabIndex = 4;
            // 
            // TBColorGreen
            // 
            this.TBColorGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBColorGreen.Location = new System.Drawing.Point(88, 63);
            this.TBColorGreen.Name = "TBColorGreen";
            this.TBColorGreen.Size = new System.Drawing.Size(70, 45);
            this.TBColorGreen.TabIndex = 5;
            // 
            // TBColorBlue
            // 
            this.TBColorBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBColorBlue.Location = new System.Drawing.Point(164, 63);
            this.TBColorBlue.Name = "TBColorBlue";
            this.TBColorBlue.Size = new System.Drawing.Size(70, 45);
            this.TBColorBlue.TabIndex = 6;
            // 
            // PanelColor
            // 
            this.PanelColor.Location = new System.Drawing.Point(204, 12);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(30, 45);
            this.PanelColor.TabIndex = 7;
            // 
            // TBColorHex
            // 
            this.TBColorHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBColorHex.Location = new System.Drawing.Point(12, 114);
            this.TBColorHex.Name = "TBColorHex";
            this.TBColorHex.Size = new System.Drawing.Size(180, 45);
            this.TBColorHex.TabIndex = 8;
            // 
            // RBSeperate
            // 
            this.RBSeperate.AutoSize = true;
            this.RBSeperate.Checked = true;
            this.RBSeperate.Location = new System.Drawing.Point(198, 116);
            this.RBSeperate.Name = "RBSeperate";
            this.RBSeperate.Size = new System.Drawing.Size(32, 17);
            this.RBSeperate.TabIndex = 9;
            this.RBSeperate.TabStop = true;
            this.RBSeperate.Text = "S";
            this.RBSeperate.UseVisualStyleBackColor = true;
            // 
            // RBCombined
            // 
            this.RBCombined.AutoSize = true;
            this.RBCombined.Location = new System.Drawing.Point(198, 140);
            this.RBCombined.Name = "RBCombined";
            this.RBCombined.Size = new System.Drawing.Size(32, 17);
            this.RBCombined.TabIndex = 10;
            this.RBCombined.Text = "C";
            this.RBCombined.UseVisualStyleBackColor = true;
            this.RBCombined.CheckedChanged += new System.EventHandler(this.RBCombined_CheckedChanged);
            // 
            // TBPosCombined
            // 
            this.TBPosCombined.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPosCombined.Location = new System.Drawing.Point(12, 12);
            this.TBPosCombined.Name = "TBPosCombined";
            this.TBPosCombined.Size = new System.Drawing.Size(186, 45);
            this.TBPosCombined.TabIndex = 11;
            this.TBPosCombined.Visible = false;
            // 
            // TBColorCombined
            // 
            this.TBColorCombined.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBColorCombined.Location = new System.Drawing.Point(12, 63);
            this.TBColorCombined.Name = "TBColorCombined";
            this.TBColorCombined.Size = new System.Drawing.Size(222, 45);
            this.TBColorCombined.TabIndex = 12;
            this.TBColorCombined.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 171);
            this.Controls.Add(this.RBCombined);
            this.Controls.Add(this.RBSeperate);
            this.Controls.Add(this.TBColorHex);
            this.Controls.Add(this.PanelColor);
            this.Controls.Add(this.TBColorBlue);
            this.Controls.Add(this.TBColorGreen);
            this.Controls.Add(this.TBColorRed);
            this.Controls.Add(this.TBPosY);
            this.Controls.Add(this.TBPosX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBPosCombined);
            this.Controls.Add(this.TBColorCombined);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Position & Color Fetcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBPosX;
        private System.Windows.Forms.TextBox TBPosY;
        private System.Windows.Forms.TextBox TBColorRed;
        private System.Windows.Forms.TextBox TBColorGreen;
        private System.Windows.Forms.TextBox TBColorBlue;
        private System.Windows.Forms.Panel PanelColor;
        private System.Windows.Forms.TextBox TBColorHex;
        private System.Windows.Forms.RadioButton RBSeperate;
        private System.Windows.Forms.RadioButton RBCombined;
        private System.Windows.Forms.TextBox TBPosCombined;
        private System.Windows.Forms.TextBox TBColorCombined;

    }
}

