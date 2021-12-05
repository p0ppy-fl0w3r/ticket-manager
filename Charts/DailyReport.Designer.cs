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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dailyAgeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dailyGroupChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ageRadioButton = new System.Windows.Forms.RadioButton();
            this.groupRadioButton = new System.Windows.Forms.RadioButton();
            this.selectionGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dailyAgeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyGroupChart)).BeginInit();
            this.selectionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyAgeChart
            // 
            chartArea5.Name = "ChartArea1";
            this.dailyAgeChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.dailyAgeChart.Legends.Add(legend5);
            this.dailyAgeChart.Location = new System.Drawing.Point(12, 47);
            this.dailyAgeChart.Name = "dailyAgeChart";
            this.dailyAgeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.dailyAgeChart.Series.Add(series5);
            this.dailyAgeChart.Size = new System.Drawing.Size(420, 427);
            this.dailyAgeChart.TabIndex = 0;
            this.dailyAgeChart.Text = "chart1";
            // 
            // dailyGroupChart
            // 
            chartArea6.Name = "ChartArea1";
            this.dailyGroupChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.dailyGroupChart.Legends.Add(legend6);
            this.dailyGroupChart.Location = new System.Drawing.Point(12, 47);
            this.dailyGroupChart.Name = "dailyGroupChart";
            this.dailyGroupChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.dailyGroupChart.Series.Add(series6);
            this.dailyGroupChart.Size = new System.Drawing.Size(420, 427);
            this.dailyGroupChart.TabIndex = 1;
            this.dailyGroupChart.Text = "chart1";
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
            // DailyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 486);
            this.Controls.Add(this.selectionGroup);
            this.Controls.Add(this.dailyGroupChart);
            this.Controls.Add(this.dailyAgeChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyReportForm";
            this.Text = "DailyReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dailyAgeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyGroupChart)).EndInit();
            this.selectionGroup.ResumeLayout(false);
            this.selectionGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart dailyAgeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart dailyGroupChart;
        private System.Windows.Forms.RadioButton ageRadioButton;
        private System.Windows.Forms.RadioButton groupRadioButton;
        private System.Windows.Forms.GroupBox selectionGroup;
    }
}