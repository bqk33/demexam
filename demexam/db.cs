using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace demexam
{
    internal class DB
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;uid=root;" +
                "database=dbexam");

        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
        public MySqlConnection getConnect()
        {
            return connect;
        }

    }
}
