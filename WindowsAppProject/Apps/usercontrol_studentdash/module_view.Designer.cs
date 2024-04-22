namespace WindowsAppProject.Apps.usercontrol_studentdash
{
    partial class module_view
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchbutton = new CustomControls.RJControls.RJButton();
            this.topstudentview = new RoundedPanelClass.RJPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.topstudentview.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(592, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 39);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.label6.Location = new System.Drawing.Point(1119, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 45);
            this.label6.TabIndex = 17;
            this.label6.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(236, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Module Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(562, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 45);
            this.label4.TabIndex = 15;
            this.label4.Text = "Module Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(916, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 45);
            this.label5.TabIndex = 16;
            this.label5.Text = "Credits";
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Transparent;
            this.searchbutton.BackgroundColor = System.Drawing.Color.Transparent;
            this.searchbutton.BackgroundImage = global::WindowsAppProject.Properties.Resources.icons8_search_48;
            this.searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchbutton.BorderRadius = 16;
            this.searchbutton.BorderSize = 0;
            this.searchbutton.FlatAppearance.BorderSize = 0;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.ForeColor = System.Drawing.Color.White;
            this.searchbutton.Location = new System.Drawing.Point(1195, 18);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(62, 53);
            this.searchbutton.TabIndex = 12;
            this.searchbutton.TextColor = System.Drawing.Color.White;
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // topstudentview
            // 
            this.topstudentview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.topstudentview.BorderRadius = 30;
            this.topstudentview.Controls.Add(this.panel6);
            this.topstudentview.Controls.Add(this.panel5);
            this.topstudentview.Controls.Add(this.panel4);
            this.topstudentview.Controls.Add(this.panel3);
            this.topstudentview.Controls.Add(this.panel2);
            this.topstudentview.ForeColor = System.Drawing.Color.White;
            this.topstudentview.GradientAngle = 90F;
            this.topstudentview.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.topstudentview.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.topstudentview.Location = new System.Drawing.Point(3, 128);
            this.topstudentview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topstudentview.Name = "topstudentview";
            this.topstudentview.Size = new System.Drawing.Size(1264, 495);
            this.topstudentview.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Location = new System.Drawing.Point(1088, 13);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(166, 475);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Location = new System.Drawing.Point(880, 13);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(196, 475);
            this.panel5.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Location = new System.Drawing.Point(472, 13);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 475);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Location = new System.Drawing.Point(230, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 475);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(9, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 475);
            this.panel2.TabIndex = 10;
            // 
            // module_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.topstudentview);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "module_view";
            this.Size = new System.Drawing.Size(1270, 625);
            this.Load += new System.EventHandler(this.module_view_Load);
            this.topstudentview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private CustomControls.RJControls.RJButton searchbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RoundedPanelClass.RJPanel topstudentview;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
