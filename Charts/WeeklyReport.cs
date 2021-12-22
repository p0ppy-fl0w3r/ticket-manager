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

        Font boldFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);

        Dictionary<string, List<Visitor>> weekVisitors;
        public WeeklyReport()
        {
            InitializeComponent();
            initTable();
            initData();
        }

        private void initData()
        {
            // TODO add sorting
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
                weekVisitors = new Dictionary<string, List<Visitor>>();
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
                    // The weeks that have at least 1 visitors are relevant, others can be discarded.
                    if (visitors.Count > 0)
                    {
                        weekVisitors.Add(dateName, visitors);
                    }
                }

                // Set the ranges of the weeks as the items in drop-down list. 
                weekCombo.Items.Clear();
                weekCombo.DataSource = weekVisitors.Keys.ToList();


                // Show the data of the latest week in chart and table.
                weekCombo.SelectedIndex = weekVisitors.Count - 1;
            }
        }
        private void initTable()
        {
            // Columns
            weeklyDataTable.Controls.Add(new Label() { Text = "Day of the week", Font = boldFont, AutoSize = true });
            weeklyDataTable.Controls.Add(new Label() { Text = "Number of Visitors", Font = boldFont, AutoSize = true });
            weeklyDataTable.Controls.Add(new Label() { Text = "Total Income", Font = boldFont, AutoSize = true });

        }

        private void weekValueChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("The value was changed to " + weekCombo.SelectedItem.ToString());

            setTableData(weekCombo.SelectedItem.ToString());
            setChartData(weekCombo.SelectedItem.ToString());
        }

        private void setTableData(string dateValue)
        {
            var tableData = weekVisitors[dateValue].GroupBy(v => (int)DateTime.Parse(v.startTime).DayOfWeek).Select(x => new
            {
                WeekDay = x.Key,
                Count = x.Count(),
                Income = x.Sum(v => v.checkoutPrice)
            });

            weeklyDataTable.Controls.Clear();
            initTable();

            int totalVisitor = 0;
            double totalIncome = 0;
            for (int i = 0; i < 7; i++)
            {
                weeklyDataTable.Controls.Add(new Label() { Text = ((DayOfWeek)i).ToString() }, 0, 1 + i);

                int count = 0;
                double income = 0.0;
                // Set the count to number of visitors in that particular day of the week.
                var visitorData = tableData.Where(x => x.WeekDay == (i)).ElementAtOrDefault(0);
                if (visitorData != null)
                {
                    count = visitorData.Count;
                    income = visitorData.Income;
                }
                totalVisitor += count;
                totalIncome += income;

                weeklyDataTable.Controls.Add(new Label() { Text = count.ToString(), AutoSize = true }, 1, i + 1);
                weeklyDataTable.Controls.Add(new Label() { Text = income.ToString(), AutoSize = true }, 2, i + 1);
            }


            weeklyDataTable.Controls.Add(new Label() { Text = "Grand Total: ", Font = boldFont, AutoSize = true }, 0, 8);
            weeklyDataTable.Controls.Add(new Label() { Text = totalVisitor.ToString(), Font = boldFont, AutoSize = true }, 1, 8);
            weeklyDataTable.Controls.Add(new Label() { Text = totalIncome.ToString(), Font = boldFont, AutoSize = true }, 2, 8);
        }

        private void setChartData(string dateValue)
        {
            var chartData = weekVisitors[dateValue].GroupBy(v => DateTime.Parse(v.startTime).DayOfWeek.ToString().Substring(0, 2)).Select(x => new
            {
                WeekDay = x.Key,
                Count = x.Count(),
            });

            weeklyDataChart.Series[0].XValueMember = "WeekDay";
            weeklyDataChart.Series[0].YValueMembers = "Count";

            weeklyDataChart.DataSource = chartData;
            weeklyDataChart.DataBind();
        }

        private void sortIndexChanged(object sender, EventArgs e)
        {
            // TODO change chart series name
            // TODO sort the table
            // TODO see coursework guidelines no.3(page 4)
        }
    }
}