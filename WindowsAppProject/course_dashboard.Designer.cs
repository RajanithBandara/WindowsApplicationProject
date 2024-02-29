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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbxpanel = new System.Windows.Forms.Panel();
            this.Mcredits = new System.Windows.Forms.Panel();
            this.Mgrade = new System.Windows.Forms.Panel();
            this.MName = new System.Windows.Forms.Panel();
            this.addMod = new System.Windows.Forms.Button();
            this.removeMod = new System.Windows.Forms.Button();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.textbxpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(243, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(689, 57);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(852, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Credits";
            // 
            // textbxpanel
            // 
            this.textbxpanel.Controls.Add(this.Mcredits);
            this.textbxpanel.Controls.Add(this.Mgrade);
            this.textbxpanel.Controls.Add(this.MName);
            this.textbxpanel.Location = new System.Drawing.Point(148, 172);
            this.textbxpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbxpanel.Name = "textbxpanel";
            this.textbxpanel.Size = new System.Drawing.Size(861, 362);
            this.textbxpanel.TabIndex = 2;
            this.textbxpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.textbxpanel_Paint);
            // 
            // Mcredits
            // 
            this.Mcredits.Location = new System.Drawing.Point(666, 0);
            this.Mcredits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mcredits.Name = "Mcredits";
            this.Mcredits.Size = new System.Drawing.Size(195, 362);
            this.Mcredits.TabIndex = 0;
            this.Mcredits.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Mgrade
            // 
            this.Mgrade.Location = new System.Drawing.Point(459, 0);
            this.Mgrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mgrade.Name = "Mgrade";
            this.Mgrade.Size = new System.Drawing.Size(180, 362);
            this.Mgrade.TabIndex = 0;
            this.Mgrade.Paint += new System.Windows.Forms.PaintEventHandler(this.Mgrade_Paint);
            // 
            // MName
            // 
            this.MName.Location = new System.Drawing.Point(0, 0);
            this.MName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(450, 362);
            this.MName.TabIndex = 0;
            this.MName.Paint += new System.Windows.Forms.PaintEventHandler(this.MName_Paint);
            // 
            // addMod
            // 
            this.addMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMod.Location = new System.Drawing.Point(244, 549);
            this.addMod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addMod.Name = "addMod";
            this.addMod.Size = new System.Drawing.Size(289, 51);
            this.addMod.TabIndex = 3;
            this.addMod.Text = "Add Module";
            this.addMod.UseVisualStyleBackColor = true;
            this.addMod.Click += new System.EventHandler(this.addMod_Click);
            // 
            // removeMod
            // 
            this.removeMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMod.Location = new System.Drawing.Point(636, 549);
            this.removeMod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeMod.Name = "removeMod";
            this.removeMod.Size = new System.Drawing.Size(298, 51);
            this.removeMod.TabIndex = 3;
            this.removeMod.Text = "Remove Module";
            this.removeMod.UseVisualStyleBackColor = true;
            this.removeMod.Click += new System.EventHandler(this.removeMod_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(631, 549);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(330, 52);
            this.rjButton1.TabIndex = 21;
            this.rjButton1.Text = "Remove Module";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(222, 549);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(330, 52);
            this.rjButton2.TabIndex = 22;
            this.rjButton2.Text = "Add Module";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // course_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1198, 619);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.removeMod);
            this.Controls.Add(this.addMod);
            this.Controls.Add(this.textbxpanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "course_dashboard";
            this.Text = "gpacalculator";
            this.Load += new System.EventHandler(this.gpacalculator_Load);
            this.textbxpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel textbxpanel;
        private System.Windows.Forms.Panel Mgrade;
        private System.Windows.Forms.Panel Mcredits;
        private System.Windows.Forms.Panel MName;
        private System.Windows.Forms.Button addMod;
        private System.Windows.Forms.Button removeMod;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
    }
}