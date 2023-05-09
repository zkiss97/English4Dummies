namespace English4Dummies {
    partial class Database2 {
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStructure = new System.Windows.Forms.Label();
            this.labelWhenTo = new System.Windows.Forms.Label();
            this.labelExample = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStructure = new System.Windows.Forms.TextBox();
            this.textBoxWhenTo = new System.Windows.Forms.TextBox();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(293, 323);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(149, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "name";
            // 
            // labelStructure
            // 
            this.labelStructure.AutoSize = true;
            this.labelStructure.Location = new System.Drawing.Point(149, 110);
            this.labelStructure.Name = "labelStructure";
            this.labelStructure.Size = new System.Drawing.Size(48, 13);
            this.labelStructure.TabIndex = 5;
            this.labelStructure.Text = "structure";
            // 
            // labelWhenTo
            // 
            this.labelWhenTo.AutoSize = true;
            this.labelWhenTo.Location = new System.Drawing.Point(149, 158);
            this.labelWhenTo.Name = "labelWhenTo";
            this.labelWhenTo.Size = new System.Drawing.Size(65, 13);
            this.labelWhenTo.TabIndex = 6;
            this.labelWhenTo.Text = "when to use";
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Location = new System.Drawing.Point(149, 210);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(46, 13);
            this.labelExample.TabIndex = 7;
            this.labelExample.Text = "example";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(328, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxStructure
            // 
            this.textBoxStructure.Location = new System.Drawing.Point(328, 103);
            this.textBoxStructure.Name = "textBoxStructure";
            this.textBoxStructure.Size = new System.Drawing.Size(100, 20);
            this.textBoxStructure.TabIndex = 9;
            // 
            // textBoxWhenTo
            // 
            this.textBoxWhenTo.Location = new System.Drawing.Point(328, 151);
            this.textBoxWhenTo.Name = "textBoxWhenTo";
            this.textBoxWhenTo.Size = new System.Drawing.Size(255, 20);
            this.textBoxWhenTo.TabIndex = 10;
            // 
            // textBoxExample
            // 
            this.textBoxExample.Location = new System.Drawing.Point(328, 203);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(255, 20);
            this.textBoxExample.TabIndex = 11;
            // 
            // Database2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxExample);
            this.Controls.Add(this.textBoxWhenTo);
            this.Controls.Add(this.textBoxStructure);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.labelWhenTo);
            this.Controls.Add(this.labelStructure);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonInsert);
            this.Name = "Database2";
            this.Text = "Database2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStructure;
        private System.Windows.Forms.Label labelWhenTo;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStructure;
        private System.Windows.Forms.TextBox textBoxWhenTo;
        private System.Windows.Forms.TextBox textBoxExample;
    }
}