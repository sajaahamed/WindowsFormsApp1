using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            

           
        }
        
        private void guna2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if(guna2TextBox1.Text == null) 
                {
                    Errors e1 = new Errors();
                    e1.error_msg = "password cannot be empty!";
                    e1.error();
                }

                if (guna2TextBox2.Text == null)
                {
                    Errors e1 = new Errors();
                    e1.error_msg = "user name cannot be empty!";
                    e1.error();
                }

                string password = guna2TextBox1.Text;
                string name = guna2TextBox2.Text;
                if (name == "0000" && password == "0000")
                {
                    menu_form form = new menu_form();
                    form.Show();
                    this.Hide();


                }
                else
                {
                    Errors e2 = new Errors();
                    e2.error_msg = "login fail!";
                    e2.error();

                }
            }
            catch (Exception) {
                
                MessageBox.Show("Somthing Went Wrong!\n Please Contact Developer");
            }
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
