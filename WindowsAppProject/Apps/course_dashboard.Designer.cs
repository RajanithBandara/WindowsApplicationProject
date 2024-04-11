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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(course_dashboard));
            this.contentpanel = new RoundedPanelClass.RJPanel();
            this.rjPanel1 = new RoundedPanelClass.RJPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.rjButton6 = new CustomControls.RJControls.RJButton();
            this.rjButton7 = new CustomControls.RJControls.RJButton();
            this.rjPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentpanel
            // 
            this.contentpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.contentpanel.BorderRadius = 30;
            this.contentpanel.ForeColor = System.Drawing.Color.White;
            this.contentpanel.GradientAngle = 90F;
            this.contentpanel.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.contentpanel.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.contentpanel.Location = new System.Drawing.Point(411, 32);
            this.contentpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(873, 570);
            this.contentpanel.TabIndex = 1;
            this.contentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentpanel_Paint);
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.panel1);
            this.rjPanel1.Controls.Add(this.rjButton4);
            this.rjPanel1.Controls.Add(this.rjButton6);
            this.rjPanel1.Controls.Add(this.rjButton7);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.rjPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.rjPanel1.Location = new System.Drawing.Point(18, 32);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(353, 570);
            this.rjPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjButton3);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 198);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(41, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Remove Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(203, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Register a new course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(149, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Courses";
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.Transparent;
            this.rjButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton3.BackgroundImage = global::WindowsAppProject.Properties.Resources.ebook;
            this.rjButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 12;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(53, 112);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(68, 50);
            this.rjButton3.TabIndex = 12;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundImage = global::WindowsAppProject.Properties.Resources.online_course;
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(231, 112);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(68, 50);
            this.rjButton2.TabIndex = 1;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundImage = global::WindowsAppProject.Properties.Resources.article;
            this.rjButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 16;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(142, 24);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(68, 50);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.rjButton4.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton4.BorderRadius = 12;
            this.rjButton4.BorderSize = 1;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(57, 492);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(238, 50);
            this.rjButton4.TabIndex = 16;
            this.rjButton4.Text = "GPA Calculator";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.rjButton6.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton6.BorderRadius = 12;
            this.rjButton6.BorderSize = 1;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(57, 430);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(238, 50);
            this.rjButton6.TabIndex = 15;
            this.rjButton6.Text = "Course Dashboard";
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            // 
            // rjButton7
            // 
            this.rjButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.rjButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.rjButton7.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton7.BorderRadius = 12;
            this.rjButton7.BorderSize = 0;
            this.rjButton7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton7.FlatAppearance.BorderSize = 0;
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton7.ForeColor = System.Drawing.Color.White;
            this.rjButton7.Location = new System.Drawing.Point(57, 368);
            this.rjButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(238, 50);
            this.rjButton7.TabIndex = 14;
            this.rjButton7.Text = "Student Dashboard";
            this.rjButton7.TextColor = System.Drawing.Color.White;
            this.rjButton7.UseVisualStyleBackColor = false;
            // 
            // course_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1309, 630);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.contentpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1327, 677);
            this.MinimumSize = new System.Drawing.Size(1327, 677);
            this.Name = "course_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Dashboard";
            this.Load += new System.EventHandler(this.course_dashboard_Load);
            this.rjPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanelClass.RJPanel rjPanel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private RoundedPanelClass.RJPanel contentpanel;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton6;
        private CustomControls.RJControls.RJButton rjButton7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}