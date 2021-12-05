namespace Coursework
{
    partial class ReportForm
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
            this.chartPanel = new System.Windows.Forms.Panel();
            this.drawerPanel = new System.Windows.Forms.Panel();
            this.financialReportButton = new System.Windows.Forms.Button();
            this.weeklyReportButton = new System.Windows.Forms.Button();
            this.dailyReportButton = new System.Windows.Forms.Button();
            this.drawerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPanel
            // 
            this.chartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartPanel.Location = new System.Drawing.Point(228, 0);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(444, 486);
            this.chartPanel.TabIndex = 0;
            // 
            // drawerPanel
            // 
            this.drawerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawerPanel.Controls.Add(this.financialReportButton);
            this.drawerPanel.Controls.Add(this.weeklyReportButton);
            this.drawerPanel.Controls.Add(this.dailyReportButton);
            this.drawerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawerPanel.Location = new System.Drawing.Point(0, 0);
            this.drawerPanel.Name = "drawerPanel";
            this.drawerPanel.Size = new System.Drawing.Size(222, 486);
            this.drawerPanel.TabIndex = 1;
            // 
            // financialReportButton
            // 
            this.financialReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.financialReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financialReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialReportButton.Location = new System.Drawing.Point(56, 270);
            this.financialReportButton.Name = "financialReportButton";
            this.financialReportButton.Size = new System.Drawing.Size(111, 95);
            this.financialReportButton.TabIndex = 2;
            this.financialReportButton.Text = "Financial Report";
            this.financialReportButton.UseVisualStyleBackColor = false;
            // 
            // weeklyReportButton
            // 
            this.weeklyReportButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.weeklyReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weeklyReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyReportButton.Location = new System.Drawing.Point(56, 150);
            this.weeklyReportButton.Name = "weeklyReportButton";
            this.weeklyReportButton.Size = new System.Drawing.Size(111, 95);
            this.weeklyReportButton.TabIndex = 1;
            this.weeklyReportButton.Text = "Weekly Report";
            this.weeklyReportButton.UseVisualStyleBackColor = false;
            // 
            // dailyReportButton
            // 
            this.dailyReportButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.dailyReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReportButton.Location = new System.Drawing.Point(56, 28);
            this.dailyReportButton.Name = "dailyReportButton";
            this.dailyReportButton.Size = new System.Drawing.Size(111, 95);
            this.dailyReportButton.TabIndex = 0;
            this.dailyReportButton.Text = "Daily Report";
            this.dailyReportButton.UseVisualStyleBackColor = false;
            this.dailyReportButton.Click += new System.EventHandler(this.dailyReportButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 486);
            this.Controls.Add(this.drawerPanel);
            this.Controls.Add(this.chartPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.drawerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Panel drawerPanel;
        private System.Windows.Forms.Button financialReportButton;
        private System.Windows.Forms.Button weeklyReportButton;
        private System.Windows.Forms.Button dailyReportButton;
    }
}