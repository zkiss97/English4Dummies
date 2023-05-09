using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace English4Dummies {
    public partial class FormLoginPage : Form {

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

        Connection con = new Connection();

        public FormLoginPage() {
            InitializeComponent();
            labelDBCSuccess.Visible = false;
            labelDBCError.Visible = false;
        }

        private void buttonDBCheck_Click(object sender, EventArgs e) {

            try {
                Connection.dataSource();
                con.connOpen();
                labelDBCSuccess.Visible = true;
                labelDBCError.Visible = false;
                con.connClose();
            } 
            catch(Exception) {
                labelDBCError.Visible = true;
                labelDBCSuccess.Visible= false;
                //string message = Exception.Message;
                //labelConnErrorMsg.Text = message;
            
            }
        }
    }
}
