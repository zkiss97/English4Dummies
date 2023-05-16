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
    public partial class LoginForm : Form {


        public LoginForm() {
            InitializeComponent();
            labelDBCSuccess.Visible = false;
            labelDBCError.Visible = false;
        }

        Connection con = new Connection();

        private void buttonDBCheck_Click(object sender, EventArgs e) {

            try {
                Connection.dataSource();
                con.connOpen();
                labelDBCSuccess.Visible = true;
                labelDBCError.Visible = false;
                con.connClose();
            } 
            catch(Exception ex) {
                string msg;
                labelDBCError.Visible = true;
                labelDBCSuccess.Visible= false;
                msg = ex.Message;
                MessageBox.Show(msg);
            
            }
        }

        private void buttonToRegister_Click(object sender, EventArgs e) {
            RegisterForm rf = new RegisterForm();
            rf.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {

            DBConnect DB = new DBConnect();

            string username = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login and `password` = @password");

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0) {
                MessageBox.Show("YEEES");
            }
            else {
                MessageBox.Show("NOOOO");
            }
            

        }

        private void textBoxLogin_Enter(object sender, EventArgs e) {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxShowPassword.Checked) {
                textBoxPassword.UseSystemPasswordChar = false;
            } 
            else textBoxPassword.UseSystemPasswordChar = true;
            
        }

        private void buttonSkip_Click(object sender, EventArgs e) {
            FormMainPage fmp = new FormMainPage();
            fmp.Show();
            Visible = false;
        }
    }
}
