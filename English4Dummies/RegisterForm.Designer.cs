namespace English4Dummies {
    partial class RegisterForm {
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
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.labelYesAcc = new System.Windows.Forms.Label();
            this.buttonToLogin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassAgain = new System.Windows.Forms.TextBox();
            this.labelPassAgain = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(195, 225);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(124, 17);
            this.checkBoxShowPassword.TabIndex = 17;
            this.checkBoxShowPassword.Text = "Jelszó megjelenítése";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // labelYesAcc
            // 
            this.labelYesAcc.AutoSize = true;
            this.labelYesAcc.Location = new System.Drawing.Point(161, 348);
            this.labelYesAcc.Name = "labelYesAcc";
            this.labelYesAcc.Size = new System.Drawing.Size(64, 13);
            this.labelYesAcc.TabIndex = 16;
            this.labelYesAcc.Text = "Van fiókod?";
            // 
            // buttonToLogin
            // 
            this.buttonToLogin.Location = new System.Drawing.Point(137, 388);
            this.buttonToLogin.Name = "buttonToLogin";
            this.buttonToLogin.Size = new System.Drawing.Size(107, 27);
            this.buttonToLogin.TabIndex = 15;
            this.buttonToLogin.Text = "Jelentkezz be";
            this.buttonToLogin.UseVisualStyleBackColor = true;
            this.buttonToLogin.Click += new System.EventHandler(this.buttonToLogin_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(73, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(263, 29);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "English For Dummies";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(144, 298);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(99, 27);
            this.buttonRegister.TabIndex = 13;
            this.buttonRegister.Text = "Regisztráció";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(195, 144);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(145, 20);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(195, 91);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(145, 20);
            this.textBoxLogin.TabIndex = 11;
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jelszó";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(75, 96);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(81, 13);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Felhasználónév";
            // 
            // textBoxPassAgain
            // 
            this.textBoxPassAgain.Location = new System.Drawing.Point(195, 199);
            this.textBoxPassAgain.Name = "textBoxPassAgain";
            this.textBoxPassAgain.Size = new System.Drawing.Size(145, 20);
            this.textBoxPassAgain.TabIndex = 19;
            this.textBoxPassAgain.UseSystemPasswordChar = true;
            this.textBoxPassAgain.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassAgain_Validating);
            // 
            // labelPassAgain
            // 
            this.labelPassAgain.AutoSize = true;
            this.labelPassAgain.Location = new System.Drawing.Point(93, 202);
            this.labelPassAgain.Name = "labelPassAgain";
            this.labelPassAgain.Size = new System.Drawing.Size(63, 13);
            this.labelPassAgain.TabIndex = 18;
            this.labelPassAgain.Text = "Jelszó ismét";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 463);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Bezárás";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 498);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxPassAgain);
            this.Controls.Add(this.labelPassAgain);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.labelYesAcc);
            this.Controls.Add(this.buttonToLogin);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLogin);
            this.Name = "RegisterForm";
            this.Text = "E4D - Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelYesAcc;
        private System.Windows.Forms.Button buttonToLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassAgain;
        private System.Windows.Forms.Label labelPassAgain;
        private System.Windows.Forms.Button buttonExit;
    }
}