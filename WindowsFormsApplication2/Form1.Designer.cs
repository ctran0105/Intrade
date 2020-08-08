namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnectDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnectDB
            // 
            this.buttonConnectDB.Location = new System.Drawing.Point(49, 159);
            this.buttonConnectDB.Name = "buttonConnectDB";
            this.buttonConnectDB.Size = new System.Drawing.Size(285, 58);
            this.buttonConnectDB.TabIndex = 0;
            this.buttonConnectDB.Text = "Load data to Database";
            this.buttonConnectDB.UseVisualStyleBackColor = true;
            this.buttonConnectDB.Click += new System.EventHandler(this.buttonConnectDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "waiting....";
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(49, 40);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(285, 55);
            this.buttonChooseFile.TabIndex = 2;
            this.buttonChooseFile.Text = "Choose your .CSV file";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 569);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnectDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnectDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChooseFile;
    }
}

