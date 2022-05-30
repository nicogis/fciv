namespace Studioat.Utility
{
    partial class frmMain
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
            this.gBFile = new System.Windows.Forms.GroupBox();
            this.lblSHA512 = new System.Windows.Forms.Label();
            this.txtSHA512 = new System.Windows.Forms.TextBox();
            this.lblSHA256 = new System.Windows.Forms.Label();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblSHA1 = new System.Windows.Forms.Label();
            this.lblMD5 = new System.Windows.Forms.Label();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowserFile = new System.Windows.Forms.Button();
            this.gBVerify = new System.Windows.Forms.GroupBox();
            this.lblSHA512Verify = new System.Windows.Forms.Label();
            this.txtSHA512Verify = new System.Windows.Forms.TextBox();
            this.lblSHA256Verify = new System.Windows.Forms.Label();
            this.txtSHA256Verify = new System.Windows.Forms.TextBox();
            this.lblSHA1Verify = new System.Windows.Forms.Label();
            this.lblMD5Verify = new System.Windows.Forms.Label();
            this.txtSHA1Verify = new System.Windows.Forms.TextBox();
            this.txtMD5Verify = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSHA384 = new System.Windows.Forms.TextBox();
            this.lblSHA384 = new System.Windows.Forms.Label();
            this.txtSHA384Verify = new System.Windows.Forms.TextBox();
            this.lblSHA384Verify = new System.Windows.Forms.Label();
            this.gBFile.SuspendLayout();
            this.gBVerify.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBFile
            // 
            this.gBFile.Controls.Add(this.lblSHA384);
            this.gBFile.Controls.Add(this.txtSHA384);
            this.gBFile.Controls.Add(this.lblSHA512);
            this.gBFile.Controls.Add(this.txtSHA512);
            this.gBFile.Controls.Add(this.lblSHA256);
            this.gBFile.Controls.Add(this.txtSHA256);
            this.gBFile.Controls.Add(this.lblFile);
            this.gBFile.Controls.Add(this.lblSHA1);
            this.gBFile.Controls.Add(this.lblMD5);
            this.gBFile.Controls.Add(this.txtSHA1);
            this.gBFile.Controls.Add(this.txtMD5);
            this.gBFile.Controls.Add(this.txtFile);
            this.gBFile.Controls.Add(this.btnBrowserFile);
            this.gBFile.Location = new System.Drawing.Point(12, 12);
            this.gBFile.Name = "gBFile";
            this.gBFile.Size = new System.Drawing.Size(902, 191);
            this.gBFile.TabIndex = 10;
            this.gBFile.TabStop = false;
            // 
            // lblSHA512
            // 
            this.lblSHA512.AutoSize = true;
            this.lblSHA512.Location = new System.Drawing.Point(7, 162);
            this.lblSHA512.Name = "lblSHA512";
            this.lblSHA512.Size = new System.Drawing.Size(47, 13);
            this.lblSHA512.TabIndex = 20;
            this.lblSHA512.Text = "SHA512";
            // 
            // txtSHA512
            // 
            this.txtSHA512.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSHA512.Location = new System.Drawing.Point(64, 159);
            this.txtSHA512.Name = "txtSHA512";
            this.txtSHA512.ReadOnly = true;
            this.txtSHA512.Size = new System.Drawing.Size(832, 20);
            this.txtSHA512.TabIndex = 19;
            // 
            // lblSHA256
            // 
            this.lblSHA256.AutoSize = true;
            this.lblSHA256.Location = new System.Drawing.Point(6, 110);
            this.lblSHA256.Name = "lblSHA256";
            this.lblSHA256.Size = new System.Drawing.Size(47, 13);
            this.lblSHA256.TabIndex = 18;
            this.lblSHA256.Text = "SHA256";
            // 
            // txtSHA256
            // 
            this.txtSHA256.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSHA256.Location = new System.Drawing.Point(64, 107);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.ReadOnly = true;
            this.txtSHA256.Size = new System.Drawing.Size(768, 20);
            this.txtSHA256.TabIndex = 17;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(7, 32);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 16;
            this.lblFile.Text = "File";
            // 
            // lblSHA1
            // 
            this.lblSHA1.AutoSize = true;
            this.lblSHA1.Location = new System.Drawing.Point(7, 84);
            this.lblSHA1.Name = "lblSHA1";
            this.lblSHA1.Size = new System.Drawing.Size(35, 13);
            this.lblSHA1.TabIndex = 15;
            this.lblSHA1.Text = "SHA1";
            // 
            // lblMD5
            // 
            this.lblMD5.AutoSize = true;
            this.lblMD5.Location = new System.Drawing.Point(7, 58);
            this.lblMD5.Name = "lblMD5";
            this.lblMD5.Size = new System.Drawing.Size(30, 13);
            this.lblMD5.TabIndex = 14;
            this.lblMD5.Text = "MD5";
            // 
            // txtSHA1
            // 
            this.txtSHA1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSHA1.Location = new System.Drawing.Point(64, 81);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.ReadOnly = true;
            this.txtSHA1.Size = new System.Drawing.Size(768, 20);
            this.txtSHA1.TabIndex = 13;
            // 
            // txtMD5
            // 
            this.txtMD5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMD5.Location = new System.Drawing.Point(64, 55);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.Size = new System.Drawing.Size(768, 20);
            this.txtMD5.TabIndex = 12;
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFile.Location = new System.Drawing.Point(64, 29);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(768, 20);
            this.txtFile.TabIndex = 11;
            // 
            // btnBrowserFile
            // 
            this.btnBrowserFile.Location = new System.Drawing.Point(862, 27);
            this.btnBrowserFile.Name = "btnBrowserFile";
            this.btnBrowserFile.Size = new System.Drawing.Size(34, 23);
            this.btnBrowserFile.TabIndex = 10;
            this.btnBrowserFile.Text = "...";
            this.btnBrowserFile.UseVisualStyleBackColor = true;
            this.btnBrowserFile.Click += new System.EventHandler(this.btnBrowserFile_Click);
            // 
            // gBVerify
            // 
            this.gBVerify.Controls.Add(this.lblSHA384Verify);
            this.gBVerify.Controls.Add(this.txtSHA384Verify);
            this.gBVerify.Controls.Add(this.lblSHA512Verify);
            this.gBVerify.Controls.Add(this.txtSHA512Verify);
            this.gBVerify.Controls.Add(this.lblSHA256Verify);
            this.gBVerify.Controls.Add(this.txtSHA256Verify);
            this.gBVerify.Controls.Add(this.lblSHA1Verify);
            this.gBVerify.Controls.Add(this.lblMD5Verify);
            this.gBVerify.Controls.Add(this.txtSHA1Verify);
            this.gBVerify.Controls.Add(this.txtMD5Verify);
            this.gBVerify.Location = new System.Drawing.Point(12, 209);
            this.gBVerify.Name = "gBVerify";
            this.gBVerify.Size = new System.Drawing.Size(902, 153);
            this.gBVerify.TabIndex = 11;
            this.gBVerify.TabStop = false;
            this.gBVerify.Text = "Verify";
            // 
            // lblSHA512Verify
            // 
            this.lblSHA512Verify.AutoSize = true;
            this.lblSHA512Verify.Location = new System.Drawing.Point(7, 124);
            this.lblSHA512Verify.Name = "lblSHA512Verify";
            this.lblSHA512Verify.Size = new System.Drawing.Size(47, 13);
            this.lblSHA512Verify.TabIndex = 12;
            this.lblSHA512Verify.Text = "SHA512";
            // 
            // txtSHA512Verify
            // 
            this.txtSHA512Verify.Location = new System.Drawing.Point(64, 121);
            this.txtSHA512Verify.Name = "txtSHA512Verify";
            this.txtSHA512Verify.Size = new System.Drawing.Size(832, 20);
            this.txtSHA512Verify.TabIndex = 11;
            // 
            // lblSHA256Verify
            // 
            this.lblSHA256Verify.AutoSize = true;
            this.lblSHA256Verify.Location = new System.Drawing.Point(6, 72);
            this.lblSHA256Verify.Name = "lblSHA256Verify";
            this.lblSHA256Verify.Size = new System.Drawing.Size(47, 13);
            this.lblSHA256Verify.TabIndex = 10;
            this.lblSHA256Verify.Text = "SHA256";
            // 
            // txtSHA256Verify
            // 
            this.txtSHA256Verify.Location = new System.Drawing.Point(64, 69);
            this.txtSHA256Verify.Name = "txtSHA256Verify";
            this.txtSHA256Verify.Size = new System.Drawing.Size(768, 20);
            this.txtSHA256Verify.TabIndex = 9;
            // 
            // lblSHA1Verify
            // 
            this.lblSHA1Verify.AutoSize = true;
            this.lblSHA1Verify.Location = new System.Drawing.Point(7, 46);
            this.lblSHA1Verify.Name = "lblSHA1Verify";
            this.lblSHA1Verify.Size = new System.Drawing.Size(35, 13);
            this.lblSHA1Verify.TabIndex = 8;
            this.lblSHA1Verify.Text = "SHA1";
            // 
            // lblMD5Verify
            // 
            this.lblMD5Verify.AutoSize = true;
            this.lblMD5Verify.Location = new System.Drawing.Point(7, 20);
            this.lblMD5Verify.Name = "lblMD5Verify";
            this.lblMD5Verify.Size = new System.Drawing.Size(30, 13);
            this.lblMD5Verify.TabIndex = 7;
            this.lblMD5Verify.Text = "MD5";
            // 
            // txtSHA1Verify
            // 
            this.txtSHA1Verify.Location = new System.Drawing.Point(64, 43);
            this.txtSHA1Verify.Name = "txtSHA1Verify";
            this.txtSHA1Verify.Size = new System.Drawing.Size(768, 20);
            this.txtSHA1Verify.TabIndex = 6;
            // 
            // txtMD5Verify
            // 
            this.txtMD5Verify.Location = new System.Drawing.Point(64, 17);
            this.txtMD5Verify.Name = "txtMD5Verify";
            this.txtMD5Verify.Size = new System.Drawing.Size(768, 20);
            this.txtMD5Verify.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(423, 368);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSHA384
            // 
            this.txtSHA384.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSHA384.Location = new System.Drawing.Point(64, 133);
            this.txtSHA384.Name = "txtSHA384";
            this.txtSHA384.ReadOnly = true;
            this.txtSHA384.Size = new System.Drawing.Size(832, 20);
            this.txtSHA384.TabIndex = 21;
            // 
            // lblSHA384
            // 
            this.lblSHA384.AutoSize = true;
            this.lblSHA384.Location = new System.Drawing.Point(7, 136);
            this.lblSHA384.Name = "lblSHA384";
            this.lblSHA384.Size = new System.Drawing.Size(47, 13);
            this.lblSHA384.TabIndex = 22;
            this.lblSHA384.Text = "SHA384";
            // 
            // txtSHA384Verify
            // 
            this.txtSHA384Verify.Location = new System.Drawing.Point(64, 95);
            this.txtSHA384Verify.Name = "txtSHA384Verify";
            this.txtSHA384Verify.Size = new System.Drawing.Size(832, 20);
            this.txtSHA384Verify.TabIndex = 13;
            // 
            // lblSHA384Verify
            // 
            this.lblSHA384Verify.AutoSize = true;
            this.lblSHA384Verify.Location = new System.Drawing.Point(6, 98);
            this.lblSHA384Verify.Name = "lblSHA384Verify";
            this.lblSHA384Verify.Size = new System.Drawing.Size(47, 13);
            this.lblSHA384Verify.TabIndex = 14;
            this.lblSHA384Verify.Text = "SHA384";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 397);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gBVerify);
            this.Controls.Add(this.gBFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Calculate MD5 & SHA1 & SHA256 & SHA384 & SHA512";
            this.gBFile.ResumeLayout(false);
            this.gBFile.PerformLayout();
            this.gBVerify.ResumeLayout(false);
            this.gBVerify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblSHA1;
        private System.Windows.Forms.Label lblMD5;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowserFile;
        private System.Windows.Forms.GroupBox gBVerify;
        private System.Windows.Forms.Label lblSHA1Verify;
        private System.Windows.Forms.Label lblMD5Verify;
        private System.Windows.Forms.TextBox txtSHA1Verify;
        private System.Windows.Forms.TextBox txtMD5Verify;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSHA256;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.Label lblSHA256Verify;
        private System.Windows.Forms.TextBox txtSHA256Verify;
        private System.Windows.Forms.Label lblSHA512Verify;
        private System.Windows.Forms.TextBox txtSHA512Verify;
        private System.Windows.Forms.Label lblSHA512;
        private System.Windows.Forms.TextBox txtSHA512;
        private System.Windows.Forms.Label lblSHA384;
        private System.Windows.Forms.TextBox txtSHA384;
        private System.Windows.Forms.Label lblSHA384Verify;
        private System.Windows.Forms.TextBox txtSHA384Verify;
    }
}