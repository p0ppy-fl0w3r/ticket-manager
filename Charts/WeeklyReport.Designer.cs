namespace Coursework.Charts
{
    partial class WeeklyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.weeklyDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weeklyDataTable = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sortByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyDataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklyDataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.weeklyDataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weeklyDataChart.Legends.Add(legend1);
            this.weeklyDataChart.Location = new System.Drawing.Point(12, 12);
            this.weeklyDataChart.Name = "weeklyDataChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.weeklyDataChart.Series.Add(series1);
            this.weeklyDataChart.Size = new System.Drawing.Size(420, 224);
            this.weeklyDataChart.TabIndex = 0;
            this.weeklyDataChart.Text = "chart1";
            // 
            // weeklyDataTable
            // 
            this.weeklyDataTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.weeklyDataTable.ColumnCount = 3;
            this.weeklyDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.49512F));
            this.weeklyDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.50489F));
            this.weeklyDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.weeklyDataTable.Location = new System.Drawing.Point(12, 287);
            this.weeklyDataTable.Name = "weeklyDataTable";
            this.weeklyDataTable.RowCount = 8;
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.Size = new System.Drawing.Size(420, 175);
            this.weeklyDataTable.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Number Of Visitors",
            "Income"});
            this.comboBox1.Location = new System.Drawing.Point(311, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // sortByLabel
            // 
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Location = new System.Drawing.Point(224, 258);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(41, 13);
            this.sortByLabel.TabIndex = 3;
            this.sortByLabel.Text = "Sort By";
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 486);
            this.Controls.Add(this.sortByLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.weeklyDataTable);
            this.Controls.Add(this.weeklyDataChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            ((System.ComponentModel.ISupportInitialize)(this.weeklyDataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyDataChart;
        private System.Windows.Forms.TableLayoutPanel weeklyDataTable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label sortByLabel;
    }
}