namespace WindowsAppProject
{
    partial class gpacalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gpacalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rjPanel1 = new RoundedPanelClass.RJPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjPanel2 = new RoundedPanelClass.RJPanel();
            this.rjPanel3 = new RoundedPanelClass.RJPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.rjPanel4 = new RoundedPanelClass.RJPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.MName = new System.Windows.Forms.Panel();
            this.Mgrade = new System.Windows.Forms.Panel();
            this.Mcredits = new System.Windows.Forms.Panel();
            this.textbxpanel = new System.Windows.Forms.Panel();
            this.rjPanel1.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.rjPanel3.SuspendLayout();
            this.rjPanel4.SuspendLayout();
            this.textbxpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(74, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Module Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(136, 582);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1032, 81);
            this.flowLayoutPanel1.TabIndex = 25;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.label4);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(220)))));
            this.rjPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(220)))));
            this.rjPanel1.Location = new System.Drawing.Point(136, 48);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(866, 50);
            this.rjPanel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(418, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "0.0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton4.BorderRadius = 12;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.Black;
            this.rjButton4.Location = new System.Drawing.Point(1008, 48);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(158, 50);
            this.rjButton4.TabIndex = 27;
            this.rjButton4.Text = "Send All";
            this.rjButton4.TextColor = System.Drawing.Color.Black;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(100)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(100)))));
            this.rjButton3.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton3.BorderRadius = 10;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.Black;
            this.rjButton3.Location = new System.Drawing.Point(838, 596);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(330, 52);
            this.rjButton3.TabIndex = 22;
            this.rjButton3.Text = "Calculate";
            this.rjButton3.TextColor = System.Drawing.Color.Black;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(122)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(122)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(489, 596);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(330, 52);
            this.rjButton2.TabIndex = 21;
            this.rjButton2.Text = "Remove Module";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.rjButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(136, 596);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(330, 52);
            this.rjButton1.TabIndex = 20;
            this.rjButton1.Text = "Add Module";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.White;
            this.rjPanel2.BorderRadius = 30;
            this.rjPanel2.Controls.Add(this.label1);
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.GradientAngle = 90F;
            this.rjPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel2.Location = new System.Drawing.Point(136, 102);
            this.rjPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(364, 58);
            this.rjPanel2.TabIndex = 29;
            this.rjPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel2_Paint);
            // 
            // rjPanel3
            // 
            this.rjPanel3.BackColor = System.Drawing.Color.White;
            this.rjPanel3.BorderRadius = 30;
            this.rjPanel3.Controls.Add(this.label5);
            this.rjPanel3.ForeColor = System.Drawing.Color.White;
            this.rjPanel3.GradientAngle = 90F;
            this.rjPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel3.Location = new System.Drawing.Point(562, 102);
            this.rjPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(237, 58);
            this.rjPanel3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(74, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grade";
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.White;
            this.rjPanel4.BorderRadius = 30;
            this.rjPanel4.Controls.Add(this.label2);
            this.rjPanel4.ForeColor = System.Drawing.Color.White;
            this.rjPanel4.GradientAngle = 90F;
            this.rjPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjPanel4.Location = new System.Drawing.Point(866, 102);
            this.rjPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Size = new System.Drawing.Size(302, 58);
            this.rjPanel4.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(104, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "Credits";
            // 
            // MName
            // 
            this.MName.AutoScroll = true;
            this.MName.Location = new System.Drawing.Point(0, 2);
            this.MName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(364, 408);
            this.MName.TabIndex = 0;
            // 
            // Mgrade
            // 
            this.Mgrade.AutoScroll = true;
            this.Mgrade.Location = new System.Drawing.Point(428, 2);
            this.Mgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mgrade.Name = "Mgrade";
            this.Mgrade.Size = new System.Drawing.Size(237, 410);
            this.Mgrade.TabIndex = 0;
            // 
            // Mcredits
            // 
            this.Mcredits.AutoScroll = true;
            this.Mcredits.Location = new System.Drawing.Point(730, 2);
            this.Mcredits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mcredits.Name = "Mcredits";
            this.Mcredits.Size = new System.Drawing.Size(299, 408);
            this.Mcredits.TabIndex = 0;
            // 
            // textbxpanel
            // 
            this.textbxpanel.BackColor = System.Drawing.Color.Transparent;
            this.textbxpanel.Controls.Add(this.Mcredits);
            this.textbxpanel.Controls.Add(this.Mgrade);
            this.textbxpanel.Controls.Add(this.MName);
            this.textbxpanel.Location = new System.Drawing.Point(136, 166);
            this.textbxpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbxpanel.Name = "textbxpanel";
            this.textbxpanel.Size = new System.Drawing.Size(1032, 410);
            this.textbxpanel.TabIndex = 19;
            this.textbxpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.textbxpanel_Paint);
            // 
            // gpacalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1304, 691);
            this.Controls.Add(this.rjPanel4);
            this.Controls.Add(this.rjPanel3);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.textbxpanel);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rjPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1326, 747);
            this.MinimumSize = new System.Drawing.Size(1326, 747);
            this.Name = "gpacalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.rjPanel3.ResumeLayout(false);
            this.rjPanel3.PerformLayout();
            this.rjPanel4.ResumeLayout(false);
            this.rjPanel4.PerformLayout();
            this.textbxpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJButton rjButton4;
        private RoundedPanelClass.RJPanel rjPanel1;
        private System.Windows.Forms.Label label4;
        private RoundedPanelClass.RJPanel rjPanel2;
        private RoundedPanelClass.RJPanel rjPanel3;
        private System.Windows.Forms.Label label5;
        private RoundedPanelClass.RJPanel rjPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel MName;
        private System.Windows.Forms.Panel Mgrade;
        private System.Windows.Forms.Panel Mcredits;
        private System.Windows.Forms.Panel textbxpanel;
    }
}

