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
            this.uNoQdef = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uNoQdef)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectDb
            // 
            this.ConnectDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectDb.Location = new System.Drawing.Point(12, 65);
            this.ConnectDb.Name = "ConnectDb";
            this.ConnectDb.Size = new System.Drawing.Size(141, 24);
            this.ConnectDb.TabIndex = 0;
            this.ConnectDb.Text = "Aloita peli";
            this.ConnectDb.UseVisualStyleBackColor = true;
            this.ConnectDb.Click += new System.EventHandler(this.ConnectDb_Click);
            // 
            // uNoQdef
            // 
            this.uNoQdef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uNoQdef.Location = new System.Drawing.Point(12, 39);
            this.uNoQdef.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uNoQdef.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uNoQdef.Name = "uNoQdef";
            this.uNoQdef.Size = new System.Drawing.Size(141, 20);
            this.uNoQdef.TabIndex = 1;
            this.uNoQdef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uNoQdef.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 149);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.uNoQdef);
            this.Controls.Add(this.ConnectDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tervetuloa";
            ((System.ComponentModel.ISupportInitialize)(this.uNoQdef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectDb;
        private System.Windows.Forms.NumericUpDown uNoQdef;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

