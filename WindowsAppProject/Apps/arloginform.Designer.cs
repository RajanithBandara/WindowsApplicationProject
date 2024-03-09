namespace WindowsAppProject.Apps
{
    partial class arloginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arloginform));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.Hint1 = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 

            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.textBox1.Location = new System.Drawing.Point(279, 119);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 22);

            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 

            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.textBox2.Location = new System.Drawing.Point(279, 171);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 22);

            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);

            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(132, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);

            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(256, 226);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(133, 32);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "Login";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Hint1
            // 
            this.Hint1.BackColor = System.Drawing.Color.White;
            this.Hint1.BackgroundColor = System.Drawing.Color.White;
            this.Hint1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Hint1.BorderRadius = 0;
            this.Hint1.BorderSize = 0;
            this.Hint1.FlatAppearance.BorderSize = 0;
            this.Hint1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hint1.ForeColor = System.Drawing.Color.White;
            this.Hint1.Image = ((System.Drawing.Image)(resources.GetObject("Hint1.Image")));
            this.Hint1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Hint1.Location = new System.Drawing.Point(604, 214);
            this.Hint1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Hint1.Name = "Hint1";
            this.Hint1.Size = new System.Drawing.Size(30, 29);
            this.Hint1.TabIndex = 21;
            this.Hint1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hint1.TextColor = System.Drawing.Color.White;
            this.Hint1.UseVisualStyleBackColor = false;
            this.Hint1.Click += new System.EventHandler(this.Hint1_Click);
            // 
            // arloginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(711, 360);

            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "arloginform";
            this.Text = "arloginform";
            this.Load += new System.EventHandler(this.arloginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton Hint1;
    }
}