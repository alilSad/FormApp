using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        public void typeCheck() {

            string user = Form1.userType;

            if (user == "View")
            {
                richTextBox1.ReadOnly = true;
                newTS2.Enabled = false;
                newTS.Enabled = false;
            }

            else if (user == "Edit")
            {
                richTextBox1.ReadOnly = false;
                newTS2.Enabled = true;
                newTS.Enabled = true;
            }


        }

        public void newText() {

            var result = MessageBox.Show("Are you sure? This will clear your current file.", "Create new file", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                richTextBox1.Clear();
            }
            
        }


        public void open() {
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";

            try
            {

                if (openFile1.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(openFile1.FileName) == ".rtf")
                    {
                        richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);

                    }

                    if (Path.GetExtension(openFile1.FileName) == ".txt")
                    {
                        richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);

                    }

                }

            }

            catch (Exception e) {
                MessageBox.Show("Failed to open file", "Error" + e.Message, MessageBoxButtons.OK);
            
            }

        }

        public Form3()
        {
            InitializeComponent();
            
        }

        private void newTS_Click(object sender, EventArgs e)
        {
            newText();
        }

        private void fontsizeTS_Click(object sender, EventArgs e)
        {

        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = "Username: " + Form1.username;
            typeCheck();
        }

        private void aboutTS2_Click(object sender, EventArgs e)
        {
            Form form = new Form4();
            form.Show();
        }

        private void logOutTS_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
           

            form.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newTS2_Click(object sender, EventArgs e)
        {
            newText();
        }

        private void openTS_Click(object sender, EventArgs e)
        {
            open();
        }

        private void openTS2_Click(object sender, EventArgs e)
        {
            open();
        }
    }
}
