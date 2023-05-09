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
            this.buttonMainPage = new System.Windows.Forms.Button();
            this.buttonMaterials = new System.Windows.Forms.Button();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.buttonTests = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMainPage
            // 
            this.buttonMainPage.Location = new System.Drawing.Point(301, 12);
            this.buttonMainPage.Name = "buttonMainPage";
            this.buttonMainPage.Size = new System.Drawing.Size(82, 23);
            this.buttonMainPage.TabIndex = 0;
            this.buttonMainPage.Text = "Főoldal";
            this.buttonMainPage.UseVisualStyleBackColor = true;
            // 
            // buttonMaterials
            // 
            this.buttonMaterials.Location = new System.Drawing.Point(382, 12);
            this.buttonMaterials.Name = "buttonMaterials";
            this.buttonMaterials.Size = new System.Drawing.Size(82, 23);
            this.buttonMaterials.TabIndex = 1;
            this.buttonMaterials.Text = "Tananyagok";
            this.buttonMaterials.UseVisualStyleBackColor = true;
            // 
            // buttonPractice
            // 
            this.buttonPractice.Location = new System.Drawing.Point(463, 12);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(82, 23);
            this.buttonPractice.TabIndex = 2;
            this.buttonPractice.Text = "Gyakorlás";
            this.buttonPractice.UseVisualStyleBackColor = true;
            // 
            // buttonTests
            // 
            this.buttonTests.Location = new System.Drawing.Point(544, 12);
            this.buttonTests.Name = "buttonTests";
            this.buttonTests.Size = new System.Drawing.Size(82, 23);
            this.buttonTests.TabIndex = 3;
            this.buttonTests.Text = "Tesztek";
            this.buttonTests.UseVisualStyleBackColor = true;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(625, 12);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(82, 23);
            this.buttonProfile.TabIndex = 4;
            this.buttonProfile.Text = "Profil";
            this.buttonProfile.UseVisualStyleBackColor = true;
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
            // groupBoxMenu
            // 
            this.groupBoxMenu.Location = new System.Drawing.Point(0, 45);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(200, 345);
            this.groupBoxMenu.TabIndex = 6;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menü";
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
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Itt található a felhasználó profilja, neve, adatai, \nilletve a teszteken elért legjobb és legrosszabb eredményei\nWork in progress";
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonTests);
            this.Controls.Add(this.buttonPractice);
            this.Controls.Add(this.buttonMaterials);
            this.Controls.Add(this.buttonMainPage);
            this.Name = "FormMainPage";
            this.Text = "E4D - Főoldal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonMainPage;
        private System.Windows.Forms.Button buttonMaterials;
        private System.Windows.Forms.Button buttonPractice;
        private System.Windows.Forms.Button buttonTests;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}