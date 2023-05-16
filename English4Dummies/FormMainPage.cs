using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English4Dummies {
    public partial class FormMainPage : Form {
        public FormMainPage() {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            LoginForm lf = new LoginForm();
            lf.Show();
            Visible = false;
        }

        private void igeidőkToolStripMenuItem_Click(object sender, EventArgs e) {
            FormMaterials fm = new FormMaterials();
            fm.Show();
            Visible = false;

        }

        private void egyébToolStripMenuItem_Click(object sender, EventArgs e) {
            string msg = "Itt lesz a többi tananyag, nyelvtan, illetve szókincs.\nTürelmedet kérem, hamarosan érkezik! :)";
            MessageBox.Show(msg);
        }

        private void igeidőkToolStripMenuItem1_Click(object sender, EventArgs e) {
            FormPractice fpra = new FormPractice();
            fpra.Show();
            Visible = false;
        }

        private void egyébToolStripMenuItem1_Click(object sender, EventArgs e) {
            string msg = "Itt lesz a többi tananyag gyakorlása, nyelvtan, illetve szókincs.\nTürelmedet kérem, hamarosan érkezik! :)";
            MessageBox.Show(msg);
        }

        private void igeidőkToolStripMenuItem2_Click(object sender, EventArgs e) {
            FormTests ft = new FormTests();
            ft.Show();
            Visible = false;
        }

        private void egyébToolStripMenuItem2_Click(object sender, EventArgs e) {
            string msg = "Itt lesz a többi tananyag tesztelése, nyelvtan, illetve szókincs.\nTürelmedet kérem, hamarosan érkezik! :)";
            MessageBox.Show(msg);
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e) {
            FormProfile fpro = new FormProfile();
            fpro.Show();
            Visible = false;
        }
    }
}
