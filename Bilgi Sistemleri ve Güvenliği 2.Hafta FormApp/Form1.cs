using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;

namespace Bilgi_Sistemleri_ve_Güvenliği_2.Hafta_FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string key = textBoxEncryptKey.Text;
            string iv = textBoxEncryptIv.Text;
            string text = textBoxEncryptText.Text;
            string encryptedText = AESEncoder.EncryptString(key, AESEncoder.PlainIvToByteArray(iv), text);
            labelEncryptedText.Text = encryptedText;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string key = textBoxDecryptKey.Text;
            string iv = textBoxDecryptIv.Text;
            string text = textBoxDecryptText.Text;
            string decryptedText = AESEncoder.DecryptString(key, AESEncoder.PlainIvToByteArray(iv), text);
            labelDecryptedText.Text = decryptedText;
        }

        private void buttonCopyEncrypedText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelEncryptedText.Text);
        }

        private void buttonCopyDecrypedText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelDecryptedText.Text);
        }
    }
}
