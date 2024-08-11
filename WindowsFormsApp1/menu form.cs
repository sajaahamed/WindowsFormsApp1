using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class menu_form : Form
    {
        bool slide;
        public menu_form()
        {
            InitializeComponent();
        }
         
        private void menu_form_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slidebartimer1(object sender, EventArgs e)
        {

        }

        private void slidebartimer(object sender, EventArgs e)
        {
           
        }

        private void guna2Button_Click(object sender, EventArgs e)
        {

        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if(slide)
            {
                fp_slidebar.Width -= 200;
                if (fp_slidebar.Width == fp_slidebar.MinimumSize.Width)
                {
                    slide= false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                fp_slidebar.Width += 200;
                if (fp_slidebar.Width == fp_slidebar.MaximumSize.Width)
                {
                    slide = true;
                    SidebarTimer.Stop();
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.Show();
            this.Close();

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            takeawaycs takeawaycs = new takeawaycs();
            takeawaycs.Show();
            this.Hide();

        }
    }
}
