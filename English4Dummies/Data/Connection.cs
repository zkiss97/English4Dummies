using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace English4Dummies {
    internal class Connection {
        public static MySqlConnection connMaster = new MySqlConnection();

        static string server = "127.0.0.1";
        static string database = "englishfordummies3";
        static string id = "root";
        static string password = "";

        public static MySqlConnection dataSource() {
            connMaster = new MySqlConnection($"server={server} database={database} id={id} password{password}");
            return connMaster;
        }

        public void connOpen() {
            dataSource();
            connMaster.Open();
        }

        public void connClose() {
            dataSource();
            connMaster.Close();
        }
    }
}
