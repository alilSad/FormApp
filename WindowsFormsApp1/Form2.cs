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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public void passConfirm() {

            string[] lines = File.ReadAllLines("login.txt");

            foreach (string set in lines) {
                string[] splits = set.Split(',');

                if (splits[0] == userField.Text) {
                    MessageBox.Show("Username already taken", "Error", MessageBoxButtons.OK);
                
                }
            
            }

            if (passField.Text != confirmPass.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK);

            }
            else if (userField.Text == "" || passField.Text == "" || confirmPass.Text == "" || firstName.Text == "" || lastName.Text == "" || userType.Text == "")
            {

                MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK);
            }
            else {

                submit();
            
            }
        
        }


        public void submit() {

            

            using (FileStream fs = new FileStream("login.txt", FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs)) {

                
                sw.WriteLine(userField.Text + "," + passField.Text + "," + userType.Text + "," + firstName.Text + "," + lastName.Text + "," + dob.Text);

            
            }


            MessageBox.Show("New user created, you can now log in", "Success", MessageBoxButtons.OK);
            Form form1 = new Form1();
            form1.Show();
            this.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            passConfirm();
        }

        private void userField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
