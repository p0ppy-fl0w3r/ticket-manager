namespace Coursework.Charts
{
    partial class FinancialReport
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
            this.todayIncomeLabel = new System.Windows.Forms.Label();
            this.weekIncomeLabel = new System.Windows.Forms.Label();
            this.monthIncomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // todayIncomeLabel
            // 
            this.todayIncomeLabel.AutoSize = true;
            this.todayIncomeLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.todayIncomeLabel.Location = new System.Drawing.Point(52, 61);
            this.todayIncomeLabel.Name = "todayIncomeLabel";
            this.todayIncomeLabel.Size = new System.Drawing.Size(115, 24);
            this.todayIncomeLabel.TabIndex = 16;
            this.todayIncomeLabel.Text = "Today\'s Income :";
            // 
            // weekIncomeLabel
            // 
            this.weekIncomeLabel.AutoSize = true;
            this.weekIncomeLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.weekIncomeLabel.Location = new System.Drawing.Point(30, 94);
            this.weekIncomeLabel.Name = "weekIncomeLabel";
            this.weekIncomeLabel.Size = new System.Drawing.Size(142, 24);
            this.weekIncomeLabel.TabIndex = 17;
            this.weekIncomeLabel.Text = "This week\'s income : ";
            // 
            // monthIncomeLabel
            // 
            this.monthIncomeLabel.AutoSize = true;
            this.monthIncomeLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.monthIncomeLabel.Location = new System.Drawing.Point(20, 133);
            this.monthIncomeLabel.Name = "monthIncomeLabel";
            this.monthIncomeLabel.Size = new System.Drawing.Size(152, 24);
            this.monthIncomeLabel.TabIndex = 18;
            this.monthIncomeLabel.Text = "This month\'s income : ";
            // 
            // FinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 486);
            this.Controls.Add(this.monthIncomeLabel);
            this.Controls.Add(this.weekIncomeLabel);
            this.Controls.Add(this.todayIncomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinancialReport";
            this.Text = "FinancialReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todayIncomeLabel;
        private System.Windows.Forms.Label weekIncomeLabel;
        private System.Windows.Forms.Label monthIncomeLabel;
    }
}