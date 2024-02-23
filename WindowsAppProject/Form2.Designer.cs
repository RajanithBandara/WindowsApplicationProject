namespace practice_project
{
    partial class Form2
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
            this.textbxpanel = new System.Windows.Forms.Panel();
            this.Mgrade = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MName = new System.Windows.Forms.Panel();
            this.Mcredits = new System.Windows.Forms.Panel();
            this.addMod = new System.Windows.Forms.Button();
            this.removeMod = new System.Windows.Forms.Button();
            this.textbxpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textbxpanel
            // 
            this.textbxpanel.Controls.Add(this.Mgrade);
            this.textbxpanel.Location = new System.Drawing.Point(48, 105);
            this.textbxpanel.Name = "textbxpanel";
            this.textbxpanel.Size = new System.Drawing.Size(669, 278);
            this.textbxpanel.TabIndex = 1;
            this.textbxpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.textbxpanel_Paint);
            // 
            // Mgrade
            // 
            this.Mgrade.Location = new System.Drawing.Point(313, 3);
            this.Mgrade.Name = "Mgrade";
            this.Mgrade.Size = new System.Drawing.Size(163, 275);
            this.Mgrade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Credits";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MName
            // 
            this.MName.Location = new System.Drawing.Point(51, 108);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(275, 275);
            this.MName.TabIndex = 2;
            // 
            // Mcredits
            // 
            this.Mcredits.Location = new System.Drawing.Point(557, 108);
            this.Mcredits.Name = "Mcredits";
            this.Mcredits.Size = new System.Drawing.Size(157, 272);
            this.Mcredits.TabIndex = 0;
            // 
            // addMod
            // 
            this.addMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMod.Location = new System.Drawing.Point(124, 398);
            this.addMod.Name = "addMod";
            this.addMod.Size = new System.Drawing.Size(225, 40);
            this.addMod.TabIndex = 3;
            this.addMod.Text = "Add Module";
            this.addMod.UseVisualStyleBackColor = true;
            this.addMod.Click += new System.EventHandler(this.addMod_Click_1);
            // 
            // removeMod
            // 
            this.removeMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMod.Location = new System.Drawing.Point(441, 398);
            this.removeMod.Name = "removeMod";
            this.removeMod.Size = new System.Drawing.Size(230, 40);
            this.removeMod.TabIndex = 3;
            this.removeMod.Text = "Remove Module";
            this.removeMod.UseVisualStyleBackColor = true;
            this.removeMod.Click += new System.EventHandler(this.removeMod_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeMod);
            this.Controls.Add(this.addMod);
            this.Controls.Add(this.Mcredits);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbxpanel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.textbxpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel textbxpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel MName;
        private System.Windows.Forms.Panel Mgrade;
        private System.Windows.Forms.Panel Mcredits;
        private System.Windows.Forms.Button addMod;
        private System.Windows.Forms.Button removeMod;
    }
}