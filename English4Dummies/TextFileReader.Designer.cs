namespace English4Dummies {
    partial class TextFileReader {
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
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxAll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(350, 352);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textBoxAll
            // 
            this.textBoxAll.Location = new System.Drawing.Point(154, 75);
            this.textBoxAll.Multiline = true;
            this.textBoxAll.Name = "textBoxAll";
            this.textBoxAll.Size = new System.Drawing.Size(500, 200);
            this.textBoxAll.TabIndex = 3;
            // 
            // DataReaderProba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAll);
            this.Controls.Add(this.buttonRead);
            this.Name = "DataReaderProba";
            this.Text = "DataReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBoxAll;
    }
}