namespace AdvancedEncryptionStandard
{
    partial class AdvancedEncryptionStandard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GbConfig = new GroupBox();
            GbEnc = new GroupBox();
            CbKeySize = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            TxtKey = new TextBox();
            CbPadding = new ComboBox();
            label3 = new Label();
            CbMode = new ComboBox();
            label4 = new Label();
            BtnConfirmAll = new Button();
            TxtPlain = new TextBox();
            label5 = new Label();
            label6 = new Label();
            TxtIVEnc = new TextBox();
            CbOutFormat = new ComboBox();
            label7 = new Label();
            BtnClearEnc = new Button();
            BtnEnc = new Button();
            GbDec = new GroupBox();
            BtnDec = new Button();
            BtnClearDec = new Button();
            label8 = new Label();
            CbInFormat = new ComboBox();
            TxtIVDec = new TextBox();
            label9 = new Label();
            label10 = new Label();
            TxtCipher = new TextBox();
            GbConfig.SuspendLayout();
            GbEnc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            GbDec.SuspendLayout();
            SuspendLayout();
            // 
            // GbConfig
            // 
            GbConfig.Controls.Add(BtnConfirmAll);
            GbConfig.Controls.Add(label4);
            GbConfig.Controls.Add(CbMode);
            GbConfig.Controls.Add(label3);
            GbConfig.Controls.Add(CbPadding);
            GbConfig.Controls.Add(TxtKey);
            GbConfig.Controls.Add(label2);
            GbConfig.Controls.Add(pictureBox1);
            GbConfig.Controls.Add(label1);
            GbConfig.Controls.Add(CbKeySize);
            GbConfig.Location = new Point(12, 12);
            GbConfig.Name = "GbConfig";
            GbConfig.Size = new Size(465, 234);
            GbConfig.TabIndex = 0;
            GbConfig.TabStop = false;
            GbConfig.Text = "Advanced Encryption Standard Configuration";
            // 
            // GbEnc
            // 
            GbEnc.Controls.Add(BtnEnc);
            GbEnc.Controls.Add(BtnClearEnc);
            GbEnc.Controls.Add(label7);
            GbEnc.Controls.Add(CbOutFormat);
            GbEnc.Controls.Add(TxtIVEnc);
            GbEnc.Controls.Add(label6);
            GbEnc.Controls.Add(label5);
            GbEnc.Controls.Add(TxtPlain);
            GbEnc.Location = new Point(12, 262);
            GbEnc.Name = "GbEnc";
            GbEnc.Size = new Size(224, 312);
            GbEnc.TabIndex = 1;
            GbEnc.TabStop = false;
            GbEnc.Text = "Encryption";
            // 
            // CbKeySize
            // 
            CbKeySize.DropDownStyle = ComboBoxStyle.DropDownList;
            CbKeySize.FormattingEnabled = true;
            CbKeySize.Items.AddRange(new object[] { "AES-128", "AES-192", "AES-256" });
            CbKeySize.Location = new Point(100, 22);
            CbKeySize.Name = "CbKeySize";
            CbKeySize.Size = new Size(346, 23);
            CbKeySize.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "AES Key Size";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(31, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 1);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 78);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "AES Key";
            // 
            // TxtKey
            // 
            TxtKey.Location = new Point(17, 96);
            TxtKey.Name = "TxtKey";
            TxtKey.Size = new Size(429, 23);
            TxtKey.TabIndex = 5;
            // 
            // CbPadding
            // 
            CbPadding.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPadding.FormattingEnabled = true;
            CbPadding.Items.AddRange(new object[] { "PKCS7", "ZeroPadding" });
            CbPadding.Location = new Point(17, 150);
            CbPadding.Name = "CbPadding";
            CbPadding.Size = new Size(207, 23);
            CbPadding.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 132);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Padding";
            // 
            // CbMode
            // 
            CbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            CbMode.FormattingEnabled = true;
            CbMode.Items.AddRange(new object[] { "ECB", "CBC", "CFB", "OFB", "CTR", "GCM" });
            CbMode.Location = new Point(241, 150);
            CbMode.Name = "CbMode";
            CbMode.Size = new Size(205, 23);
            CbMode.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 132);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 9;
            label4.Text = "Cipher Mode";
            // 
            // BtnConfirmAll
            // 
            BtnConfirmAll.Location = new Point(347, 192);
            BtnConfirmAll.Name = "BtnConfirmAll";
            BtnConfirmAll.Size = new Size(99, 23);
            BtnConfirmAll.TabIndex = 10;
            BtnConfirmAll.Text = "Confirm";
            BtnConfirmAll.UseVisualStyleBackColor = true;
            // 
            // TxtPlain
            // 
            TxtPlain.Location = new Point(11, 49);
            TxtPlain.Multiline = true;
            TxtPlain.Name = "TxtPlain";
            TxtPlain.Size = new Size(204, 111);
            TxtPlain.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 31);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Plain Text";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 168);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 9;
            label6.Text = "Initialization Vector";
            // 
            // TxtIVEnc
            // 
            TxtIVEnc.Location = new Point(11, 186);
            TxtIVEnc.Name = "TxtIVEnc";
            TxtIVEnc.Size = new Size(204, 23);
            TxtIVEnc.TabIndex = 10;
            // 
            // CbOutFormat
            // 
            CbOutFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            CbOutFormat.FormattingEnabled = true;
            CbOutFormat.Items.AddRange(new object[] { "Base64", "HEX" });
            CbOutFormat.Location = new Point(11, 237);
            CbOutFormat.Name = "CbOutFormat";
            CbOutFormat.Size = new Size(204, 23);
            CbOutFormat.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 219);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 12;
            label7.Text = "Output Format";
            // 
            // BtnClearEnc
            // 
            BtnClearEnc.Location = new Point(11, 272);
            BtnClearEnc.Name = "BtnClearEnc";
            BtnClearEnc.Size = new Size(99, 23);
            BtnClearEnc.TabIndex = 14;
            BtnClearEnc.Text = "Clear";
            BtnClearEnc.UseVisualStyleBackColor = true;
            // 
            // BtnEnc
            // 
            BtnEnc.Location = new Point(116, 272);
            BtnEnc.Name = "BtnEnc";
            BtnEnc.Size = new Size(99, 23);
            BtnEnc.TabIndex = 15;
            BtnEnc.Text = "Encrypt";
            BtnEnc.UseVisualStyleBackColor = true;
            // 
            // GbDec
            // 
            GbDec.Controls.Add(BtnDec);
            GbDec.Controls.Add(BtnClearDec);
            GbDec.Controls.Add(label8);
            GbDec.Controls.Add(CbInFormat);
            GbDec.Controls.Add(TxtIVDec);
            GbDec.Controls.Add(label9);
            GbDec.Controls.Add(label10);
            GbDec.Controls.Add(TxtCipher);
            GbDec.Location = new Point(253, 262);
            GbDec.Name = "GbDec";
            GbDec.Size = new Size(224, 312);
            GbDec.TabIndex = 16;
            GbDec.TabStop = false;
            GbDec.Text = "Decryption";
            // 
            // BtnDec
            // 
            BtnDec.Location = new Point(116, 272);
            BtnDec.Name = "BtnDec";
            BtnDec.Size = new Size(99, 23);
            BtnDec.TabIndex = 15;
            BtnDec.Text = "Decrypt";
            BtnDec.UseVisualStyleBackColor = true;
            // 
            // BtnClearDec
            // 
            BtnClearDec.Location = new Point(11, 272);
            BtnClearDec.Name = "BtnClearDec";
            BtnClearDec.Size = new Size(99, 23);
            BtnClearDec.TabIndex = 14;
            BtnClearDec.Text = "Clear";
            BtnClearDec.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 219);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 12;
            label8.Text = "Input Format";
            // 
            // CbInFormat
            // 
            CbInFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            CbInFormat.FormattingEnabled = true;
            CbInFormat.Items.AddRange(new object[] { "Base64", "HEX" });
            CbInFormat.Location = new Point(11, 237);
            CbInFormat.Name = "CbInFormat";
            CbInFormat.Size = new Size(204, 23);
            CbInFormat.TabIndex = 11;
            // 
            // TxtIVDec
            // 
            TxtIVDec.Location = new Point(11, 186);
            TxtIVDec.Name = "TxtIVDec";
            TxtIVDec.Size = new Size(204, 23);
            TxtIVDec.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 168);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 9;
            label9.Text = "Initialization Vector";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 31);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 8;
            label10.Text = "Cipher Text";
            // 
            // TxtCipher
            // 
            TxtCipher.Location = new Point(11, 49);
            TxtCipher.Multiline = true;
            TxtCipher.Name = "TxtCipher";
            TxtCipher.Size = new Size(204, 111);
            TxtCipher.TabIndex = 6;
            // 
            // AdvancedEncryptionStandard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 586);
            Controls.Add(GbDec);
            Controls.Add(GbEnc);
            Controls.Add(GbConfig);
            Name = "AdvancedEncryptionStandard";
            Text = "AdvancedEncryptionStandard";
            GbConfig.ResumeLayout(false);
            GbConfig.PerformLayout();
            GbEnc.ResumeLayout(false);
            GbEnc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            GbDec.ResumeLayout(false);
            GbDec.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbConfig;
        private GroupBox GbEnc;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox CbKeySize;
        private Button BtnConfirmAll;
        private Label label4;
        private ComboBox CbMode;
        private Label label3;
        private ComboBox CbPadding;
        private TextBox TxtKey;
        private Label label2;
        private Button BtnEnc;
        private Button BtnClearEnc;
        private Label label7;
        private ComboBox CbOutFormat;
        private TextBox TxtIVEnc;
        private Label label6;
        private Label label5;
        private TextBox TxtPlain;
        private GroupBox GbDec;
        private Button BtnDec;
        private Button BtnClearDec;
        private Label label8;
        private ComboBox CbInFormat;
        private TextBox TxtIVDec;
        private Label label9;
        private Label label10;
        private TextBox TxtCipher;
    }
}
