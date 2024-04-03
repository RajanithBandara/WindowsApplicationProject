﻿using System.Drawing;

namespace WindowsAppProject
{
    partial class maindashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maindashboard));
            this.rjPanel2 = new RoundedPanelClass.RJPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjPanel4 = new RoundedPanelClass.RJPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton6 = new CustomControls.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton8 = new CustomControls.RJControls.RJButton();
            this.rjButton7 = new CustomControls.RJControls.RJButton();
            this.rjButton5 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjPanel6 = new RoundedPanelClass.RJPanel();
            this.rjPanel3 = new RoundedPanelClass.RJPanel();
            this.rjPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rjPanel4.SuspendLayout();
            this.rjPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.rjPanel2.BorderRadius = 30;
            this.rjPanel2.Controls.Add(this.panel2);
            this.rjPanel2.Controls.Add(this.panel1);
            this.rjPanel2.Controls.Add(this.rjButton2);
            this.rjPanel2.Controls.Add(this.rjPanel4);
            this.rjPanel2.Controls.Add(this.rjButton1);
            this.rjPanel2.Controls.Add(this.rjButton4);
            this.rjPanel2.Controls.Add(this.rjButton3);
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.GradientAngle = 90F;
            this.rjPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.rjPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.rjPanel2.Location = new System.Drawing.Point(1339, 16);
            this.rjPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(369, 909);
            this.rjPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(6, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 52);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(25, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "ARUser details and some minor details will appear here";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsAppProject.Properties.Resources.user;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(111, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 149);
            this.panel1.TabIndex = 5;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton2.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderRadius = 12;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(56, 772);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(269, 62);
            this.rjButton2.TabIndex = 4;
            this.rjButton2.Text = "GPA Calculator";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click_1);
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.Black;
            this.rjPanel4.BorderRadius = 0;
            this.rjPanel4.Controls.Add(this.label2);
            this.rjPanel4.Controls.Add(this.rjButton6);
            this.rjPanel4.Controls.Add(this.label4);
            this.rjPanel4.Controls.Add(this.label3);
            this.rjPanel4.Controls.Add(this.label1);
            this.rjPanel4.Controls.Add(this.rjButton8);
            this.rjPanel4.Controls.Add(this.rjButton7);
            this.rjPanel4.Controls.Add(this.rjButton5);
            this.rjPanel4.ForeColor = System.Drawing.Color.White;
            this.rjPanel4.GradientAngle = 90F;
            this.rjPanel4.GradientBottomColor = System.Drawing.Color.Black;
            this.rjPanel4.GradientTopColor = System.Drawing.Color.Black;
            this.rjPanel4.Location = new System.Drawing.Point(0, 302);
            this.rjPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Size = new System.Drawing.Size(369, 217);
            this.rjPanel4.TabIndex = 0;
            this.rjPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Top Students";
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.Transparent;
            this.rjButton6.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton6.BackgroundImage = global::WindowsAppProject.Properties.Resources.graduates;
            this.rjButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 15;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(196, 24);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(76, 61);
            this.rjButton6.TabIndex = 6;
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.rjButton6_Click);
            this.rjButton6.MouseLeave += new System.EventHandler(this.rjButton6_MouseLeave);
            this.rjButton6.MouseHover += new System.EventHandler(this.rjButton6_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Results Update";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Add Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Register Student";
            // 
            // rjButton8
            // 
            this.rjButton8.BackColor = System.Drawing.Color.Transparent;
            this.rjButton8.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton8.BackgroundImage = global::WindowsAppProject.Properties.Resources.icons8_update_48;
            this.rjButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton8.BorderRadius = 15;
            this.rjButton8.BorderSize = 0;
            this.rjButton8.FlatAppearance.BorderSize = 0;
            this.rjButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton8.ForeColor = System.Drawing.Color.White;
            this.rjButton8.Location = new System.Drawing.Point(196, 122);
            this.rjButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Size = new System.Drawing.Size(76, 61);
            this.rjButton8.TabIndex = 8;
            this.rjButton8.TextColor = System.Drawing.Color.White;
            this.rjButton8.UseVisualStyleBackColor = false;
            this.rjButton8.Click += new System.EventHandler(this.rjButton8_Click);
            this.rjButton8.MouseLeave += new System.EventHandler(this.rjButton8_MouseLeave);
            this.rjButton8.MouseHover += new System.EventHandler(this.rjButton8_MouseHover);
            // 
            // rjButton7
            // 
            this.rjButton7.BackColor = System.Drawing.Color.Transparent;
            this.rjButton7.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton7.BackgroundImage = global::WindowsAppProject.Properties.Resources.icons8_add_properties_48;
            this.rjButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton7.BorderRadius = 15;
            this.rjButton7.BorderSize = 0;
            this.rjButton7.FlatAppearance.BorderSize = 0;
            this.rjButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton7.ForeColor = System.Drawing.Color.White;
            this.rjButton7.Location = new System.Drawing.Point(97, 122);
            this.rjButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(76, 61);
            this.rjButton7.TabIndex = 7;
            this.rjButton7.TextColor = System.Drawing.Color.White;
            this.rjButton7.UseVisualStyleBackColor = false;
            this.rjButton7.Click += new System.EventHandler(this.rjButton7_Click);
            this.rjButton7.MouseLeave += new System.EventHandler(this.rjButton7_MouseLeave);
            this.rjButton7.MouseHover += new System.EventHandler(this.rjButton7_MouseHover);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.Transparent;
            this.rjButton5.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton5.BackgroundImage = global::WindowsAppProject.Properties.Resources.graduating_student;
            this.rjButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 15;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(97, 24);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton5.Size = new System.Drawing.Size(76, 61);
            this.rjButton5.TabIndex = 5;
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click_1);
            this.rjButton5.MouseLeave += new System.EventHandler(this.rjButton_MouseLeave);
            this.rjButton5.MouseHover += new System.EventHandler(this.rjButton_MouseHover);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderRadius = 12;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(56, 536);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(269, 62);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "Admin Panel";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton4.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton4.BorderRadius = 12;
            this.rjButton4.BorderSize = 1;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.Black;
            this.rjButton4.Location = new System.Drawing.Point(56, 692);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(269, 62);
            this.rjButton4.TabIndex = 3;
            this.rjButton4.Text = "Course Dashboard";
            this.rjButton4.TextColor = System.Drawing.Color.Black;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.rjButton3.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton3.BorderRadius = 12;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.Black;
            this.rjButton3.Location = new System.Drawing.Point(56, 613);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(269, 62);
            this.rjButton3.TabIndex = 2;
            this.rjButton3.Text = "Student Dashboard";
            this.rjButton3.TextColor = System.Drawing.Color.Black;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjPanel6
            // 
            this.rjPanel6.AutoSize = true;
            this.rjPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.rjPanel6.BorderRadius = 50;
            this.rjPanel6.Controls.Add(this.rjPanel2);
            this.rjPanel6.Controls.Add(this.rjPanel3);
            this.rjPanel6.ForeColor = System.Drawing.Color.White;
            this.rjPanel6.GradientAngle = 20F;
            this.rjPanel6.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.rjPanel6.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.rjPanel6.Location = new System.Drawing.Point(4, 13);
            this.rjPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.rjPanel6.Name = "rjPanel6";
            this.rjPanel6.Size = new System.Drawing.Size(1730, 939);
            this.rjPanel6.TabIndex = 1;
            // 
            // rjPanel3
            // 
            this.rjPanel3.BackColor = System.Drawing.Color.Black;
            this.rjPanel3.BorderRadius = 20;
            this.rjPanel3.ForeColor = System.Drawing.Color.White;
            this.rjPanel3.GradientAngle = 90F;
            this.rjPanel3.GradientBottomColor = System.Drawing.Color.Black;
            this.rjPanel3.GradientTopColor = System.Drawing.Color.Black;
            this.rjPanel3.Location = new System.Drawing.Point(29, 16);
            this.rjPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(1282, 909);
            this.rjPanel3.TabIndex = 0;
            this.rjPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel3_Paint);
            // 
            // maindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1738, 960);
            this.Controls.Add(this.rjPanel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1760, 1016);
            this.MinimumSize = new System.Drawing.Size(1760, 1016);
            this.Name = "maindashboard";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "maindashboard";
            this.Load += new System.EventHandler(this.maindashboard_Load);
            this.rjPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.rjPanel4.ResumeLayout(false);
            this.rjPanel4.PerformLayout();
            this.rjPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedPanelClass.RJPanel rjPanel3;
        private RoundedPanelClass.RJPanel rjPanel4;
        private RoundedPanelClass.RJPanel rjPanel6;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton8;
        private CustomControls.RJControls.RJButton rjButton7;
        private CustomControls.RJControls.RJButton rjButton6;
        private CustomControls.RJControls.RJButton rjButton5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundedPanelClass.RJPanel rjPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}