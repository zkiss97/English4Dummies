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
    public partial class RegisterForm : Form {
        public RegisterForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void buttonToLogin_Click(object sender, EventArgs e) {
            LoginForm lf = new LoginForm();
            lf.Show();
            Visible = false;
        }


        private void textBoxLogin_Enter(object sender, EventArgs e) {
            string loginname = textBoxLogin.Text;

        }




        private void buttonRegister_Click(object sender, EventArgs e) {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxShowPassword.Checked) {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassAgain.UseSystemPasswordChar = false;
            } else {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassAgain.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassAgain_Validating(object sender, CancelEventArgs e) {
            string message = "Incorrect password!";
            if (textBoxPassword.Text.Equals(textBoxPassAgain.Text) == false) {
                MessageBox.Show(message);
            }
        }
    }
}
