using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace AutoKey_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static String alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static String AutoEncryption(String text, String key)
        {
            int len = text.Length;

            String subkey = key + text;
            subkey = subkey.Substring(0, subkey.Length - key.Length);

            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < len; x++)
            {
                int get1 = alpha.IndexOf(text[x]);
                int get2 = alpha.IndexOf(subkey[x]);

                int total = (get1 + get2) % 26;

                sb.Append(alpha[total]);
            }

            return sb.ToString();
        }

        public static String AutoDecryption(String text, String key)
        {
            int len = text.Length;

            StringBuilder current = new StringBuilder(key);
            StringBuilder sb = new StringBuilder();

            for (int x = 0; x < len; x++)
            {
                int get1 = alpha.IndexOf(text[x]);
                int get2 = alpha.IndexOf(current[x]);

                int total = (get1 - get2) % 26;
                total = (total < 0) ? total + 26 : total;
                sb.Append(alpha[total]);

                current.Append(alpha[total]);
            }
            return sb.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void encryptbutton_Click(object sender, EventArgs e)
        {
            String text = plainText.Text;
            String key = encryptkey.Text;

            if (text.Equals("") || key.Equals(""))
            {
                MessageBox.Show("No input entered! Please enter a valid input and try again! ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            text = text.Replace(" ", String.Empty);
            key = key.Replace(" ", String.Empty);

            Regex regex = new Regex("[-+]?\\d*\\.?\\d+");
            Match match = regex.Match(key);
            if (match.Success)
                key = "" + alpha[Int32.Parse(key)];

            if (encryptbutton.Text.Equals("ENCRYPT"))
            {
                try
                {
                    String enc = AutoEncryption(text, key);
                    String plaintext = "Plaintext : " + text + "   ";
                    String encrypted = "Encrypted : " + enc + "   ";
                    resultLabel.Text = "Result : " + plaintext + encrypted;
                    MessageBox.Show("Encrypted Successfully!", "Successful");
                }
                catch(Exception e1)
                {
                    MessageBox.Show("Unknown Error! Contact Developer");
                    return;
                }
            }
            else
            {
                try
                {
                    String decrypted = "Decrypted : " + AutoDecryption(text, key) + "   ";
                    resultLabel.Text = "Result : " + "Cipher Text : " + text + "  " + decrypted;
                    MessageBox.Show("Decrypted Successfully!", "Successful");
                }
                catch(Exception e2)
                {
                    MessageBox.Show("Unknown Error! Contact Developer");
                    return;
                }
            }
            plainText.Text = "";
            encryptkey.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void plaintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void encryptkey_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void encryptkeylabel_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plainText.Text = "";
            encryptkey.Text = "";
            resultLabel.Text = "Result : ";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plaintextlabel.Text = "Plain Text : ";
            encryptkeylabel.Text = "Encryption Key : ";
            encryptbutton.Text = "ENCRYPT";
            plainText.Text = "";
            encryptkey.Text = "";
            resultLabel.Text = "Result : ";
        }

        private void decryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plaintextlabel.Text = "Cipher Text : ";
            encryptkeylabel.Text = "Decryption Key : ";
            encryptbutton.Text = "DECRYPT";
            plainText.Text = "";
            encryptkey.Text = "";
            resultLabel.Text = "Result : ";
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Yatish! Unlawful, Unauthorized use or Cloning of the software is strictly prohibited. " +
                "By using this software, you agree to the above terms & conditions. \n" +
                "If you find any bugs, please report us back at retailmode605@gmail.com","Developer Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
