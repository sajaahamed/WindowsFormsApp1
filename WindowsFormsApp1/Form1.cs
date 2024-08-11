using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            MySqlConnection conn = new dbms().ConnectDb();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from login where user_name='" + txtuser_name.Text + "' AND password='" + txtpassword.Text + "'",conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                menu_form menu_Form = new menu_form();
                menu_Form.Show();
                this.Hide();
            }
            else
            {
                messge_box messge= new messge_box();
                messge.Show();
                return;
            }
            reader.Close();
            conn.Close();
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
