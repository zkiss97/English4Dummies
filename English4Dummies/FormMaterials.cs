using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English4Dummies {
    public partial class FormMaterials : Form {
        public FormMaterials() {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            LoginForm lf = new LoginForm();
            lf.Show();
            Visible = false;
        }

        private void főoldalToolStripMenuItem_Click(object sender, EventArgs e) {
            FormMainPage fmp = new FormMainPage();
            fmp.Show();
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

        string path = "verbtenses.txt";
        string line = null; //a szöveg egy sora
        string[] tenses = new string[] { }; //az igeidőket tartalmazó tömb
        

        
        

        private void FormMaterials_Load(object sender, EventArgs e) {
            comboBoxTenses.Items.Add("Present Simple");
            comboBoxTenses.Items.Add("Present Continuous");
            comboBoxTenses.Items.Add("Present Perfect");
            comboBoxTenses.Items.Add("Present Perfect Continuous");
            comboBoxTenses.Items.Add("Past Simple");
            comboBoxTenses.Items.Add("Past Continuous");
            comboBoxTenses.Items.Add("Past Perfect");
            comboBoxTenses.Items.Add("Past Perfect Continuous");
            comboBoxTenses.Items.Add("Future Simple");
            comboBoxTenses.Items.Add("Future Continuous");
            comboBoxTenses.Items.Add("Future Perfect");
            comboBoxTenses.Items.Add("Future Perfect Continuous");
        }

        private void comboBoxTenses_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                string[] lines = File.ReadAllLines(@"D:\C#\English4Dummies\English4Dummies\verbtenses.txt");

                string[][] parts = new string[lines.Length][];
                for (int i = 0; i < parts.Length; i++) {
                    parts[i] = lines[i].Split(';');
                }
                string selectedItem = comboBoxTenses.SelectedItem.ToString();

                string secondPart = "";
                string thirdPart = "";
                string fourthPart = "";

                for (int i = 0; i < parts.Length; i++) { 
                    if (parts[i][0] == selectedItem) {
                        secondPart = parts[i][1];
                        thirdPart = parts[i][2];
                        fourthPart = parts[i][3];
                        break;
                    }
                }
                labelContent1.Text = secondPart;
                labelContent2.Text = thirdPart;
                labelContent3.Text = fourthPart;
            }
            catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            
            
        }
    }
}
