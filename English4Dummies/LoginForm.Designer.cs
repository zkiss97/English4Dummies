namespace English4Dummies {
    partial class LoginForm {
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonToRegister = new System.Windows.Forms.Button();
            this.labelNoAcc = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonDBCheck = new System.Windows.Forms.Button();
            this.labelDBCSuccess = new System.Windows.Forms.Label();
            this.labelDBCError = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(76, 142);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(81, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(196, 139);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(145, 20);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(196, 198);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(145, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(145, 276);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(99, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Bejelentkezés";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(74, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(263, 29);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "English For Dummies";
            // 
            // buttonToRegister
            // 
            this.buttonToRegister.Location = new System.Drawing.Point(159, 366);
            this.buttonToRegister.Name = "buttonToRegister";
            this.buttonToRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonToRegister.TabIndex = 6;
            this.buttonToRegister.Text = "Regisztrálj";
            this.buttonToRegister.UseVisualStyleBackColor = true;
            this.buttonToRegister.Click += new System.EventHandler(this.buttonToRegister_Click);
            // 
            // labelNoAcc
            // 
            this.labelNoAcc.AutoSize = true;
            this.labelNoAcc.Location = new System.Drawing.Point(162, 326);
            this.labelNoAcc.Name = "labelNoAcc";
            this.labelNoAcc.Size = new System.Drawing.Size(72, 13);
            this.labelNoAcc.TabIndex = 7;
            this.labelNoAcc.Text = "Nincs fiókod?";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(196, 224);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(124, 17);
            this.checkBoxShowPassword.TabIndex = 8;
            this.checkBoxShowPassword.Text = "Jelszó megjelenítése";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // buttonDBCheck
            // 
            this.buttonDBCheck.Location = new System.Drawing.Point(295, 441);
            this.buttonDBCheck.Name = "buttonDBCheck";
            this.buttonDBCheck.Size = new System.Drawing.Size(108, 23);
            this.buttonDBCheck.TabIndex = 9;
            this.buttonDBCheck.Text = "DB Conn Check";
            this.buttonDBCheck.UseVisualStyleBackColor = true;
            this.buttonDBCheck.Click += new System.EventHandler(this.buttonDBCheck_Click);
            // 
            // labelDBCSuccess
            // 
            this.labelDBCSuccess.AutoSize = true;
            this.labelDBCSuccess.Location = new System.Drawing.Point(292, 476);
            this.labelDBCSuccess.Name = "labelDBCSuccess";
            this.labelDBCSuccess.Size = new System.Drawing.Size(48, 13);
            this.labelDBCSuccess.TabIndex = 10;
            this.labelDBCSuccess.Text = "Success";
            // 
            // labelDBCError
            // 
            this.labelDBCError.AutoSize = true;
            this.labelDBCError.Location = new System.Drawing.Point(368, 476);
            this.labelDBCError.Name = "labelDBCError";
            this.labelDBCError.Size = new System.Drawing.Size(29, 13);
            this.labelDBCError.TabIndex = 11;
            this.labelDBCError.Text = "Error";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 463);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Bezárás";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Location = new System.Drawing.Point(282, 276);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(75, 23);
            this.buttonSkip.TabIndex = 14;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 498);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelDBCError);
            this.Controls.Add(this.labelDBCSuccess);
            this.Controls.Add(this.buttonDBCheck);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.labelNoAcc);
            this.Controls.Add(this.buttonToRegister);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLogin);
            this.Name = "LoginForm";
            this.Text = "E4D - Bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonToRegister;
        private System.Windows.Forms.Label labelNoAcc;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonDBCheck;
        private System.Windows.Forms.Label labelDBCSuccess;
        private System.Windows.Forms.Label labelDBCError;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSkip;
    }
}

