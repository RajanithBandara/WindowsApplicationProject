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
            this.rjpSearch.SuspendLayout();
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
            this.rjpSearch.Location = new System.Drawing.Point(45, 45);
            this.rjpSearch.Name = "rjpSearch";
            this.rjpSearch.Size = new System.Drawing.Size(846, 258);
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
            this.rjButClear.Location = new System.Drawing.Point(252, 139);
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
            this.rjButSearch.Location = new System.Drawing.Point(479, 139);
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
            this.txtStDVEnStID.BackColor = System.Drawing.SystemColors.Info;
            this.txtStDVEnStID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStDVEnStID.Location = new System.Drawing.Point(387, 62);
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
            this.lblEnStID.Location = new System.Drawing.Point(78, 61);
            this.lblEnStID.Name = "lblEnStID";
            this.lblEnStID.Size = new System.Drawing.Size(257, 29);
            this.lblEnStID.TabIndex = 11;
            this.lblEnStID.Text = "Enter Your Student ID";
            // 
            // student_det_viewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(945, 349);
            this.Controls.Add(this.rjpSearch);
            this.Name = "student_det_viewform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.student_det_viewform_Load);
            this.rjpSearch.ResumeLayout(false);
            this.rjpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanelClass.RJPanel rjpSearch;
        private CustomControls.RJControls.RJButton rjButClear;
        private CustomControls.RJControls.RJButton rjButSearch;
        private System.Windows.Forms.TextBox txtStDVEnStID;
        private System.Windows.Forms.Label lblEnStID;
    }
}