using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SIS
{
    class ConnectDB
    {
        public string context()
        {
            FileInfo DirInfo = new FileInfo("conf.txt");
            string text = "";
            if (DirInfo.Exists)
            {
                //MySqlConnection conn = new MySqlConnection();
                text = File.ReadAllText(@"conf.txt");
                //conn = new MySqlConnection(context);
            }
            return text;
        }
    }
}
