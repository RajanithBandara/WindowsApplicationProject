namespace practice_project
{
    partial class course_dashboard
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
            this.rjPanel1 = new RoundedPanelClass.RJPanel();
            this.rjPanel2 = new RoundedPanelClass.RJPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjPanel1.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.rjButton1);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.DarkGray;
            this.rjPanel1.GradientTopColor = System.Drawing.Color.Green;
            this.rjPanel1.Location = new System.Drawing.Point(1050, 35);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(381, 147);
            this.rjPanel1.TabIndex = 0;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.White;
            this.rjPanel2.BorderRadius = 30;
            this.rjPanel2.Controls.Add(this.label1);
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.GradientAngle = 90F;
            this.rjPanel2.GradientBottomColor = System.Drawing.Color.DarkGray;
            this.rjPanel2.GradientTopColor = System.Drawing.Color.Green;
            this.rjPanel2.Location = new System.Drawing.Point(65, 35);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(953, 707);
            this.rjPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(335, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current registered courses";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(99, 31);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(198, 81);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "Register a new course";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // course_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1469, 779);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.rjPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "course_dashboard";
            this.Text = "gpacalculator";
            this.Load += new System.EventHandler(this.gpacalculator_Load);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanelClass.RJPanel rjPanel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private RoundedPanelClass.RJPanel rjPanel2;
        private System.Windows.Forms.Label label1;
    }
}