namespace Coursework.Charts
{
    partial class DailyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dailyAgeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dailyGroupChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ageRadioButton = new System.Windows.Forms.RadioButton();
            this.groupRadioButton = new System.Windows.Forms.RadioButton();
            this.selectionGroup = new System.Windows.Forms.GroupBox();
            this.dateCombo = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dailyAgeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyGroupChart)).BeginInit();
            this.selectionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyAgeChart
            // 
            this.dailyAgeChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.dailyAgeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dailyAgeChart.Legends.Add(legend1);
            this.dailyAgeChart.Location = new System.Drawing.Point(12, 74);
            this.dailyAgeChart.Name = "dailyAgeChart";
            this.dailyAgeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Age Group";
            this.dailyAgeChart.Series.Add(series1);
            this.dailyAgeChart.Size = new System.Drawing.Size(420, 400);
            this.dailyAgeChart.TabIndex = 0;
            this.dailyAgeChart.Text = "chart1";
            // 
            // dailyGroupChart
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.dailyGroupChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dailyGroupChart.Legends.Add(legend2);
            this.dailyGroupChart.Location = new System.Drawing.Point(12, 74);
            this.dailyGroupChart.Name = "dailyGroupChart";
            this.dailyGroupChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Group";
            this.dailyGroupChart.Series.Add(series2);
            this.dailyGroupChart.Size = new System.Drawing.Size(420, 400);
            this.dailyGroupChart.TabIndex = 1;
            // 
            // ageRadioButton
            // 
            this.ageRadioButton.AutoSize = true;
            this.ageRadioButton.Location = new System.Drawing.Point(75, 5);
            this.ageRadioButton.Name = "ageRadioButton";
            this.ageRadioButton.Size = new System.Drawing.Size(44, 17);
            this.ageRadioButton.TabIndex = 2;
            this.ageRadioButton.Text = "Age";
            this.ageRadioButton.UseVisualStyleBackColor = true;
            this.ageRadioButton.CheckedChanged += new System.EventHandler(this.radioCheckChanged);
            // 
            // groupRadioButton
            // 
            this.groupRadioButton.AutoSize = true;
            this.groupRadioButton.Checked = true;
            this.groupRadioButton.Location = new System.Drawing.Point(125, 5);
            this.groupRadioButton.Name = "groupRadioButton";
            this.groupRadioButton.Size = new System.Drawing.Size(54, 17);
            this.groupRadioButton.TabIndex = 3;
            this.groupRadioButton.TabStop = true;
            this.groupRadioButton.Text = "Group";
            this.groupRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectionGroup
            // 
            this.selectionGroup.Controls.Add(this.ageRadioButton);
            this.selectionGroup.Controls.Add(this.groupRadioButton);
            this.selectionGroup.Location = new System.Drawing.Point(253, 13);
            this.selectionGroup.Name = "selectionGroup";
            this.selectionGroup.Size = new System.Drawing.Size(179, 28);
            this.selectionGroup.TabIndex = 4;
            this.selectionGroup.TabStop = false;
            // 
            // dateCombo
            // 
            this.dateCombo.FormattingEnabled = true;
            this.dateCombo.Location = new System.Drawing.Point(55, 20);
            this.dateCombo.Name = "dateCombo";
            this.dateCombo.Size = new System.Drawing.Size(121, 21);
            this.dateCombo.TabIndex = 5;
            this.dateCombo.SelectedIndexChanged += new System.EventHandler(this.dateItemChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 26);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(37, 15);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date";
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 486);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateCombo);
            this.Controls.Add(this.selectionGroup);
            this.Controls.Add(this.dailyGroupChart);
            this.Controls.Add(this.dailyAgeChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyReport";
            this.Text = "DailyReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dailyAgeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyGroupChart)).EndInit();
            this.selectionGroup.ResumeLayout(false);
            this.selectionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart dailyAgeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart dailyGroupChart;
        private System.Windows.Forms.RadioButton ageRadioButton;
        private System.Windows.Forms.RadioButton groupRadioButton;
        private System.Windows.Forms.GroupBox selectionGroup;
        private System.Windows.Forms.ComboBox dateCombo;
        private System.Windows.Forms.Label dateLabel;
    }
}