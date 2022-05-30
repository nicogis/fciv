using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Studioat.Utility
{
    public partial class frmMain : Form
    {
        
        private IEnumerable<TextBox> textboxes = null;
        private IEnumerable<TextBox> textboxesVerify = null;
        private readonly string[] hashType = Enum.GetNames(typeof(HashType));
        public frmMain()
        {
            InitializeComponent();
            
            textboxes = this.Controls["gbFile"].Controls.OfType<TextBox>();
            textboxesVerify = this.Controls["gbVerify"].Controls.OfType<TextBox>();
        }

        private void btnBrowserFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "All files|*.*";
                openFileDialog1.Title = "Select a file";
                openFileDialog1.Multiselect = false;
                openFileDialog1.CheckFileExists = true;


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = openFileDialog1.FileName;
                }

                
                TextBox c = null;
                TextBox cVerify = null;
                foreach (string s in hashType)
                {
                    c = textboxes.Single(t => t.Name == $"txt{s}");
                    c.Clear();
                    cVerify = textboxesVerify.Single(t => t.Name == $"txt{s}Verify");
                    cVerify.Clear();
                    cVerify.BackColor = Color.White;
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int counter = 0;
            TextBox c = null;
            TextBox cVerify = null;

            foreach (string s in hashType)
            {
                cVerify = textboxesVerify.Single(t => t.Name == $"txt{s}Verify");
                cVerify.BackColor = Color.White;
                if (!string.IsNullOrWhiteSpace(cVerify.Text))
                { 
                   counter++;
                }

            }
                        
            if (counter != 1)
            {
                MessageBox.Show("Set a verify!");
                return;
            }


            if (string.IsNullOrEmpty(txtFile.Text))
            {
                MessageBox.Show("Select a file!");
                btnBrowserFile.Focus();
                return;
            }


           

            using (FileStream file = new FileStream(txtFile.Text, FileMode.Open))
            {
                byte[] retVal;
                foreach (string s in hashType)
                {
                    c = textboxes.Single(t => t.Name == $"txt{s}");
                    cVerify = textboxesVerify.Single(t => t.Name == $"txt{s}Verify");
                    if (!string.IsNullOrEmpty(cVerify.Text))
                    {
                        file.Position = 0;
                        using (HashAlgorithm h = Helper.Hashes((HashType)Enum.Parse(typeof(HashType), s)))
                        {
                            retVal = h.ComputeHash(file);
                            c.Text = BitConverter.ToString(retVal).Replace("-", ""); // hex string
                        }
                    }
                }
            }

                      
            foreach (string s in hashType)
            {
                cVerify = textboxesVerify.Single(t => t.Name == $"txt{s}Verify");
                c = textboxes.Single(t => t.Name == $"txt{s}");

                if (!string.IsNullOrEmpty(cVerify.Text))
                {
                    cVerify.BackColor = (string.Compare(c.Text, cVerify.Text.Trim(), true) == 0) ? Color.Green : Color.Red;
                    break; //because only a check 
                }
            }
        }
    }
}
