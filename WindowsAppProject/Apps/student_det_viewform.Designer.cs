namespace WindowsAppProject.Apps
{
    partial class student_det_viewform
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
            this.rjpSearch = new RoundedPanelClass.RJPanel();
            this.rjButClear = new CustomControls.RJControls.RJButton();
            this.rjButSearch = new CustomControls.RJControls.RJButton();
            this.txtStDVEnStID = new System.Windows.Forms.TextBox();
            this.lblEnStID = new System.Windows.Forms.Label();
            this.rjPStDeView = new RoundedPanelClass.RJPanel();
            this.rjButGoBack = new CustomControls.RJControls.RJButton();
            this.txtSTDVCoName = new System.Windows.Forms.TextBox();
            this.lblStDVCoName = new System.Windows.Forms.Label();
            this.txtStDVStName = new System.Windows.Forms.TextBox();
            this.lblSTDVStName = new System.Windows.Forms.Label();
            this.txtStDVShStID = new System.Windows.Forms.TextBox();
            this.lblStDVStID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjpSearch.SuspendLayout();
            this.rjPStDeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjpSearch
            // 
            this.rjpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.rjpSearch.BorderRadius = 30;
            this.rjpSearch.Controls.Add(this.rjButClear);
            this.rjpSearch.Controls.Add(this.rjButSearch);
            this.rjpSearch.Controls.Add(this.txtStDVEnStID);
            this.rjpSearch.Controls.Add(this.lblEnStID);
            this.rjpSearch.ForeColor = System.Drawing.Color.White;
            this.rjpSearch.GradientAngle = 90F;
            this.rjpSearch.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjpSearch.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.rjpSearch.Location = new System.Drawing.Point(40, 31);
            this.rjpSearch.Name = "rjpSearch";
            this.rjpSearch.Size = new System.Drawing.Size(1046, 257);
            this.rjpSearch.TabIndex = 0;
            this.rjpSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.rjpSearch_Paint);
            // 
            // rjButClear
            // 
            this.rjButClear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButClear.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButClear.BorderRadius = 12;
            this.rjButClear.BorderSize = 0;
            this.rjButClear.FlatAppearance.BorderSize = 0;
            this.rjButClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButClear.ForeColor = System.Drawing.Color.White;
            this.rjButClear.Location = new System.Drawing.Point(309, 152);
            this.rjButClear.Name = "rjButClear";
            this.rjButClear.Size = new System.Drawing.Size(131, 56);
            this.rjButClear.TabIndex = 14;
            this.rjButClear.Text = "Clear";
            this.rjButClear.TextColor = System.Drawing.Color.White;
            this.rjButClear.UseVisualStyleBackColor = false;
            this.rjButClear.Click += new System.EventHandler(this.rjButClear_Click);
            // 
            // rjButSearch
            // 
            this.rjButSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButSearch.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButSearch.BorderRadius = 12;
            this.rjButSearch.BorderSize = 0;
            this.rjButSearch.FlatAppearance.BorderSize = 0;
            this.rjButSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButSearch.ForeColor = System.Drawing.Color.White;
            this.rjButSearch.Location = new System.Drawing.Point(536, 152);
            this.rjButSearch.Name = "rjButSearch";
            this.rjButSearch.Size = new System.Drawing.Size(123, 56);
            this.rjButSearch.TabIndex = 13;
            this.rjButSearch.Text = "Search";
            this.rjButSearch.TextColor = System.Drawing.Color.White;
            this.rjButSearch.UseVisualStyleBackColor = false;
            this.rjButSearch.Click += new System.EventHandler(this.rjButSearch_Click);
            // 
            // txtStDVEnStID
            // 
            this.txtStDVEnStID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStDVEnStID.Location = new System.Drawing.Point(444, 73);
            this.txtStDVEnStID.Name = "txtStDVEnStID";
            this.txtStDVEnStID.Size = new System.Drawing.Size(382, 30);
            this.txtStDVEnStID.TabIndex = 12;
            this.txtStDVEnStID.TextChanged += new System.EventHandler(this.txtStDVEnStID_TextChanged);
            // 
            // lblEnStID
            // 
            this.lblEnStID.AutoSize = true;
            this.lblEnStID.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblEnStID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnStID.ForeColor = System.Drawing.Color.White;
            this.lblEnStID.Location = new System.Drawing.Point(135, 74);
            this.lblEnStID.Name = "lblEnStID";
            this.lblEnStID.Size = new System.Drawing.Size(257, 29);
            this.lblEnStID.TabIndex = 11;
            this.lblEnStID.Text = "Enter Your Student ID";
            // 
            // rjPStDeView
            // 
            this.rjPStDeView.BackColor = System.Drawing.Color.White;
            this.rjPStDeView.BorderRadius = 30;
            this.rjPStDeView.Controls.Add(this.textBox1);
            this.rjPStDeView.Controls.Add(this.label1);
            this.rjPStDeView.Controls.Add(this.rjButGoBack);
            this.rjPStDeView.Controls.Add(this.txtSTDVCoName);
            this.rjPStDeView.Controls.Add(this.lblStDVCoName);
            this.rjPStDeView.Controls.Add(this.txtStDVStName);
            this.rjPStDeView.Controls.Add(this.lblSTDVStName);
            this.rjPStDeView.Controls.Add(this.txtStDVShStID);
            this.rjPStDeView.Controls.Add(this.lblStDVStID);
            this.rjPStDeView.ForeColor = System.Drawing.Color.White;
            this.rjPStDeView.GradientAngle = 90F;
            this.rjPStDeView.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.rjPStDeView.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjPStDeView.Location = new System.Drawing.Point(40, 331);
            this.rjPStDeView.Name = "rjPStDeView";
            this.rjPStDeView.Size = new System.Drawing.Size(1046, 383);
            this.rjPStDeView.TabIndex = 1;
            this.rjPStDeView.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPStDeView_Paint);
            // 
            // rjButGoBack
            // 
            this.rjButGoBack.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButGoBack.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButGoBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButGoBack.BorderRadius = 12;
            this.rjButGoBack.BorderSize = 0;
            this.rjButGoBack.FlatAppearance.BorderSize = 0;
            this.rjButGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButGoBack.ForeColor = System.Drawing.Color.White;
            this.rjButGoBack.Location = new System.Drawing.Point(419, 312);
            this.rjButGoBack.Name = "rjButGoBack";
            this.rjButGoBack.Size = new System.Drawing.Size(173, 54);
            this.rjButGoBack.TabIndex = 6;
            this.rjButGoBack.Text = "Go To Student Content";
            this.rjButGoBack.TextColor = System.Drawing.Color.White;
            this.rjButGoBack.UseVisualStyleBackColor = false;
            this.rjButGoBack.Click += new System.EventHandler(this.rjButGoBack_Click);
            // 
            // txtSTDVCoName
            // 
            this.txtSTDVCoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSTDVCoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTDVCoName.Location = new System.Drawing.Point(404, 176);
            this.txtSTDVCoName.Name = "txtSTDVCoName";
            this.txtSTDVCoName.Size = new System.Drawing.Size(382, 30);
            this.txtSTDVCoName.TabIndex = 5;
            this.txtSTDVCoName.TextChanged += new System.EventHandler(this.txtSTDVCoName_TextChanged);
            // 
            // lblStDVCoName
            // 
            this.lblStDVCoName.AutoSize = true;
            this.lblStDVCoName.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblStDVCoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStDVCoName.ForeColor = System.Drawing.Color.White;
            this.lblStDVCoName.Location = new System.Drawing.Point(226, 181);
            this.lblStDVCoName.Name = "lblStDVCoName";
            this.lblStDVCoName.Size = new System.Drawing.Size(144, 25);
            this.lblStDVCoName.TabIndex = 4;
            this.lblStDVCoName.Text = "Course Name";
            // 
            // txtStDVStName
            // 
            this.txtStDVStName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStDVStName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStDVStName.Location = new System.Drawing.Point(404, 111);
            this.txtStDVStName.Name = "txtStDVStName";
            this.txtStDVStName.Size = new System.Drawing.Size(382, 30);
            this.txtStDVStName.TabIndex = 3;
            this.txtStDVStName.TextChanged += new System.EventHandler(this.txtStDVStName_TextChanged);
            // 
            // lblSTDVStName
            // 
            this.lblSTDVStName.AutoSize = true;
            this.lblSTDVStName.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSTDVStName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTDVStName.ForeColor = System.Drawing.Color.White;
            this.lblSTDVStName.Location = new System.Drawing.Point(226, 116);
            this.lblSTDVStName.Name = "lblSTDVStName";
            this.lblSTDVStName.Size = new System.Drawing.Size(149, 25);
            this.lblSTDVStName.TabIndex = 2;
            this.lblSTDVStName.Text = "Student Name";
            // 
            // txtStDVShStID
            // 
            this.txtStDVShStID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStDVShStID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStDVShStID.Location = new System.Drawing.Point(404, 49);
            this.txtStDVShStID.Name = "txtStDVShStID";
            this.txtStDVShStID.Size = new System.Drawing.Size(382, 30);
            this.txtStDVShStID.TabIndex = 1;
            this.txtStDVShStID.TextChanged += new System.EventHandler(this.txtStDVShStID_TextChanged);
            // 
            // lblStDVStID
            // 
            this.lblStDVStID.AutoSize = true;
            this.lblStDVStID.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblStDVStID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStDVStID.ForeColor = System.Drawing.Color.White;
            this.lblStDVStID.Location = new System.Drawing.Point(226, 52);
            this.lblStDVStID.Name = "lblStDVStID";
            this.lblStDVStID.Size = new System.Drawing.Size(114, 25);
            this.lblStDVStID.TabIndex = 0;
            this.lblStDVStID.Text = "Student ID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(404, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 30);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "GPA";
            // 
            // student_det_viewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1127, 746);
            this.Controls.Add(this.rjPStDeView);
            this.Controls.Add(this.rjpSearch);
            this.Name = "student_det_viewform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.student_det_viewform_Load);
            this.rjpSearch.ResumeLayout(false);
            this.rjpSearch.PerformLayout();
            this.rjPStDeView.ResumeLayout(false);
            this.rjPStDeView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanelClass.RJPanel rjpSearch;
        private CustomControls.RJControls.RJButton rjButClear;
        private CustomControls.RJControls.RJButton rjButSearch;
        private System.Windows.Forms.TextBox txtStDVEnStID;
        private System.Windows.Forms.Label lblEnStID;
        private RoundedPanelClass.RJPanel rjPStDeView;
        private System.Windows.Forms.TextBox txtSTDVCoName;
        private System.Windows.Forms.Label lblStDVCoName;
        private System.Windows.Forms.TextBox txtStDVStName;
        private System.Windows.Forms.Label lblSTDVStName;
        private System.Windows.Forms.TextBox txtStDVShStID;
        private System.Windows.Forms.Label lblStDVStID;
        private CustomControls.RJControls.RJButton rjButGoBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}