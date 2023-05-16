namespace English4Dummies {
    partial class FormMainPage {
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
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.főoldalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tananyagokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igeidőkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyakorlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesztekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egyébToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igeidőkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.egyébToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.igeidőkToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.egyébToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
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
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(279, 113);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Üdvözöllek";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(279, 168);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(424, 52);
            this.labelContent.TabIndex = 1;
            this.labelContent.Text = "Itt megtanulhatsz angolul.\nElső sorban nyelvtan, de a későbbiekben szókincs gyara" +
    "pító gyakorlatok is kerülnek be.\nKezdjünk is neki!\nWork in progress!";
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
            this.tananyagokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igeidőkToolStripMenuItem,
            this.egyébToolStripMenuItem});
            this.tananyagokToolStripMenuItem.Name = "tananyagokToolStripMenuItem";
            this.tananyagokToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.tananyagokToolStripMenuItem.Text = "Tananyagok";
            // 
            // igeidőkToolStripMenuItem
            // 
            this.igeidőkToolStripMenuItem.Name = "igeidőkToolStripMenuItem";
            this.igeidőkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.igeidőkToolStripMenuItem.Text = "Igeidők";
            this.igeidőkToolStripMenuItem.Click += new System.EventHandler(this.igeidőkToolStripMenuItem_Click);
            // 
            // gyakorlásToolStripMenuItem
            // 
            this.gyakorlásToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igeidőkToolStripMenuItem1,
            this.egyébToolStripMenuItem1});
            this.gyakorlásToolStripMenuItem.Name = "gyakorlásToolStripMenuItem";
            this.gyakorlásToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gyakorlásToolStripMenuItem.Text = "Gyakorlás";
            // 
            // tesztekToolStripMenuItem
            // 
            this.tesztekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igeidőkToolStripMenuItem2,
            this.egyébToolStripMenuItem2});
            this.tesztekToolStripMenuItem.Name = "tesztekToolStripMenuItem";
            this.tesztekToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tesztekToolStripMenuItem.Text = "Tesztek";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // egyébToolStripMenuItem
            // 
            this.egyébToolStripMenuItem.Name = "egyébToolStripMenuItem";
            this.egyébToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.egyébToolStripMenuItem.Text = "Egyéb";
            this.egyébToolStripMenuItem.Click += new System.EventHandler(this.egyébToolStripMenuItem_Click);
            // 
            // igeidőkToolStripMenuItem1
            // 
            this.igeidőkToolStripMenuItem1.Name = "igeidőkToolStripMenuItem1";
            this.igeidőkToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.igeidőkToolStripMenuItem1.Text = "Igeidők";
            this.igeidőkToolStripMenuItem1.Click += new System.EventHandler(this.igeidőkToolStripMenuItem1_Click);
            // 
            // egyébToolStripMenuItem1
            // 
            this.egyébToolStripMenuItem1.Name = "egyébToolStripMenuItem1";
            this.egyébToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.egyébToolStripMenuItem1.Text = "Egyéb";
            this.egyébToolStripMenuItem1.Click += new System.EventHandler(this.egyébToolStripMenuItem1_Click);
            // 
            // igeidőkToolStripMenuItem2
            // 
            this.igeidőkToolStripMenuItem2.Name = "igeidőkToolStripMenuItem2";
            this.igeidőkToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.igeidőkToolStripMenuItem2.Text = "Igeidők";
            this.igeidőkToolStripMenuItem2.Click += new System.EventHandler(this.igeidőkToolStripMenuItem2_Click);
            // 
            // egyébToolStripMenuItem2
            // 
            this.egyébToolStripMenuItem2.Name = "egyébToolStripMenuItem2";
            this.egyébToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.egyébToolStripMenuItem2.Text = "Egyéb";
            this.egyébToolStripMenuItem2.Click += new System.EventHandler(this.egyébToolStripMenuItem2_Click);
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainPage";
            this.Text = "E4D - Főoldal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem főoldalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tananyagokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyakorlásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesztekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igeidőkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egyébToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igeidőkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem egyébToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem igeidőkToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem egyébToolStripMenuItem2;
    }
}