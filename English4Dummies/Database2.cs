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
    public partial class Database2 : Form {
        public Database2() {
            InitializeComponent();
        }

        MySqlConnection connection = null;
        MySqlCommand sql = null;

        private void buttonInsert_Click(object sender, EventArgs e) {
            Feltolt();
        }


        private void Feltolt() {

            string queryName = textBoxName.Text;
            string queryStructure = textBoxStructure.Text;
            string queryWhenTo = textBoxWhenTo.Text;
            string queryExample = textBoxExample.Text;
            

            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=englishfordummies2";

            MySqlConnection con = new MySqlConnection(MySQLConnectionString);

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = con;

            sql.CommandText = "INSERT INTO `verbtenses`(`name`, `structure`, `whenToUse`, `examples`) VALUES(@name, @structure, @whenToUse, @examples)";

            connection.Close();

        }
    }
}
