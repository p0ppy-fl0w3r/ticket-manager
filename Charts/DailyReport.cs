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
    public partial class DailyReport : Form
    {

        private Font boldFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);

        private Dictionary<string, int> ageRangeDict;
        private Dictionary<string, int> groupRangeDict;
        public DailyReport()
        {
            InitializeComponent();

            ageRangeDict = new Dictionary<string, int>();
            groupRangeDict = new Dictionary<string, int>();

            setDateComboItems();

            if (dateCombo.Items.Count > 0)
            {
                dateCombo.SelectedIndex = 0;
            }
        }
        private void radioCheckChanged(object sender, EventArgs e)
        {
            if (ageRadioButton.Checked)
            {
                dailyGroupChart.Visible = false;
                dailyAgeChart.Visible = true;
                if (dateCombo.SelectedItem == null)
                {
                    setAgeData(DateTime.Now.ToString(Constants.DATE_FORMAT));
                }
                else
                {
                    setAgeData(dateCombo.SelectedItem.ToString());
                }

            }
            else
            {
                dailyGroupChart.Visible = true;
                dailyAgeChart.Visible = false;

                if (dateCombo.SelectedItem == null)
                {
                    setGroupData(DateTime.Now.ToString(Constants.DATE_FORMAT));
                }
                else
                {
                    setGroupData(dateCombo.SelectedItem.ToString());
                }
            }
        }

        private void setDateComboItems()
        {
            List<String> dateItems = Utils.visitorsList.Select(x => getDateFormatted(x)).ToList();

            dateCombo.DataSource = dateItems.ToHashSet<String>().ToList();
        }

        private String getDateFormatted(Visitor visitor)
        {
            return DateTime.Parse(visitor.startTime).ToString(Constants.DATE_FORMAT);
        }

        private void setGroupData(String requiredDate)
        {
            groupRangeDict.Clear();
            groupRangeDict.Add("0-4", 0);
            groupRangeDict.Add("5-9", 0);
            groupRangeDict.Add("10-15", 0);
            groupRangeDict.Add("15+", 0);

            var groupCount = Utils.visitorsList.Where(v => getDateFormatted(v) == requiredDate)
                .Where(x => x.groupId != Constants.NO_GROUP)
                .GroupBy(visitor => visitor.groupId)
                .Select(
                    groupedVisitor => new { ID = groupedVisitor.Key, Count = groupedVisitor.Count() }
                );

            int singleVisitor = Utils.visitorsList.Where(v => getDateFormatted(v) == requiredDate).Where(x => x.groupId == Constants.NO_GROUP).Count();
            groupRangeDict["0-4"] = singleVisitor;

            foreach (var item in groupCount)
            {
                if (item.Count < 5)
                {
                    groupRangeDict["0-4"] = groupRangeDict["0-4"] + 1;
                }
                else if (item.Count >= 5 && item.Count < 10)
                {
                    groupRangeDict["5-9"] = groupRangeDict["5-9"] + 1;
                }
                else if (item.Count >= 10 && item.Count < 15)
                {
                    groupRangeDict["10-15"] = groupRangeDict["10-15"] + 1;
                }
                else
                {
                    groupRangeDict["15+"] = groupRangeDict["15+"] + 1;
                }
            }

            var rarngedGroup = groupRangeDict.Select(n => new
            {
                Group = n.Key,
                Count = n.Value
            });


            reportTable.Controls.Clear();
            reportTable.RowCount = 6;

            reportTable.Controls.Add(new Label() { Text = "Visitor Group", AutoSize = true, Font = boldFont }, 0, 0);
            reportTable.Controls.Add(new Label() { Text = "Number of Visitors", AutoSize = true, Font = boldFont }, 1, 0);

            int rowNum = 1;
            int count = 0;
            foreach (string visitorGroup in groupRangeDict.Keys)
            {
                reportTable.Controls.Add(new Label() { Text = visitorGroup }, 0, rowNum);
                reportTable.Controls.Add(new Label() { Text = groupRangeDict[visitorGroup].ToString() }, 1, rowNum);

                count += groupRangeDict[visitorGroup];

                rowNum++;
            }

            reportTable.Controls.Add(new Label() { Text = "Grand Total: ", AutoSize = true, Font = boldFont }, 0, 5);
            reportTable.Controls.Add(new Label() { Text = count.ToString(), AutoSize = true, Font = boldFont }, 1, 5);

            dailyGroupChart.Series[0].XValueMember = "Group";
            dailyGroupChart.Series[0].YValueMembers = "Count";

            dailyGroupChart.DataSource = rarngedGroup;

            // Since the chart is rendered only once, call the DataBind method to bind 'rarngedGroup' into the chart. 
            dailyGroupChart.DataBind();
        }

        private void setAgeData(String requiredDate)
        {
            ageRangeDict.Clear();
            ageRangeDict.Add("0-12", 0);
            ageRangeDict.Add("13-65", 0);
            ageRangeDict.Add("66+", 0);

            foreach (Visitor visitor in Utils.visitorsList.Where(v => getDateFormatted(v) == requiredDate))
            {
                if (visitor.age <= 12)
                {
                    ageRangeDict["0-12"] = ageRangeDict["0-12"] + 1;
                }
                else if (visitor.age > 12 && visitor.age <= 65)
                {
                    ageRangeDict["13-65"] = ageRangeDict["13-65"] + 1;
                }
                else
                {
                    ageRangeDict["66+"] = ageRangeDict["66+"] + 1;
                }
            }

            var grouped = ageRangeDict.Select(n => new
            {
                Age = n.Key,
                Count = n.Value
            });

            
            reportTable.Controls.Clear();
            reportTable.RowCount = 5;

            reportTable.Controls.Add(new Label() { Text = "Age Group", AutoSize = true , Font = boldFont}, 0, 0);
            reportTable.Controls.Add(new Label() { Text = "Number of Visitors", AutoSize = true,Font = boldFont }, 1, 0);

            int rowNum = 1;
            int count = 0;
            foreach (string ageGroup in ageRangeDict.Keys)
            {
                reportTable.Controls.Add(new Label() { Text = ageGroup },0, rowNum);
                reportTable.Controls.Add(new Label() { Text = ageRangeDict[ageGroup].ToString() },1, rowNum);

                count += ageRangeDict[ageGroup];

                rowNum++;
            }

            reportTable.Controls.Add(new Label() { Text = "Grand Total: ", AutoSize = true, Font = boldFont }, 0, 4);
            reportTable.Controls.Add(new Label() { Text = count.ToString(), AutoSize = true, Font = boldFont }, 1, 4);

            dailyAgeChart.Series[0].XValueMember = "Age";
            dailyAgeChart.Series[0].YValueMembers = "Count";
            dailyAgeChart.Series[0].IsValueShownAsLabel = true;

            

            dailyAgeChart.DataSource = grouped;

            // Since the chart is rendered only once, call the DataBind method to bind 'grouped' into the chart. 
            dailyAgeChart.DataBind();

        }

        private void dateItemChanged(object sender, EventArgs e)
        {
            if (ageRadioButton.Checked)
            {
                setAgeData(dateCombo.SelectedItem.ToString());
            }
            else {
                setGroupData(dateCombo.SelectedItem.ToString());
            }

        }
    }
}
