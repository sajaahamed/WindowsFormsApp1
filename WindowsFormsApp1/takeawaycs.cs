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
    public partial class takeawaycs : Form
    {
        public takeawaycs()
        {
            InitializeComponent();
        }

        private void guna2Button_Click(object sender, EventArgs e)
        {
            menu_form menu_Form = new menu_form();
            menu_Form.Show();
            this.Hide();
        }
    }
}
