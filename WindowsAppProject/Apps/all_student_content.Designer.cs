namespace WindowsAppProject.Apps
{
    partial class all_student_content
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
            this.BackPanel = new System.Windows.Forms.Panel();
            this.StNaPanel = new System.Windows.Forms.Panel();
            this.rjPanel3 = new RoundedPanelClass.RJPanel();
            this.lblStName = new System.Windows.Forms.Label();
            this.GPAPanel = new System.Windows.Forms.Panel();
            this.rjPanel6 = new RoundedPanelClass.RJPanel();
            this.lblGPA = new System.Windows.Forms.Label();
            this.CoNaPanel = new System.Windows.Forms.Panel();
            this.rjPanel5 = new RoundedPanelClass.RJPanel();
            this.lblCoName = new System.Windows.Forms.Label();
            this.CoIDPanel = new System.Windows.Forms.Panel();
            this.rjPanel4 = new RoundedPanelClass.RJPanel();
            this.lblCoID = new System.Windows.Forms.Label();
            this.StIDPanel = new System.Windows.Forms.Panel();
            this.rjPanel2 = new RoundedPanelClass.RJPanel();
            this.lblStID = new System.Windows.Forms.Label();
            this.rjPanel1 = new RoundedPanelClass.RJPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rjbtnSearch = new CustomControls.RJControls.RJButton();
            this.BackPanel.SuspendLayout();
            this.StNaPanel.SuspendLayout();
            this.rjPanel3.SuspendLayout();
            this.GPAPanel.SuspendLayout();
            this.rjPanel6.SuspendLayout();
            this.CoNaPanel.SuspendLayout();
            this.rjPanel5.SuspendLayout();
            this.CoIDPanel.SuspendLayout();
            this.rjPanel4.SuspendLayout();
            this.StIDPanel.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.StNaPanel);
            this.BackPanel.Controls.Add(this.GPAPanel);
            this.BackPanel.Controls.Add(this.CoNaPanel);
            this.BackPanel.Controls.Add(this.CoIDPanel);
            this.BackPanel.Controls.Add(this.StIDPanel);
            this.BackPanel.Location = new System.Drawing.Point(12, 101);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(1462, 739);
            this.BackPanel.TabIndex = 0;
            // 
            // StNaPanel
            // 
            this.StNaPanel.AutoScroll = true;
            this.StNaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.StNaPanel.Controls.Add(this.rjPanel3);
            this.StNaPanel.Location = new System.Drawing.Point(199, 12);
            this.StNaPanel.Name = "StNaPanel";
            this.StNaPanel.Size = new System.Drawing.Size(572, 714);
            this.StNaPanel.TabIndex = 10;
            // 
            // rjPanel3
            // 
            this.rjPanel3.BackColor = System.Drawing.Color.White;
            this.rjPanel3.BorderRadius = 30;
            this.rjPanel3.Controls.Add(this.lblStName);
            this.rjPanel3.ForeColor = System.Drawing.Color.White;
            this.rjPanel3.GradientAngle = 90F;
            this.rjPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel3.Location = new System.Drawing.Point(3, 19);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(566, 62);
            this.rjPanel3.TabIndex = 1;
            // 
            // lblStName
            // 
            this.lblStName.AutoSize = true;
            this.lblStName.BackColor = System.Drawing.Color.Transparent;
            this.lblStName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStName.ForeColor = System.Drawing.Color.White;
            this.lblStName.Location = new System.Drawing.Point(182, 15);
            this.lblStName.Name = "lblStName";
            this.lblStName.Size = new System.Drawing.Size(207, 32);
            this.lblStName.TabIndex = 2;
            this.lblStName.Text = "Student Name";
            this.lblStName.Click += new System.EventHandler(this.lblStName_Click);
            // 
            // GPAPanel
            // 
            this.GPAPanel.AutoScroll = true;
            this.GPAPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GPAPanel.Controls.Add(this.rjPanel6);
            this.GPAPanel.Location = new System.Drawing.Point(1264, 12);
            this.GPAPanel.Name = "GPAPanel";
            this.GPAPanel.Size = new System.Drawing.Size(182, 714);
            this.GPAPanel.TabIndex = 9;
            // 
            // rjPanel6
            // 
            this.rjPanel6.BackColor = System.Drawing.Color.White;
            this.rjPanel6.BorderRadius = 30;
            this.rjPanel6.Controls.Add(this.lblGPA);
            this.rjPanel6.ForeColor = System.Drawing.Color.White;
            this.rjPanel6.GradientAngle = 90F;
            this.rjPanel6.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel6.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel6.Location = new System.Drawing.Point(3, 19);
            this.rjPanel6.Name = "rjPanel6";
            this.rjPanel6.Size = new System.Drawing.Size(176, 62);
            this.rjPanel6.TabIndex = 1;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.BackColor = System.Drawing.Color.Transparent;
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.ForeColor = System.Drawing.Color.White;
            this.lblGPA.Location = new System.Drawing.Point(52, 15);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(77, 32);
            this.lblGPA.TabIndex = 1;
            this.lblGPA.Text = "GPA";
            // 
            // CoNaPanel
            // 
            this.CoNaPanel.AutoScroll = true;
            this.CoNaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.CoNaPanel.Controls.Add(this.rjPanel5);
            this.CoNaPanel.Location = new System.Drawing.Point(965, 12);
            this.CoNaPanel.Name = "CoNaPanel";
            this.CoNaPanel.Size = new System.Drawing.Size(293, 714);
            this.CoNaPanel.TabIndex = 8;
            // 
            // rjPanel5
            // 
            this.rjPanel5.BackColor = System.Drawing.Color.White;
            this.rjPanel5.BorderRadius = 30;
            this.rjPanel5.Controls.Add(this.lblCoName);
            this.rjPanel5.ForeColor = System.Drawing.Color.White;
            this.rjPanel5.GradientAngle = 90F;
            this.rjPanel5.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel5.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel5.Location = new System.Drawing.Point(3, 19);
            this.rjPanel5.Name = "rjPanel5";
            this.rjPanel5.Size = new System.Drawing.Size(287, 62);
            this.rjPanel5.TabIndex = 1;
            // 
            // lblCoName
            // 
            this.lblCoName.AutoSize = true;
            this.lblCoName.BackColor = System.Drawing.Color.Transparent;
            this.lblCoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoName.ForeColor = System.Drawing.Color.White;
            this.lblCoName.Location = new System.Drawing.Point(46, 15);
            this.lblCoName.Name = "lblCoName";
            this.lblCoName.Size = new System.Drawing.Size(198, 32);
            this.lblCoName.TabIndex = 1;
            this.lblCoName.Text = "Course Name";
            // 
            // CoIDPanel
            // 
            this.CoIDPanel.AutoScroll = true;
            this.CoIDPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CoIDPanel.Controls.Add(this.rjPanel4);
            this.CoIDPanel.Location = new System.Drawing.Point(777, 12);
            this.CoIDPanel.Name = "CoIDPanel";
            this.CoIDPanel.Size = new System.Drawing.Size(182, 714);
            this.CoIDPanel.TabIndex = 7;
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.White;
            this.rjPanel4.BorderRadius = 30;
            this.rjPanel4.Controls.Add(this.lblCoID);
            this.rjPanel4.ForeColor = System.Drawing.Color.White;
            this.rjPanel4.GradientAngle = 90F;
            this.rjPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel4.Location = new System.Drawing.Point(3, 19);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Size = new System.Drawing.Size(176, 62);
            this.rjPanel4.TabIndex = 1;
            // 
            // lblCoID
            // 
            this.lblCoID.AutoSize = true;
            this.lblCoID.BackColor = System.Drawing.Color.Transparent;
            this.lblCoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoID.ForeColor = System.Drawing.Color.White;
            this.lblCoID.Location = new System.Drawing.Point(17, 15);
            this.lblCoID.Name = "lblCoID";
            this.lblCoID.Size = new System.Drawing.Size(148, 32);
            this.lblCoID.TabIndex = 2;
            this.lblCoID.Text = "Course ID";
            this.lblCoID.Click += new System.EventHandler(this.lblCoID_Click);
            // 
            // StIDPanel
            // 
            this.StIDPanel.AutoScroll = true;
            this.StIDPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.StIDPanel.Controls.Add(this.rjPanel2);
            this.StIDPanel.Location = new System.Drawing.Point(14, 12);
            this.StIDPanel.Name = "StIDPanel";
            this.StIDPanel.Size = new System.Drawing.Size(179, 714);
            this.StIDPanel.TabIndex = 5;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.White;
            this.rjPanel2.BorderRadius = 30;
            this.rjPanel2.Controls.Add(this.lblStID);
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.GradientAngle = 90F;
            this.rjPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel2.Location = new System.Drawing.Point(3, 19);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(173, 62);
            this.rjPanel2.TabIndex = 0;
            // 
            // lblStID
            // 
            this.lblStID.AutoSize = true;
            this.lblStID.BackColor = System.Drawing.Color.Transparent;
            this.lblStID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStID.ForeColor = System.Drawing.Color.White;
            this.lblStID.Location = new System.Drawing.Point(9, 15);
            this.lblStID.Name = "lblStID";
            this.lblStID.Size = new System.Drawing.Size(157, 32);
            this.lblStID.TabIndex = 0;
            this.lblStID.Text = "Student ID";
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.label1);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel1.Location = new System.Drawing.Point(12, 13);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(1258, 69);
            this.rjPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registerd Students Dashbord.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjbtnSearch
            // 
            this.rjbtnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnSearch.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnSearch.BorderRadius = 15;
            this.rjbtnSearch.BorderSize = 0;
            this.rjbtnSearch.FlatAppearance.BorderSize = 0;
            this.rjbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnSearch.ForeColor = System.Drawing.Color.White;
            this.rjbtnSearch.Location = new System.Drawing.Point(1296, 13);
            this.rjbtnSearch.Name = "rjbtnSearch";
            this.rjbtnSearch.Size = new System.Drawing.Size(178, 69);
            this.rjbtnSearch.TabIndex = 2;
            this.rjbtnSearch.Text = "View More";
            this.rjbtnSearch.TextColor = System.Drawing.Color.White;
            this.rjbtnSearch.UseVisualStyleBackColor = false;
            this.rjbtnSearch.Click += new System.EventHandler(this.rjbtnSearch_Click);
            // 
            // all_student_content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1486, 852);
            this.Controls.Add(this.rjbtnSearch);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.BackPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1504, 899);
            this.MinimumSize = new System.Drawing.Size(1504, 899);
            this.Name = "all_student_content";
            this.Text = "all_student_content";
            this.BackPanel.ResumeLayout(false);
            this.StNaPanel.ResumeLayout(false);
            this.rjPanel3.ResumeLayout(false);
            this.rjPanel3.PerformLayout();
            this.GPAPanel.ResumeLayout(false);
            this.rjPanel6.ResumeLayout(false);
            this.rjPanel6.PerformLayout();
            this.CoNaPanel.ResumeLayout(false);
            this.rjPanel5.ResumeLayout(false);
            this.rjPanel5.PerformLayout();
            this.CoIDPanel.ResumeLayout(false);
            this.rjPanel4.ResumeLayout(false);
            this.rjPanel4.PerformLayout();
            this.StIDPanel.ResumeLayout(false);
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Panel GPAPanel;
        private System.Windows.Forms.Panel CoNaPanel;
        private System.Windows.Forms.Panel CoIDPanel;
        private System.Windows.Forms.Panel StIDPanel;
        private System.Windows.Forms.Panel StNaPanel;
        private RoundedPanelClass.RJPanel rjPanel3;
        private RoundedPanelClass.RJPanel rjPanel6;
        private RoundedPanelClass.RJPanel rjPanel5;
        private RoundedPanelClass.RJPanel rjPanel4;
        private RoundedPanelClass.RJPanel rjPanel2;
        private RoundedPanelClass.RJPanel rjPanel1;
        private CustomControls.RJControls.RJButton rjbtnSearch;
        private System.Windows.Forms.Label lblStID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStName;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblCoName;
        private System.Windows.Forms.Label lblCoID;
    }
}