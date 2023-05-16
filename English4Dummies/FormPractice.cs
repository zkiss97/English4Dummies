using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace English4Dummies {
    public partial class FormPractice : Form {
        public FormPractice() {
            InitializeComponent();
        }

        //string textTenses = @"verbtenses.txt";

        private void főoldalToolStripMenuItem_Click(object sender, EventArgs e) {
            FormMainPage fmp = new FormMainPage();
            fmp.Show();
            Visible = false;
        }

        private void igeidőkToolStripMenuItem_Click(object sender, EventArgs e) {
            FormMaterials fm = new FormMaterials();
            fm.Show();
            Visible = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            LoginForm lf = new LoginForm();
            lf.Show();
            Visible = false;
        }

        private void egyébToolStripMenuItem_Click(object sender, EventArgs e) {
            string msg = "Itt lesz a többi tananyag, nyelvtan, illetve szókincs.\nTürelmedet kérem, hamarosan érkezik! :)\nMajd a vizsga UTÁN!";
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

        private void FormPractice_Load(object sender, EventArgs e) {

            //comboBoxVerbTenses.Items.Add();
        }

        private void buttonToRead_Click(object sender, EventArgs e) {
            TextFileReader drp = new TextFileReader();
            drp.Show();
            Visible=false;
        }
    }
}
