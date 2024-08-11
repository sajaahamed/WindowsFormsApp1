using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class dbms
    {
        public MySqlConnection ConnectDb()
        {
            string cs = @"server=127.0.0.1;userid=root;password=Saja1234##;database=user_login";
            MySqlConnection conn = new MySqlConnection(cs);
            return conn;
        }
    }
}
