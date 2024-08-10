using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Errors : messge_box
    {
        public string error_msg;

        public void error()
        {
            
            messge_box messge_Box = new messge_box();
            lbl_error.Text = error_msg.ToString();
            messge_Box.Show();
        }

    }
}
