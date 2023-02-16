namespace TietovisaForms
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
            this.ConnectDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectDb
            // 
            this.ConnectDb.Location = new System.Drawing.Point(162, 106);
            this.ConnectDb.Name = "ConnectDb";
            this.ConnectDb.Size = new System.Drawing.Size(141, 31);
            this.ConnectDb.TabIndex = 0;
            this.ConnectDb.Text = "Aloita peli";
            this.ConnectDb.UseVisualStyleBackColor = true;
            this.ConnectDb.Click += new System.EventHandler(this.ConnectDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 149);
            this.Controls.Add(this.ConnectDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tervetuloa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectDb;
    }
}

