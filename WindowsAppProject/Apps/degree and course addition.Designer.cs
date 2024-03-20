namespace WindowsAppProject
{
    partial class degree_and_course_addition
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
            this.label5 = new System.Windows.Forms.Label();
            this.rjPanel1 = new RoundedPanelClass.RJPanel();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 10;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.Transparent;
            this.rjPanel1.BorderRadius = 0;
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.GradientAngle = 9F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.rjPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.rjPanel1.Location = new System.Drawing.Point(543, 1);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(695, 854);
            this.rjPanel1.TabIndex = 17;
            // 
            // degree_and_course_addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1231, 856);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "degree_and_course_addition";
            this.Text = "degree_and_course_addition";
            this.Load += new System.EventHandler(this.degree_and_course_addition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private RoundedPanelClass.RJPanel rjPanel1;
    }
}