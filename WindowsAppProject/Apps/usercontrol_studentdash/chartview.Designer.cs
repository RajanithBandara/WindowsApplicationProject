namespace WindowsAppProject.Apps.usercontrol_studentdash
{
    partial class chartview
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btngenerate = new CustomControls.RJControls.RJButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.studentprogessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprogessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btngenerate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btngenerate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btngenerate.BorderRadius = 0;
            this.btngenerate.BorderSize = 0;
            this.btngenerate.FlatAppearance.BorderSize = 0;
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerate.ForeColor = System.Drawing.Color.White;
            this.btngenerate.Location = new System.Drawing.Point(642, 451);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(150, 40);
            this.btngenerate.TabIndex = 0;
            this.btngenerate.Text = "Generate";
            this.btngenerate.TextColor = System.Drawing.Color.White;
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.sem1DataGridViewTextBoxColumn,
            this.sem2DataGridViewTextBoxColumn,
            this.sem3DataGridViewTextBoxColumn,
            this.sem4DataGridViewTextBoxColumn,
            this.sem5DataGridViewTextBoxColumn,
            this.sem6DataGridViewTextBoxColumn,
            this.sem7DataGridViewTextBoxColumn,
            this.sem8DataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.studentprogessBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(10, 299);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(809, 140);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // chart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(10, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(809, 281);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // studentprogessBindingSource
            // 
            this.studentprogessBindingSource.DataSource = typeof(WindowsAppProject.Apps.students_chart.student_progess);
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // sem1DataGridViewTextBoxColumn
            // 
            this.sem1DataGridViewTextBoxColumn.DataPropertyName = "sem1";
            this.sem1DataGridViewTextBoxColumn.HeaderText = "sem1";
            this.sem1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sem1DataGridViewTextBoxColumn.Name = "sem1DataGridViewTextBoxColumn";
            this.sem1DataGridViewTextBoxColumn.Width = 125;
            // 
            // sem2DataGridViewTextBoxColumn
            // 
            this.sem2DataGridViewTextBoxColumn.DataPropertyName = "sem2";
            this.sem2DataGridViewTextBoxColumn.HeaderText = "sem2";
            this.sem2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sem2DataGridViewTextBoxColumn.Name = "sem2DataGridViewTextBoxColumn";
            this.sem2DataGridViewTextBoxColumn.Width = 125;
            // 
            // sem3DataGridViewTextBoxColumn
            // 
            this.sem3DataGridViewTextBoxColumn.DataPropertyName = "sem3";
            this.sem3DataGridViewTextBoxColumn.HeaderText = "sem3";
            this.sem3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sem3DataGridViewTextBoxColumn.Name = "sem3DataGridViewTextBoxColumn";
            this.sem3DataGridViewTextBoxColumn.Width = 125;
            // 
            // sem4DataGridViewTextBoxColumn
            // 
            this.sem4DataGridViewTextBoxColumn.DataPropertyName = "sem4";
            this.sem4DataGridViewTextBoxColumn.HeaderText = "sem4";
            this.sem4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sem4DataGridViewTextBoxColumn.Name = "sem4DataGridViewTextBoxColumn";
            this.sem4DataGridViewTextBoxColumn.Width = 125;
            // 
            // sem5DataGridViewTextBoxColumn
            // 
            this.sem5DataGridViewTextBoxColumn.DataPropertyName = "sem5";
            this.sem5DataGridViewTextBoxColumn.HeaderText = "sem5";
            this.sem5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sem5DataGridViewTextBoxColumn.Name = "sem5DataGridViewTextBoxColumn";
            this.sem5DataGridViewTextBoxColumn.Width = 125;
            // 
            // sem6DataGridViewTextBoxColumn
            // 
            this.sem6DataGridViewTextBoxColumn.DataPropertyName = "sem6";
            this.sem6DataGridViewTextBoxColumn.HeaderText = "sem6";
            this.sem6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sem6DataGridViewTextBoxColumn.Name = "sem6DataGridViewTextBoxColumn";
            this.sem6DataGridViewTextBoxColumn.Width = 125;
            // 
            // sem7DataGridViewTextBoxColumn
            // 
            this.sem7DataGridViewTextBoxColumn.DataPropertyName = "sem7";
            this.sem7DataGridViewTextBoxColumn.HeaderText = "sem7";
            this.sem7DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sem7DataGridViewTextBoxColumn.Name = "sem7DataGridViewTextBoxColumn";
            this.sem7DataGridViewTextBoxColumn.Width = 125;
            // 
            // sem8DataGridViewTextBoxColumn
            // 
            this.sem8DataGridViewTextBoxColumn.DataPropertyName = "sem8";
            this.sem8DataGridViewTextBoxColumn.HeaderText = "sem8";
            this.sem8DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sem8DataGridViewTextBoxColumn.Name = "sem8DataGridViewTextBoxColumn";
            this.sem8DataGridViewTextBoxColumn.Width = 125;
            // 
            // chartview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btngenerate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "chartview";
            this.Size = new System.Drawing.Size(830, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprogessBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton btngenerate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem8DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentprogessBindingSource;
    }
}
