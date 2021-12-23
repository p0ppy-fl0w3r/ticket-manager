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
            setTableData(weekCombo.SelectedItem.ToString(), null);
            setChartData(weekCombo.SelectedItem.ToString(), false);
        }

        private class WeekData
        {
            public string WeekDay { get; set; }
            public int Count { get; set; }
            public double Income { get; set; }
        }

        // TODO write doc comment
        private void setTableData(string dateValue, bool? sortByIncome)
        {
            var tableData = weekVisitors[dateValue].GroupBy(v => (int)DateTime.Parse(v.startTime).DayOfWeek).Select(x => new
            {
                WeekDayNum = x.Key,
                Count = x.Count(),
                Income = x.Sum(v => v.checkoutPrice)
            });

            weeklyDataTable.Controls.Clear();
            initTable();

            List<WeekData> weekTableData = new List<WeekData>();


            // Get the weekly visitor data
            int totalVisitor = 0;
            double totalIncome = 0;
            for (int i = 0; i < 7; i++)
            {
                WeekData weekData = new WeekData();
                weekData.WeekDay = ((DayOfWeek)i).ToString();

                int count = 0;
                double income = 0.0;
                // Set the count to number of visitors in that particular day of the week.
                var visitorData = tableData.Where(x => x.WeekDayNum == (i)).ElementAtOrDefault(0);
                if (visitorData != null)
                {
                    count = visitorData.Count;
                    income = visitorData.Income;

                }

                weekData.Income = income;
                weekData.Count = count;

                totalVisitor += count;
                totalIncome += income;

                weekTableData.Add(weekData);
            }

            if (sortByIncome != null)
            {
                mergeSort(weekTableData, (bool)sortByIncome);
            }

            // Display the weekly visitor data in table.
            for (int i = 0; i < weekTableData.Count; i++)
            {
                weeklyDataTable.Controls.Add(new Label() { Text = weekTableData[i].WeekDay }, 0, 1 + i);
                weeklyDataTable.Controls.Add(new Label() { Text = weekTableData[i].Count.ToString(), AutoSize = true }, 1, i + 1);
                weeklyDataTable.Controls.Add(new Label() { Text = weekTableData[i].Income.ToString(), AutoSize = true }, 2, i + 1);
            }

            weeklyDataTable.Controls.Add(new Label() { Text = "Grand Total: ", Font = boldFont, AutoSize = true }, 0, 8);
            weeklyDataTable.Controls.Add(new Label() { Text = totalVisitor.ToString(), Font = boldFont, AutoSize = true }, 1, 8);
            weeklyDataTable.Controls.Add(new Label() { Text = totalIncome.ToString(), Font = boldFont, AutoSize = true }, 2, 8);
        }

        // TODO write doc comment.
        private void setChartData(string dateValue, bool isIncome)
        {
            var chartData = weekVisitors[dateValue].GroupBy(v => DateTime.Parse(v.startTime).DayOfWeek.ToString().Substring(0, 2)).Select(x => new
            {
                WeekDay = x.Key,
                Count = x.Count(),
                Income = x.Sum(v => v.checkoutPrice)
            });

            weeklyDataChart.Series[0].XValueMember = "WeekDay";
            weeklyDataChart.Series[0].YValueMembers = isIncome ? "Income" : "Count";

            weeklyDataChart.Series[0].Name = isIncome ? "Total Income" : "No. Visitors";
            weeklyDataChart.Series[0].Color = isIncome ? Color.MediumTurquoise : Color.Crimson;


            weeklyDataChart.DataSource = chartData;
            weeklyDataChart.DataBind();
        }

        private void sortIndexChanged(object sender, EventArgs e)
        {
            // Running the program in debug mode will cause the application to stop here if there's no visitor data. 
            try
            {
                if (sortCombo.SelectedIndex == 0)
                {
                    // Sort by number of visitors
                    setTableData(weekCombo.SelectedItem.ToString(), false);
                }
                else if (sortCombo.SelectedIndex == 1)
                {
                    // Sort by total income
                    setTableData(weekCombo.SelectedItem.ToString(), true);
                }
                else
                {
                    setTableData(weekCombo.SelectedItem.ToString(), null);
                }
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("The visitor data is missing. Make sure there's at least one visitor's data.", "Data Missing.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // TODO write doc comment
        private static void mergeSort(List<WeekData> arr, bool isIncome)
        {
            if (arr.Count == 1)
            {
                return;
            }

            List<WeekData> left = arr.Take(arr.Count / 2).ToList();
            List<WeekData> right = arr.Skip(left.Count).ToList();

            mergeSort(left, isIncome);
            mergeSort(right, isIncome);
            merge(left, right, arr, isIncome);
        }

        private static void merge(List<WeekData> left, List<WeekData> right, List<WeekData> list, bool isIncome)
        {
            int indexLeft = 0;
            int indexRight = 0;
            int indexList = 0;

            while (indexLeft < left.Count && indexRight < right.Count)
            {
                if ((isIncome ? left[indexLeft].Income : left[indexLeft].Count) > (isIncome ? right[indexRight].Income : right[indexRight].Count))
                {
                    list[indexList] = left[indexLeft];
                    indexLeft++;
                }
                else
                {
                    list[indexList] = right[indexRight];
                    indexRight++;
                }
                indexList++;
            }

            while (indexLeft < left.Count)
            {
                list[indexList] = left[indexLeft];
                indexLeft++;
                indexList++;
            }

            while (indexRight < right.Count)
            {
                list[indexList] = right[indexRight];
                indexRight++;
                indexList++;
            }
        }

        private void chartDoubleClick(object sender, EventArgs e)
        {
            if (weeklyDataChart.Series[0].YValueMembers == "Income")
            {
                setChartData(weekCombo.SelectedItem.ToString(), false);
            }
            else
            {
                setChartData(weekCombo.SelectedItem.ToString(), true);
            }

        }
    }
}