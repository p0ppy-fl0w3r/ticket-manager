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
            this.sortCombo = new System.Windows.Forms.ComboBox();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.weekLabel = new System.Windows.Forms.Label();
            this.weekCombo = new System.Windows.Forms.ComboBox();
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
            series1.Name = "No. Visitors";
            this.weeklyDataChart.Series.Add(series1);
            this.weeklyDataChart.Size = new System.Drawing.Size(420, 224);
            this.weeklyDataChart.TabIndex = 0;
            this.weeklyDataChart.Text = "Weekly Report Chart";
            // 
            // weeklyDataTable
            // 
            this.weeklyDataTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.weeklyDataTable.ColumnCount = 3;
            this.weeklyDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.49502F));
            this.weeklyDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.50498F));
            this.weeklyDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.weeklyDataTable.Location = new System.Drawing.Point(12, 287);
            this.weeklyDataTable.Name = "weeklyDataTable";
            this.weeklyDataTable.RowCount = 9;
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weeklyDataTable.Size = new System.Drawing.Size(420, 193);
            this.weeklyDataTable.TabIndex = 1;
            // 
            // sortCombo
            // 
            this.sortCombo.FormattingEnabled = true;
            this.sortCombo.Items.AddRange(new object[] {
            "Number Of Visitors",
            "Income"});
            this.sortCombo.Location = new System.Drawing.Point(311, 247);
            this.sortCombo.Name = "sortCombo";
            this.sortCombo.Size = new System.Drawing.Size(121, 21);
            this.sortCombo.TabIndex = 2;
            this.sortCombo.SelectedIndexChanged += new System.EventHandler(this.sortIndexChanged);
            // 
            // sortByLabel
            // 
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Location = new System.Drawing.Point(250, 250);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(41, 13);
            this.sortByLabel.TabIndex = 3;
            this.sortByLabel.Text = "Sort By";
            // 
            // weekLabel
            // 
            this.weekLabel.AutoSize = true;
            this.weekLabel.Location = new System.Drawing.Point(12, 250);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(36, 13);
            this.weekLabel.TabIndex = 5;
            this.weekLabel.Text = "Week";
            // 
            // weekCombo
            // 
            this.weekCombo.FormattingEnabled = true;
            this.weekCombo.Location = new System.Drawing.Point(54, 247);
            this.weekCombo.Name = "weekCombo";
            this.weekCombo.Size = new System.Drawing.Size(172, 21);
            this.weekCombo.TabIndex = 4;
            this.weekCombo.SelectedValueChanged += new System.EventHandler(this.weekValueChanged);
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 486);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.weekCombo);
            this.Controls.Add(this.sortByLabel);
            this.Controls.Add(this.sortCombo);
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
        private System.Windows.Forms.ComboBox sortCombo;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.ComboBox weekCombo;
    }
}