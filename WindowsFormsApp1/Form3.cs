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


       

        private void saveAs() {

            

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            

            saveFileDialog.CreatePrompt = false;
            saveFileDialog.OverwritePrompt = true;

            saveFileDialog.FileName = "Untitled";

            saveFileDialog.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";

            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DialogResult result = saveFileDialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex) {

                    case 1:
                        StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                        sw.WriteLine(richTextBox1.Text);
                        sw.Close();
                        break;

                    case 2:
                        StreamWriter sw2 = new StreamWriter(saveFileDialog.FileName);
                        sw2.WriteLine(richTextBox1.Rtf);
                        sw2.Close();
                        break;         
                
                }
               
            }
    
        }


        public void cut() {
            richTextBox1.Cut();
        }

        public void copy() {

            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
        }

        public void paste() {

            if (Clipboard.ContainsText(TextDataFormat.Rtf)) {
                richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
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
            
            if (fontsizeTS.Text != "")
            {
                FontSize();

            }
           
        }

        public void FontSize()
        {
            Object selection = fontsizeTS.SelectedItem;
            string Select = selection.ToString();

            
                

               
                    Font new1, old1;
                    old1 = richTextBox1.SelectionFont;
                    new1 = new Font(FontFamily.GenericSansSerif, float.Parse(Select.Trim()), old1.Style);
                    richTextBox1.SelectionFont = new1;

                    richTextBox1.Focus();

                



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

        private void saveTS2_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAsTS2_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAsTS_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveTS_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void editToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void aboutTS_Click(object sender, EventArgs e)
        {
            Form form = new Form4();
            form.Show();
        }

        private void boldTS_Click(object sender, EventArgs e)
        {
            Font new1, old1;

            old1 = richTextBox1.SelectionFont;
            if (old1.Bold)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            }
            else 
            {
                new1 = new Font(old1, old1.Style | FontStyle.Bold);

            }
            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
    
        }

        private void italicTS_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Italic)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);

            }
            else
            {
                new1 = new Font(old1, old1.Style | FontStyle.Italic);
            }
            richTextBox1.SelectionFont = new1;

            richTextBox1.Focus();
        }

        private void underlineTS_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Underline)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            }
            else
            {
                new1 = new Font(old1, old1.Style | FontStyle.Underline);
            }
            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void cutTS_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void copyTS2_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void copyTS_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void pasteTS2_Click(object sender, EventArgs e)
        {
            paste();
        }

        private void pasteTS_Click(object sender, EventArgs e)
        {
            paste();
        }
    }
}
