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
    public partial class Form1 : Form
    {

        public static Boolean correctDeet = false;
        public string username;
        public string password;


        public void login() {

            
            string[] lines = File.ReadAllLines("login.txt");

            foreach (string set in lines) {
                string[] splits = set.Split(',');

                if (splits[0] == userField.Text && splits[1] == passField.Text) {
                    correctDeet = true;
                    
                }
             
            }

            if (correctDeet)
            {
                Form form3 = new Form3();
                form3.Show();
                this.Hide();

                username = userField.Text;
                password = passField.Text;

                


            }
            else {
                MessageBox.Show("Incorrect username or password, please try again", "Invalid Credentials", MessageBoxButtons.OK);
            
            
            }

        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void userField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();

            
        }
    }
}
