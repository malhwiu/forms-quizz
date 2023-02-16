namespace TietovisaForms
{
    partial class Tietovisa
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
            this.LbQuestion = new System.Windows.Forms.Label();
            this.BtnQuestion1 = new System.Windows.Forms.Button();
            this.BtnQuestion2 = new System.Windows.Forms.Button();
            this.BtnQuestion3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbQuestion
            // 
            this.LbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQuestion.Location = new System.Drawing.Point(11, 104);
            this.LbQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbQuestion.Name = "LbQuestion";
            this.LbQuestion.Size = new System.Drawing.Size(625, 114);
            this.LbQuestion.TabIndex = 0;
            this.LbQuestion.Text = "Kysymys";
            this.LbQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnQuestion1
            // 
            this.BtnQuestion1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnQuestion1.Location = new System.Drawing.Point(18, 252);
            this.BtnQuestion1.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuestion1.Name = "BtnQuestion1";
            this.BtnQuestion1.Size = new System.Drawing.Size(186, 37);
            this.BtnQuestion1.TabIndex = 3;
            this.BtnQuestion1.Text = "Vastaus1";
            this.BtnQuestion1.UseVisualStyleBackColor = true;
            this.BtnQuestion1.Click += new System.EventHandler(this.ValidateAnswer);
            // 
            // BtnQuestion2
            // 
            this.BtnQuestion2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuestion2.Location = new System.Drawing.Point(208, 252);
            this.BtnQuestion2.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuestion2.Name = "BtnQuestion2";
            this.BtnQuestion2.Size = new System.Drawing.Size(233, 37);
            this.BtnQuestion2.TabIndex = 4;
            this.BtnQuestion2.Text = "Vastaus2";
            this.BtnQuestion2.UseVisualStyleBackColor = true;
            this.BtnQuestion2.Click += new System.EventHandler(this.ValidateAnswer);
            // 
            // BtnQuestion3
            // 
            this.BtnQuestion3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuestion3.Location = new System.Drawing.Point(445, 252);
            this.BtnQuestion3.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuestion3.Name = "BtnQuestion3";
            this.BtnQuestion3.Size = new System.Drawing.Size(186, 37);
            this.BtnQuestion3.TabIndex = 5;
            this.BtnQuestion3.Text = "Vastaus3";
            this.BtnQuestion3.UseVisualStyleBackColor = true;
            this.BtnQuestion3.Click += new System.EventHandler(this.ValidateAnswer);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.counter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 49);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tietovisa";
            // 
            // counter
            // 
            this.counter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.ForeColor = System.Drawing.SystemColors.Control;
            this.counter.Location = new System.Drawing.Point(100, 10);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(538, 39);
            this.counter.TabIndex = 1;
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tietovisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnQuestion3);
            this.Controls.Add(this.BtnQuestion2);
            this.Controls.Add(this.BtnQuestion1);
            this.Controls.Add(this.LbQuestion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "Tietovisa";
            this.ShowIcon = false;
            this.Text = "Quizz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbQuestion;
        private System.Windows.Forms.Button BtnQuestion1;
        private System.Windows.Forms.Button BtnQuestion2;
        private System.Windows.Forms.Button BtnQuestion3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label counter;
    }
}