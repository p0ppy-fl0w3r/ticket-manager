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
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();

            // TODO add styles to labels
            weeklyDataTable.Controls.Add(new Label() { Text = "Day of the week."});
            weeklyDataTable.Controls.Add(new Label() { Text = "Number of Visitors"});
            weeklyDataTable.Controls.Add(new Label() { Text = "Total Income"});

            // Rows
            weeklyDataTable.Controls.Add(new Label() { Text = "Sunday"}, 0,1);
            weeklyDataTable.Controls.Add(new Label() { Text = "Monday"}, 0,2);
            weeklyDataTable.Controls.Add(new Label() { Text = "Tuesday"}, 0,3);
            weeklyDataTable.Controls.Add(new Label() { Text = "Wednesday"}, 0,4);
            weeklyDataTable.Controls.Add(new Label() { Text = "Thursday"}, 0,5);
            weeklyDataTable.Controls.Add(new Label() { Text = "Friday"}, 0,6);
            weeklyDataTable.Controls.Add(new Label() { Text = "Saturday"}, 0,7);
        }
    }
}
