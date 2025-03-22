using System.Buffers.Text;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AdvancedEncryptionStandard
{
    public partial class AdvancedEncryptionStandard : Form
    {
        public string? Key { get; set; }
        public string? IV { get; set; }
        public string? Mode { get; set; }
        public string? KeySize { get; set; }
        public new string? Padding { get; set; }

        private readonly ToolTip toolTip = new();

        public AdvancedEncryptionStandard()
        {
            InitializeComponent();

            GbEnc.Enabled = false;
            GbDec.Enabled = false;
        }

        private void BtnConfirmAll_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(TxtKey.Text)
                || string.IsNullOrEmpty(CbKeySize.Text)
                || string.IsNullOrEmpty(CbPadding.Text)
                || string.IsNullOrEmpty(CbMode.Text)
            )
            {
                MessageBox.Show("Please enter all configurations!");
                return;
            }
            KeySize = CbKeySize.Text;
            Key = TxtKey.Text;
            Padding = CbPadding.Text;
            Mode = CbMode.Text;
            GbEnc.Enabled = true;
            GbDec.Enabled = true;

            if (CbMode.Text == "ECB")
            {
                TxtIVEncHEX.Text = "";
                TxtIVDecHEX.Text = "";
                TxtIVEncString.Text = "";
                TxtIVDecString.Text = "";
                TxtIVEncHEX.Enabled = false;
                TxtIVEncString.Enabled = false;
                TxtIVDecHEX.Enabled = false;
                TxtIVDecString.Enabled = false;
                RbIVDecHEX.Enabled = false;
                RbIVDecString.Enabled = false;
                RbIVEncHEX.Enabled = false;
                RbIVEncString.Enabled = false;
                RbIVDecHEX.Checked = false;
                RbIVDecString.Checked = false;
                RbIVEncHEX.Checked = false;
                RbIVEncString.Checked = false;
            }
            else
            {
                TxtIVEncHEX.Enabled = true;
                TxtIVDecHEX.Enabled = true;
                TxtIVEncString.Enabled = true;
                TxtIVDecString.Enabled = true;
                RbIVDecHEX.Enabled = true;
                RbIVDecString.Enabled = true;
                RbIVEncHEX.Enabled = true;
                RbIVEncString.Enabled = true;
            }
            MessageBox.Show("Configurations saved!");
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            IV = RbIVEncHEX.Checked ? TxtIVEncHEX.Text : TxtIVEncString.Text;
            if (
                string.IsNullOrEmpty(Key)
                || string.IsNullOrEmpty(Padding)
                || string.IsNullOrEmpty(Mode)
                || string.IsNullOrEmpty(KeySize)
            )
            {
                MessageBox.Show("Key / Padding / Mode / Key Size cannot be null or empty!");
                return;
            }

            string encrypted = AESEncryption(
                TxtPlain.Text,
                Key,
                IV,
                Padding,
                CbOutFormat.Text,
                Mode,
                KeySize
            );
            TxtCipher.Text = encrypted;
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            IV = RbIVDecHEX.Checked ? TxtIVDecHEX.Text : TxtIVDecString.Text;
            if (
                string.IsNullOrEmpty(Key)
                || string.IsNullOrEmpty(Padding)
                || string.IsNullOrEmpty(Mode)
                || string.IsNullOrEmpty(KeySize)
            )
            {
                MessageBox.Show("Key / Padding / Mode / Key Size cannot be null or empty!");
                return;
            }
            string decrypted = AESDecryption(
                TxtCipher.Text,
                Key,
                IV,
                Padding,
                CbInFormat.Text,
                Mode,
                KeySize
            );
            TxtPlain.Text = decrypted;
        }

        private void BtnClearEnc_Click(object sender, EventArgs e)
        {
            TxtPlain.Text = "";
            TxtIVEncHEX.Text = "";
            TxtIVEncString.Text = "";
            CbOutFormat.SelectedIndex = -1;
        }

        private void BtnClearDec_Click(object sender, EventArgs e)
        {
            TxtCipher.Text = "";
            TxtIVDecHEX.Text = "";
            TxtIVDecString.Text = "";
            CbInFormat.SelectedIndex = -1;
        }

        private void CbKeySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbKeySize.Text == "AES-128")
            {
                TxtKey.MaxLength = 16;
            }
            else if (CbKeySize.Text == "AES-192")
            {
                TxtKey.MaxLength = 24;
            }
            else if (CbKeySize.Text == "AES-256")
            {
                TxtKey.MaxLength = 32;
            }
        }

        private void RbIVEncHEX_CheckedChanged(object sender, EventArgs e)
        {
            TxtIVEncString.Clear();
            TxtIVEncString.Enabled = false;
            TxtIVEncHEX.Enabled = true;
        }

        private void RbIVEncString_CheckedChanged(object sender, EventArgs e)
        {
            TxtIVEncHEX.Clear();
            TxtIVEncHEX.Enabled = false;
            TxtIVEncString.Enabled = true;
        }

        private void RbIVDecString_CheckedChanged(object sender, EventArgs e)
        {
            TxtIVDecHEX.Clear();
            TxtIVDecHEX.Enabled = false;
            TxtIVDecString.Enabled = true;
        }

        private void RbIVDecHEX_CheckedChanged(object sender, EventArgs e)
        {
            TxtIVDecString.Clear();
            TxtIVDecString.Enabled = false;
            TxtIVDecHEX.Enabled = true;
        }

        private void CheckHash_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(
                (Control)sender,
                "Enable key hashing to match the selected AES key size. Click to apply."
            );
        }

        private string AESEncryption(
            string plainText,
            string Key,
            string IV,
            string Padding,
            string OutputFormat,
            string Mode,
            string KeySize
        )
        {
            using Aes aes = Aes.Create();

            bool useHash = CheckHash.Checked;
            byte[] keyBytes = GenerateAESKey(
                Encoding.ASCII.GetBytes(Key),
                KeySize,
                Padding,
                useHash
            );
            aes.Key = keyBytes;
            byte[] ivBytes = Encoding.ASCII.GetBytes(IV);

            if (RbIVEncHEX.Checked)
            {
                if (string.IsNullOrEmpty(IV) || IV.Length != 32)
                    throw new ArgumentException("HEX IV must be exactly 32 characters.");

                ivBytes = Enumerable
                    .Range(0, 16)
                    .Select(i => Convert.ToByte(IV.Substring(i * 2, 2), 16))
                    .ToArray();
            }
            else if (RbIVEncString.Checked)
            {
                ivBytes = Encoding.ASCII.GetBytes(IV);
                if (ivBytes.Length != 16)
                    throw new ArgumentException("IV must be exactly 16 bytes long");
            }

            aes.Mode = Mode switch
            {
                "ECB" => CipherMode.ECB,
                "CBC" => CipherMode.CBC,
                "CFB" => CipherMode.CFB,
                "OFB" => CipherMode.OFB,
                _ => CipherMode.CBC,
            };

            if (aes.Mode != CipherMode.ECB)
            {
                aes.IV = ivBytes;
            }

            using MemoryStream memoryStream = new();
            using CryptoStream cryptoStream = new(
                memoryStream,
                aes.CreateEncryptor(),
                CryptoStreamMode.Write
            );
            using StreamWriter streamWriter = new(cryptoStream);
            streamWriter.Write(plainText);
            streamWriter.Close();

            return OutputFormat switch
            {
                "Base64" => Convert.ToBase64String(memoryStream.ToArray()),
                "HEX" => BitConverter.ToString(memoryStream.ToArray()).Replace("-", ""),
                _ => Convert.ToBase64String(memoryStream.ToArray()),
            };
        }

        private string AESDecryption(
            string cipherText,
            string Key,
            string IV,
            string Padding,
            string InputFormat,
            string Mode,
            string KeySize
        )
        {
            using Aes aes = Aes.Create();

            bool useHash = CheckHash.Checked;
            byte[] keyBytes = GenerateAESKey(
                Encoding.ASCII.GetBytes(Key),
                KeySize,
                Padding,
                useHash
            );
            aes.Key = keyBytes;

            byte[] ivBytes = Encoding.ASCII.GetBytes(IV);

            if (RbIVDecHEX.Checked)
            {
                if (string.IsNullOrEmpty(IV) || IV.Length != 32)
                    throw new ArgumentException("HEX IV must be exactly 32 characters.");

                ivBytes = Enumerable
                    .Range(0, 16)
                    .Select(i => Convert.ToByte(IV.Substring(i * 2, 2), 16))
                    .ToArray();
            }
            else if (RbIVDecString.Checked)
            {
                ivBytes = Encoding.ASCII.GetBytes(IV);
                if (ivBytes.Length != 16)
                    throw new ArgumentException("IV must be exactly 16 bytes long");
            }

            aes.Mode = Mode switch
            {
                "ECB" => CipherMode.ECB,
                "CBC" => CipherMode.CBC,
                "CFB" => CipherMode.CFB,
                "OFB" => CipherMode.OFB,
                _ => CipherMode.CBC,
            };

            if (aes.Mode != CipherMode.ECB)
            {
                aes.IV = ivBytes;
            }

            byte[] cipherBytes = InputFormat switch
            {
                "Base64" => Convert.FromBase64String(cipherText),
                "HEX" => Enumerable
                    .Range(0, cipherText.Length / 2)
                    .Select(i => Convert.ToByte(cipherText.Substring(i * 2, 2), 16))
                    .ToArray(),
                _ => Convert.FromBase64String(cipherText),
            };

            using MemoryStream memoryStream = new(cipherBytes);
            using CryptoStream cryptoStream = new(
                memoryStream,
                aes.CreateDecryptor(),
                CryptoStreamMode.Read
            );
            using StreamReader streamReader = new(cryptoStream);
            return streamReader.ReadToEnd();
        }

        public static byte[] GenerateAESKey(
            byte[] keyBytes,
            string keySize,
            string padding,
            bool useHash
        )
        {
            int keyLength = keySize switch
            {
                "AES-256" => 32,
                "AES-192" => 24,
                "AES-128" => 16,
                _ => throw new ArgumentException(
                    "Invalid key size. Use AES-128, AES-192, or AES-256."
                ),
            };

            byte[] adjustedKey;

            if (keyBytes.Length >= keyLength)
            {
                adjustedKey = keyBytes.Take(keyLength).ToArray();
            }
            else
            {
                int padLength = keyLength - keyBytes.Length;
                adjustedKey = padding switch
                {
                    "PKCS7" => keyBytes
                        .Concat(Enumerable.Repeat((byte)padLength, padLength))
                        .ToArray(),
                    "ZeroPadding" => keyBytes.Concat(new byte[padLength]).ToArray(),
                    _ => throw new ArgumentException(
                        "Invalid padding. Use 'PKCS7' or 'ZeroPadding'."
                    ),
                };
            }

            if (useHash)
            {
                using SHA256 sha256 = SHA256.Create();
                byte[] hashedKey = sha256.ComputeHash(adjustedKey);
                byte[] finalKey = hashedKey.Take(keyLength).ToArray();
                return finalKey;
            }

            return adjustedKey;
        }
    }
}
