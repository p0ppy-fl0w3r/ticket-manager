using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Charts
{
    public partial class DailyReportForm : Form
    {
        public DailyReportForm()
        {
            InitializeComponent();
        }

        private void radioCheckChanged(object sender, EventArgs e)
        {
            if (ageRadioButton.Checked)
            {
                dailyGroupChart.Visible = false;
                dailyAgeChart.Visible = true;
            }
            else {
                dailyGroupChart.Visible = true;
                dailyAgeChart.Visible = false;
            }
        }
    }
}
