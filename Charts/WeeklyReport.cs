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
            initTable();
            initData();
        }

        private void initData() {
            // TODO make the chart and table responsive to the drop-down. 
            // Get the first and the last date
            List<Visitor> sortedVisitors = Utils.visitorsList.OrderBy(v => DateTime.Parse(v.startTime)).ToList();

            if (sortedVisitors.Count > 0)
            {
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
                Dictionary<String, int> weekCount = new Dictionary<string, int>();

                // Include the entirety of the last week as well.
                for (int i = 0; i < numberOfWeeks + 1; i++)
                {
                    DateTime[] mDate = { firstDate.AddDays(i * 7), firstDate.AddDays((i + 1) * 7) };
                    string dateName = mDate[0].ToString("d") + " to " + mDate[1].ToString("d");
                    dateTimes.Add(mDate);
                    weekCount.Add(dateName, 0);
                }

                // Contains the range of week and visitors who visited in that week 
                Dictionary<string, List<Visitor>> weekVisitors = new Dictionary<string, List<Visitor>>();
                foreach (DateTime[] dateTime in dateTimes)
                {
                    List<Visitor> visitors = new List<Visitor>();
                    string dateName = dateTime[0].ToString("d") + " to " + dateTime[1].ToString("d");
                    foreach (Visitor v in sortedVisitors)
                    {
                        if (DateTime.Parse(v.startTime) >= dateTime[0] && DateTime.Parse(v.startTime) < dateTime[1])
                        {
                            weekCount[dateName] = weekCount[dateName] + 1;
                            visitors.Add(v);
                        }
                    }
                    // The weeks have at least 1 visitors are relevant, others can be discarded.
                    if (visitors.Count > 0)
                    {
                        weekVisitors.Add(dateName, visitors);
                    }
                }

                weekCombo.Items.Clear();
                weekCombo.DataSource = weekVisitors.Keys.ToList();

                foreach (KeyValuePair<string, List<Visitor>> item in weekVisitors)
                {
                    System.Diagnostics.Debug.WriteLine(item.Key +" has "+item.Value.Count.ToString());
                }
                

                // Show the data of the latest week
                var chartData = weekVisitors[weekVisitors.Keys.Last()].GroupBy(v => DateTime.Parse(v.startTime).DayOfWeek.ToString().Substring(0, 2)).Select(x => new
                {
                    WeekDay = x.Key,
                    Count = x.Count(),
                });

                var tableData = weekVisitors[weekVisitors.Keys.Last()].GroupBy(v => (int)DateTime.Parse(v.startTime).DayOfWeek).Select(x => new
                {
                    WeekDay = x.Key,
                    Count = x.Count(),
                });

                weeklyDataChart.Series[0].XValueMember = "WeekDay";
                weeklyDataChart.Series[0].YValueMembers = "Count";

                weeklyDataChart.DataSource = chartData;

                foreach (var item in tableData)
                {
                    // TODO add 0 to empty values
                    weeklyDataTable.Controls.Add(new Label() { Text = item.Count.ToString() }, 1, item.WeekDay + 1);

                }
            }
        }
        private void initTable()
        {
            // Columns
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

        }
    }
}