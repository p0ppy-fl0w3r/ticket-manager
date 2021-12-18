using Coursework.Charts;
using Coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

            // TODO add null and empty value checks on charts
            initVisitorList();

            Utils.navigate(new DailyReport(), chartPanel);
        }

        private void initVisitorList() {
            Utils.visitorsList = Utils.getFromFile<Visitor>(Constants.VISITOR_FILE);
        }

        private void dailyReportButton_Click(object sender, EventArgs e)
        {
            Utils.navigate(new DailyReport(), chartPanel);
        }

        private void weeklyReportButton_Click(object sender, EventArgs e)
        {
            Utils.navigate(new WeeklyReport(), chartPanel);
        }

        private void backImage_Click(object sender, EventArgs e)
        {
            Utils.currentForm = Constants.ADMIN_FORM;
        }

        private void financialReportButton_Click(object sender, EventArgs e)
        {
            Utils.navigate(new FinancialReport(), chartPanel);
        }

        private void backMouseEnter(object sender, EventArgs e)
        {
            backImage.Size = new Size(100+8, 50+4);
        }

        private void backMouseExit(object sender, EventArgs e)
        {
            backImage.Size = new Size(100 , 50);
        }
    }
}
