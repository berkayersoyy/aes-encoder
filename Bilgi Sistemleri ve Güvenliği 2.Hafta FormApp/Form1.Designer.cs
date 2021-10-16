
namespace Bilgi_Sistemleri_ve_Güvenliği_2.Hafta_FormApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEncryptKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEncryptIv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEncryptText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDecryptText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDecryptIv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDecryptKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelEncryptedText = new System.Windows.Forms.Label();
            this.labelDecryptedText = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonCopyEncrypedText = new System.Windows.Forms.Button();
            this.buttonCopyDecrypedText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decrypt";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxEncryptKey
            // 
            this.textBoxEncryptKey.Location = new System.Drawing.Point(77, 77);
            this.textBoxEncryptKey.Name = "textBoxEncryptKey";
            this.textBoxEncryptKey.Size = new System.Drawing.Size(100, 23);
            this.textBoxEncryptKey.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Iv";
            // 
            // textBoxEncryptIv
            // 
            this.textBoxEncryptIv.Location = new System.Drawing.Point(77, 121);
            this.textBoxEncryptIv.Name = "textBoxEncryptIv";
            this.textBoxEncryptIv.Size = new System.Drawing.Size(100, 23);
            this.textBoxEncryptIv.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Text";
            // 
            // textBoxEncryptText
            // 
            this.textBoxEncryptText.Location = new System.Drawing.Point(77, 169);
            this.textBoxEncryptText.Name = "textBoxEncryptText";
            this.textBoxEncryptText.Size = new System.Drawing.Size(100, 23);
            this.textBoxEncryptText.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Text";
            // 
            // textBoxDecryptText
            // 
            this.textBoxDecryptText.Location = new System.Drawing.Point(455, 169);
            this.textBoxDecryptText.Name = "textBoxDecryptText";
            this.textBoxDecryptText.Size = new System.Drawing.Size(100, 23);
            this.textBoxDecryptText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Iv";
            // 
            // textBoxDecryptIv
            // 
            this.textBoxDecryptIv.Location = new System.Drawing.Point(455, 121);
            this.textBoxDecryptIv.Name = "textBoxDecryptIv";
            this.textBoxDecryptIv.Size = new System.Drawing.Size(100, 23);
            this.textBoxDecryptIv.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Key";
            // 
            // textBoxDecryptKey
            // 
            this.textBoxDecryptKey.Location = new System.Drawing.Point(455, 77);
            this.textBoxDecryptKey.Name = "textBoxDecryptKey";
            this.textBoxDecryptKey.Size = new System.Drawing.Size(100, 23);
            this.textBoxDecryptKey.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Encrypted Text:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Decrypted Text:";
            // 
            // labelEncryptedText
            // 
            this.labelEncryptedText.AutoSize = true;
            this.labelEncryptedText.Location = new System.Drawing.Point(12, 311);
            this.labelEncryptedText.Name = "labelEncryptedText";
            this.labelEncryptedText.Size = new System.Drawing.Size(0, 15);
            this.labelEncryptedText.TabIndex = 15;
            // 
            // labelDecryptedText
            // 
            this.labelDecryptedText.AutoSize = true;
            this.labelDecryptedText.Location = new System.Drawing.Point(12, 385);
            this.labelDecryptedText.Name = "labelDecryptedText";
            this.labelDecryptedText.Size = new System.Drawing.Size(0, 15);
            this.labelDecryptedText.TabIndex = 16;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(77, 214);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypt.TabIndex = 17;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(455, 214);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 17;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonCopyEncrypedText
            // 
            this.buttonCopyEncrypedText.Location = new System.Drawing.Point(119, 275);
            this.buttonCopyEncrypedText.Name = "buttonCopyEncrypedText";
            this.buttonCopyEncrypedText.Size = new System.Drawing.Size(33, 23);
            this.buttonCopyEncrypedText.TabIndex = 18;
            this.buttonCopyEncrypedText.Text = "C";
            this.buttonCopyEncrypedText.UseVisualStyleBackColor = true;
            this.buttonCopyEncrypedText.Click += new System.EventHandler(this.buttonCopyEncrypedText_Click);
            // 
            // buttonCopyDecrypedText
            // 
            this.buttonCopyDecrypedText.Location = new System.Drawing.Point(119, 350);
            this.buttonCopyDecrypedText.Name = "buttonCopyDecrypedText";
            this.buttonCopyDecrypedText.Size = new System.Drawing.Size(33, 23);
            this.buttonCopyDecrypedText.TabIndex = 18;
            this.buttonCopyDecrypedText.Text = "C";
            this.buttonCopyDecrypedText.UseVisualStyleBackColor = true;
            this.buttonCopyDecrypedText.Click += new System.EventHandler(this.buttonCopyDecrypedText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 534);
            this.Controls.Add(this.buttonCopyDecrypedText);
            this.Controls.Add(this.buttonCopyEncrypedText);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.labelDecryptedText);
            this.Controls.Add(this.labelEncryptedText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDecryptText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDecryptIv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDecryptKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEncryptText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEncryptIv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEncryptKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEncryptKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEncryptIv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEncryptText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDecryptText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDecryptIv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDecryptKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelEncryptedText;
        private System.Windows.Forms.Label labelDecryptedText;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonCopyEncrypedText;
        private System.Windows.Forms.Button buttonCopyDecrypedText;
    }
}

