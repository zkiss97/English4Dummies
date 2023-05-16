using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace English4Dummies {
    internal class DBConnect {

        string connectionString = null;
        public static MySqlConnection connMaster = new MySqlConnection();
        MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();

        public static string server="localhost";
        public static string port = "3306";
        public static string database="efordusers";
        public static string id="root";
        public static string password="";


        public static MySqlConnection dataSource() {
            connMaster = new MySqlConnection($"server={server}database={database}port={port}id={id}password{password}");
            return connMaster;
        }



        public void connOpen() {
            if (connMaster.State == System.Data.ConnectionState.Closed) {
                connMaster.Open();
            }
        }

        public void connClose() {
            if (connMaster.State == System.Data.ConnectionState.Open) {
                connMaster.Close();
            }
        }
    }
}
