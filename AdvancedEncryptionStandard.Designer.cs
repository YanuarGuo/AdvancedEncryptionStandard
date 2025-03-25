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
            CheckHash = new CheckBox();
            BtnConfirmAll = new Button();
            label4 = new Label();
            CbMode = new ComboBox();
            label3 = new Label();
            CbPadding = new ComboBox();
            TxtKey = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            CbKeySize = new ComboBox();
            GbEnc = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            RbIVEncString = new RadioButton();
            TxtIVEncString = new TextBox();
            RbIVEncHEX = new RadioButton();
            BtnEncrypt = new Button();
            BtnClearEnc = new Button();
            label7 = new Label();
            CbOutFormat = new ComboBox();
            TxtIVEncHEX = new TextBox();
            label6 = new Label();
            label5 = new Label();
            TxtPlain = new TextBox();
            GbDec = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            RbIVDecString = new RadioButton();
            RbIVDecHEX = new RadioButton();
            TxtIVDecString = new TextBox();
            BtnDecrypt = new Button();
            BtnClearDec = new Button();
            label8 = new Label();
            CbInFormat = new ComboBox();
            TxtIVDecHEX = new TextBox();
            label9 = new Label();
            label10 = new Label();
            TxtCipher = new TextBox();
            GbConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            GbEnc.SuspendLayout();
            GbDec.SuspendLayout();
            SuspendLayout();
            // 
            // GbConfig
            // 
            GbConfig.Controls.Add(CheckHash);
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
            // CheckHash
            // 
            CheckHash.AutoSize = true;
            CheckHash.Location = new Point(334, 98);
            CheckHash.Name = "CheckHash";
            CheckHash.Size = new Size(119, 19);
            CheckHash.TabIndex = 11;
            CheckHash.Text = "Use Key Hashing*";
            CheckHash.UseVisualStyleBackColor = true;
            CheckHash.MouseEnter += CheckHash_MouseEnter;
            // 
            // BtnConfirmAll
            // 
            BtnConfirmAll.Location = new Point(347, 192);
            BtnConfirmAll.Name = "BtnConfirmAll";
            BtnConfirmAll.Size = new Size(99, 23);
            BtnConfirmAll.TabIndex = 10;
            BtnConfirmAll.Text = "Confirm";
            BtnConfirmAll.UseVisualStyleBackColor = true;
            BtnConfirmAll.Click += BtnConfirmAll_Click;
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
            // CbMode
            // 
            CbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            CbMode.FormattingEnabled = true;
            CbMode.Items.AddRange(new object[] { "ECB", "CBC", "OFB", "CFB" });
            CbMode.Location = new Point(241, 150);
            CbMode.Name = "CbMode";
            CbMode.Size = new Size(205, 23);
            CbMode.TabIndex = 8;
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
            // TxtKey
            // 
            TxtKey.Location = new Point(17, 96);
            TxtKey.MaxLength = 32;
            TxtKey.Name = "TxtKey";
            TxtKey.Size = new Size(311, 23);
            TxtKey.TabIndex = 5;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(31, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 1);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            // CbKeySize
            // 
            CbKeySize.DropDownStyle = ComboBoxStyle.DropDownList;
            CbKeySize.FormattingEnabled = true;
            CbKeySize.Items.AddRange(new object[] { "AES-128", "AES-192", "AES-256" });
            CbKeySize.Location = new Point(100, 22);
            CbKeySize.Name = "CbKeySize";
            CbKeySize.Size = new Size(346, 23);
            CbKeySize.TabIndex = 0;
            CbKeySize.SelectedIndexChanged += CbKeySize_SelectedIndexChanged;
            // 
            // GbEnc
            // 
            GbEnc.Controls.Add(label12);
            GbEnc.Controls.Add(label11);
            GbEnc.Controls.Add(RbIVEncString);
            GbEnc.Controls.Add(TxtIVEncString);
            GbEnc.Controls.Add(RbIVEncHEX);
            GbEnc.Controls.Add(BtnEncrypt);
            GbEnc.Controls.Add(BtnClearEnc);
            GbEnc.Controls.Add(label7);
            GbEnc.Controls.Add(CbOutFormat);
            GbEnc.Controls.Add(TxtIVEncHEX);
            GbEnc.Controls.Add(label6);
            GbEnc.Controls.Add(label5);
            GbEnc.Controls.Add(TxtPlain);
            GbEnc.Location = new Point(12, 262);
            GbEnc.Name = "GbEnc";
            GbEnc.Size = new Size(224, 376);
            GbEnc.TabIndex = 1;
            GbEnc.TabStop = false;
            GbEnc.Text = "Encryption";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Franklin Gothic Book", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(129, 235);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 20;
            label12.Text = "String (16 Chars)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Book", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(138, 189);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 19;
            label11.Text = "HEX (32 Chars)";
            // 
            // RbIVEncString
            // 
            RbIVEncString.AutoSize = true;
            RbIVEncString.Location = new Point(11, 254);
            RbIVEncString.Name = "RbIVEncString";
            RbIVEncString.Size = new Size(14, 13);
            RbIVEncString.TabIndex = 18;
            RbIVEncString.TabStop = true;
            RbIVEncString.UseVisualStyleBackColor = true;
            RbIVEncString.CheckedChanged += RbIVEncString_CheckedChanged;
            // 
            // TxtIVEncString
            // 
            TxtIVEncString.Location = new Point(31, 250);
            TxtIVEncString.MaxLength = 16;
            TxtIVEncString.Name = "TxtIVEncString";
            TxtIVEncString.Size = new Size(184, 23);
            TxtIVEncString.TabIndex = 17;
            // 
            // RbIVEncHEX
            // 
            RbIVEncHEX.AutoSize = true;
            RbIVEncHEX.Location = new Point(11, 209);
            RbIVEncHEX.Name = "RbIVEncHEX";
            RbIVEncHEX.Size = new Size(14, 13);
            RbIVEncHEX.TabIndex = 16;
            RbIVEncHEX.TabStop = true;
            RbIVEncHEX.UseVisualStyleBackColor = true;
            RbIVEncHEX.CheckedChanged += RbIVEncHEX_CheckedChanged;
            // 
            // BtnEncrypt
            // 
            BtnEncrypt.Location = new Point(116, 337);
            BtnEncrypt.Name = "BtnEncrypt";
            BtnEncrypt.Size = new Size(99, 23);
            BtnEncrypt.TabIndex = 15;
            BtnEncrypt.Text = "Encrypt";
            BtnEncrypt.UseVisualStyleBackColor = true;
            BtnEncrypt.Click += BtnEncrypt_Click;
            // 
            // BtnClearEnc
            // 
            BtnClearEnc.Location = new Point(11, 337);
            BtnClearEnc.Name = "BtnClearEnc";
            BtnClearEnc.Size = new Size(99, 23);
            BtnClearEnc.TabIndex = 14;
            BtnClearEnc.Text = "Clear";
            BtnClearEnc.UseVisualStyleBackColor = true;
            BtnClearEnc.Click += BtnClearEnc_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 284);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 12;
            label7.Text = "Output Format";
            // 
            // CbOutFormat
            // 
            CbOutFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            CbOutFormat.FormattingEnabled = true;
            CbOutFormat.Items.AddRange(new object[] { "Base64", "HEX" });
            CbOutFormat.Location = new Point(11, 302);
            CbOutFormat.Name = "CbOutFormat";
            CbOutFormat.Size = new Size(204, 23);
            CbOutFormat.TabIndex = 11;
            // 
            // TxtIVEncHEX
            // 
            TxtIVEncHEX.Location = new Point(31, 205);
            TxtIVEncHEX.MaxLength = 32;
            TxtIVEncHEX.Name = "TxtIVEncHEX";
            TxtIVEncHEX.Size = new Size(184, 23);
            TxtIVEncHEX.TabIndex = 10;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 31);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Plain Text";
            // 
            // TxtPlain
            // 
            TxtPlain.Location = new Point(11, 49);
            TxtPlain.Multiline = true;
            TxtPlain.Name = "TxtPlain";
            TxtPlain.Size = new Size(204, 111);
            TxtPlain.TabIndex = 6;
            // 
            // GbDec
            // 
            GbDec.Controls.Add(label14);
            GbDec.Controls.Add(label13);
            GbDec.Controls.Add(RbIVDecString);
            GbDec.Controls.Add(RbIVDecHEX);
            GbDec.Controls.Add(TxtIVDecString);
            GbDec.Controls.Add(BtnDecrypt);
            GbDec.Controls.Add(BtnClearDec);
            GbDec.Controls.Add(label8);
            GbDec.Controls.Add(CbInFormat);
            GbDec.Controls.Add(TxtIVDecHEX);
            GbDec.Controls.Add(label9);
            GbDec.Controls.Add(label10);
            GbDec.Controls.Add(TxtCipher);
            GbDec.Location = new Point(253, 262);
            GbDec.Name = "GbDec";
            GbDec.Size = new Size(224, 376);
            GbDec.TabIndex = 16;
            GbDec.TabStop = false;
            GbDec.Text = "Decryption";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Franklin Gothic Book", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(129, 235);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 21;
            label14.Text = "String (16 Chars)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Franklin Gothic Book", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(138, 189);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 20;
            label13.Text = "HEX (32 Chars)";
            // 
            // RbIVDecString
            // 
            RbIVDecString.AutoSize = true;
            RbIVDecString.Location = new Point(11, 254);
            RbIVDecString.Name = "RbIVDecString";
            RbIVDecString.Size = new Size(14, 13);
            RbIVDecString.TabIndex = 18;
            RbIVDecString.TabStop = true;
            RbIVDecString.UseVisualStyleBackColor = true;
            RbIVDecString.CheckedChanged += RbIVDecString_CheckedChanged;
            // 
            // RbIVDecHEX
            // 
            RbIVDecHEX.AutoSize = true;
            RbIVDecHEX.Location = new Point(11, 209);
            RbIVDecHEX.Name = "RbIVDecHEX";
            RbIVDecHEX.Size = new Size(14, 13);
            RbIVDecHEX.TabIndex = 17;
            RbIVDecHEX.TabStop = true;
            RbIVDecHEX.UseVisualStyleBackColor = true;
            RbIVDecHEX.CheckedChanged += RbIVDecHEX_CheckedChanged;
            // 
            // TxtIVDecString
            // 
            TxtIVDecString.Location = new Point(31, 250);
            TxtIVDecString.MaxLength = 16;
            TxtIVDecString.Name = "TxtIVDecString";
            TxtIVDecString.Size = new Size(184, 23);
            TxtIVDecString.TabIndex = 16;
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(116, 337);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(99, 23);
            BtnDecrypt.TabIndex = 15;
            BtnDecrypt.Text = "Decrypt";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // BtnClearDec
            // 
            BtnClearDec.Location = new Point(11, 337);
            BtnClearDec.Name = "BtnClearDec";
            BtnClearDec.Size = new Size(99, 23);
            BtnClearDec.TabIndex = 14;
            BtnClearDec.Text = "Clear";
            BtnClearDec.UseVisualStyleBackColor = true;
            BtnClearDec.Click += BtnClearDec_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 284);
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
            CbInFormat.Location = new Point(11, 302);
            CbInFormat.Name = "CbInFormat";
            CbInFormat.Size = new Size(204, 23);
            CbInFormat.TabIndex = 11;
            // 
            // TxtIVDecHEX
            // 
            TxtIVDecHEX.Location = new Point(31, 205);
            TxtIVDecHEX.MaxLength = 32;
            TxtIVDecHEX.Name = "TxtIVDecHEX";
            TxtIVDecHEX.Size = new Size(184, 23);
            TxtIVDecHEX.TabIndex = 10;
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
            ClientSize = new Size(489, 650);
            Controls.Add(GbDec);
            Controls.Add(GbEnc);
            Controls.Add(GbConfig);
            Name = "AdvancedEncryptionStandard";
            Text = "AdvancedEncryptionStandard";
            GbConfig.ResumeLayout(false);
            GbConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            GbEnc.ResumeLayout(false);
            GbEnc.PerformLayout();
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
        private Button BtnEncrypt;
        private Button BtnClearEnc;
        private Label label7;
        private ComboBox CbOutFormat;
        private TextBox TxtIVEncHEX;
        private Label label6;
        private Label label5;
        private TextBox TxtPlain;
        private GroupBox GbDec;
        private Button BtnDecrypt;
        private Button BtnClearDec;
        private Label label8;
        private ComboBox CbInFormat;
        private TextBox TxtIVDecHEX;
        private Label label9;
        private Label label10;
        private TextBox TxtCipher;
        private CheckBox CheckHash;
        private RadioButton RbIVEncHEX;
        private Label label11;
        private RadioButton RbIVEncString;
        private TextBox TxtIVEncString;
        private Label label12;
        private Label label13;
        private RadioButton RbIVDecString;
        private RadioButton RbIVDecHEX;
        private TextBox TxtIVDecString;
        private Label label14;
    }
}
