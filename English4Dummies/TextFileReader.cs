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
    public partial class TextFileReader : Form {
        public TextFileReader() {
            InitializeComponent();
        }

        public string textFileMaterials = @"D:\C#\English4Dummies\English4Dummies\verbtenses.txt";
        public string textFileUsers = @"D:\C#\English4Dummies\English4Dummies\users.txt";

        private void buttonRead_Click(object sender, EventArgs e) {
            if (File.Exists(textFileUsers)) { 
                string textContent = File.ReadAllText(textFileUsers);

                textBoxAll.Text = textContent;
                //textBoxAll.Focus();
            }
        }
    }
}