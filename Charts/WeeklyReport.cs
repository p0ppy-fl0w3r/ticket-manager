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

namespace Coursework.Charts
{
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();

            // Get the first and the last date
            List<Visitor> sortedVisitors = Utils.visitorsList.OrderBy(v => DateTime.Parse(v.startTime)).ToList();

            // TODO add empty value/null check
            DateTime firstDate = DateTime.Parse(sortedVisitors[0].startTime);
            DateTime lastDate = DateTime.Parse(sortedVisitors.Last().startTime);

            while (firstDate.DayOfWeek != DayOfWeek.Sunday)
            {
                firstDate = firstDate.AddDays(-1);
            }

            while (lastDate.DayOfWeek != DayOfWeek.Saturday)
            {
                lastDate = lastDate.AddDays(1);
            }

            // Create a list of range of weeks.
            int numberOfWeeks = lastDate.Subtract(firstDate).Days / 7;

            List<DateTime[]> dateTimes = new List<DateTime[]>();
            Dictionary<String, int> weekCount = new Dictionary<String, int>();

            // FIXME this might be redundant
            // Include the entirety of the last week as well.
            for (int i = 0; i < numberOfWeeks+1; i++)
            {
                DateTime[] mDate = {firstDate.AddDays(i*7), firstDate.AddDays((i+1)*7) };
                String dateName = mDate[0].ToString("d")+" to "+mDate[1].ToString("d");
                dateTimes.Add(mDate);
                weekCount.Add(dateName,0); 
            }

            // Contains the range of week and visitors who visited in that week 
            Dictionary<String, List<Visitor>> weekVisitors = new Dictionary<String, List<Visitor>>();
            foreach (DateTime[] dateTime in dateTimes)
            {
                List<Visitor> visitors = new List<Visitor>();
                String dateName = dateTime[0].ToString("d") + " to " + dateTime[1].ToString("d");
                foreach (Visitor v in sortedVisitors)
                {
                    if (DateTime.Parse(v.startTime) >= dateTime[0] && DateTime.Parse(v.startTime) < dateTime[1])
                    {
                        weekCount[dateName] = weekCount[dateName] + 1;
                        visitors.Add(v);
                    }
                }
                weekVisitors.Add(dateName,visitors);
            }

            weekCombo.Items.Clear();
            weekCombo.DataSource = weekCount.Keys.ToList();

            // DEBUG
            var chartData  = weekVisitors["12/12/2021 to 12/19/2021"].GroupBy(v => DateTime.Parse(v.startTime).DayOfWeek.ToString().Substring(0,2)).Select(x => new { 
                WeekDay = x.Key,
                Count = x.Count(),
            });

            var tableData = weekVisitors["12/12/2021 to 12/19/2021"].GroupBy(v => (int)DateTime.Parse(v.startTime).DayOfWeek).Select(x => new {
                WeekDay = x.Key,
                Count = x.Count(),
            });

            weeklyDataChart.Series[0].XValueMember = "WeekDay";
            weeklyDataChart.Series[0].YValueMembers = "Count";

            weeklyDataChart.DataSource = chartData;

            // DEBUG
            foreach (KeyValuePair<String, int> week in weekCount)
            {
                System.Diagnostics.Debug.WriteLine(week.Key+" "+week.Value);
            }

            // TODO add styles to labels
            weeklyDataTable.Controls.Add(new Label() { Text = "Day of the week." });
            weeklyDataTable.Controls.Add(new Label() { Text = "Number of Visitors" });
            weeklyDataTable.Controls.Add(new Label() { Text = "Total Income" });

            // Rows
            weeklyDataTable.Controls.Add(new Label() { Text = "Sunday" }, 0, 1);
            weeklyDataTable.Controls.Add(new Label() { Text = "Monday" }, 0, 2);
            weeklyDataTable.Controls.Add(new Label() { Text = "Tuesday" }, 0, 3);
            weeklyDataTable.Controls.Add(new Label() { Text = "Wednesday" }, 0, 4);
            weeklyDataTable.Controls.Add(new Label() { Text = "Thursday" }, 0, 5);
            weeklyDataTable.Controls.Add(new Label() { Text = "Friday" }, 0, 6);
            weeklyDataTable.Controls.Add(new Label() { Text = "Saturday" }, 0, 7);

            // DEBUG
            foreach (var item in tableData)
            {
                weeklyDataTable.Controls.Add(new Label() { Text = item.Count.ToString() }, 1, item.WeekDay+1);
                
            }
        }
    }
}