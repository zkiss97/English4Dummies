namespace English4Dummies {
    partial class FormProfile {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.főoldalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tananyagokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyakorlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesztekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(706, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(82, 23);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Kijelentkezés";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üdvözöllek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Itt található a felhasználó profilja, neve, adatai, \nilletve a teszteken elért le" +
    "gjobb és legrosszabb eredményei\nWork in progress";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.főoldalToolStripMenuItem,
            this.tananyagokToolStripMenuItem,
            this.gyakorlásToolStripMenuItem,
            this.tesztekToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // főoldalToolStripMenuItem
            // 
            this.főoldalToolStripMenuItem.Name = "főoldalToolStripMenuItem";
            this.főoldalToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.főoldalToolStripMenuItem.Text = "Főoldal";
            // 
            // tananyagokToolStripMenuItem
            // 
            this.tananyagokToolStripMenuItem.Name = "tananyagokToolStripMenuItem";
            this.tananyagokToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.tananyagokToolStripMenuItem.Text = "Tananyagok";
            // 
            // gyakorlásToolStripMenuItem
            // 
            this.gyakorlásToolStripMenuItem.Name = "gyakorlásToolStripMenuItem";
            this.gyakorlásToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gyakorlásToolStripMenuItem.Text = "Gyakorlás";
            // 
            // tesztekToolStripMenuItem
            // 
            this.tesztekToolStripMenuItem.Name = "tesztekToolStripMenuItem";
            this.tesztekToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tesztekToolStripMenuItem.Text = "Tesztek";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Location = new System.Drawing.Point(0, 45);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(200, 345);
            this.groupBoxMenu.TabIndex = 6;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menü";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProfile";
            this.Text = "E4D - Profil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem főoldalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tananyagokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyakorlásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesztekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxMenu;
    }
}