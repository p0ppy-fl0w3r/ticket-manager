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
    public partial class TicketForm : Form
    {
        private List<Visitor> groupVisitors = new List<Visitor>();
        public TicketForm()
        {
            InitializeComponent();

            setInitState(true);

        }

        private void setInitState(bool setTime)
        {
            tickedIdText.Enabled = false;
            endTimeLabel.Visible = false;
            endTimePicker.Visible = false;
            nextPersonButton.Enabled = false;

            groupCheck.Enabled = true;
            holidayCheck.Enabled = true;
            startTimeLabel.Enabled = true;

            groupCheck.Checked = false;
            holidayCheck.Checked = false;

            endTimeLabel.Visible = false;
            endTimePicker.Visible = false;

            nameText.ResetText();
            phoneNumberText.ResetText();
            ageText.ResetText();

            genderCombo.SelectedIndex = -1;
            genderCombo.Text = "--Select Gender--";

            if (setTime)
            {
                startTimePicker.Value = DateTime.Now;
            }

        }

        private void setGroupState()
        {
            bool isHoliday = holidayCheck.Checked;
            setInitState(false);

            groupCheck.Checked = true;
            holidayCheck.Checked = isHoliday;

            groupCheck.Enabled = false;
            holidayCheck.Enabled = false;
            startTimePicker.Enabled = false;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Utils.currentForm = Constants.LOGIN_FORM;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            setInitState(true);
            groupListBox.Items.Clear();
            groupVisitors.Clear();

            tickedIdText.ResetText();
            tickedIdText.Enabled = true;
        }

        private void setVisitorFields(Visitor mVisitor)
        {
            nameText.Text = mVisitor.name;
            ageText.Text = mVisitor.age.ToString();
            genderCombo.Text = mVisitor.gender.ToString();
            holidayCheck.Checked = mVisitor.receivedHolidayDiscount;
            startTimePicker.Value = DateTime.Parse(mVisitor.startTime);

            if (mVisitor.phoneNumber != Constants.NO_NUMBER)
            {
                phoneNumberText.Text = mVisitor.phoneNumber.ToString();
            }
        }

        private void setFieldState(bool enabled)
        {
            nameText.Enabled = enabled;
            ageText.Enabled = enabled;
            genderCombo.Enabled = enabled;
            startTimePicker.Enabled = enabled;
            holidayCheck.Enabled = enabled;
            groupCheck.Enabled = enabled;
            phoneNumberText.Enabled = enabled;
            endTimePicker.Enabled = enabled;
            saveButton.Enabled = enabled;
            checkoutButton.Enabled = enabled;
        }

        private void ticketKeyPressed(object sender, KeyEventArgs e)
        {

            // Check if the user pressed return 
            if (e.KeyValue == (char)13)
            {
                int ticketId = int.Parse(tickedIdText.Text);

                List<Visitor> selectedVisitors = Utils.getFromFile<Visitor>(Constants.VISITOR_FILE).Where(v => v.ticketId == ticketId).ToList();
                if (selectedVisitors.Count > 0)
                {
                    setInitState(false);

                    endTimeLabel.Visible = true;
                    endTimePicker.Visible = true;

                    groupListBox.Items.Clear();
                    groupVisitors.Clear();

                    tickedIdText.Enabled = false;
                    ticketIdLabel.Focus();

                    setFieldState(false);

                    if (selectedVisitors.Count == 1)
                    {

                        Visitor mVisitor = selectedVisitors[0];

                        if (mVisitor.endTime == null)
                        {
                            // The visitor has not checked out. Enable end time and save
                            endTimePicker.Enabled = true;
                            saveButton.Enabled = true;
                        }

                        setVisitorFields(mVisitor);
                    }
                    else
                    {
                        groupVisitors = selectedVisitors;
                        groupCheck.Checked = true;

                        bool notCheckedOut = true;
                        foreach (Visitor item in groupVisitors)
                        {
                            if (item.endTime != null)
                            {
                                notCheckedOut = false;
                            }
                            groupListBox.Items.Add(item.name);
                        }

                        endTimePicker.Enabled = notCheckedOut;
                        saveButton.Enabled = notCheckedOut;

                        setVisitorFields(groupVisitors[0]);
                    }

                }
                else
                {
                    tickedIdText.ResetText();
                    tickedIdText.Enabled = false;
                    MessageBox.Show("No ticket found with id " + ticketId, "No Ticket!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Check if the user pressed a digit.
                Utils.validateDigitPressed(sender, e, false);
            }
        }

        private void groupTicketChanged(object sender, EventArgs e)
        {
            nextPersonButton.Enabled = groupCheck.Checked;
        }

        private void nextPersonButton_Click(object sender, EventArgs e)
        {
            if (groupListBox.SelectedItem == null)
            {
                if (validateFields())
                {
                    string name = nameText.Text;
                    string gender = genderCombo.SelectedItem.ToString();
                    int age = int.Parse(ageText.Text);
                    string startTime = startTimePicker.Value.ToString();

                    long phoneNumber;
                    if (phoneNumberText.Text.Trim().Length == 0)
                    {
                        phoneNumber = Constants.NO_NUMBER;
                    }
                    else
                    {
                        phoneNumber = long.Parse(phoneNumberText.Text);
                    }

                    Visitor visitor = new Visitor();
                    visitor.name = name;
                    visitor.gender = gender;
                    visitor.age = age;
                    visitor.phoneNumber = phoneNumber;
                    visitor.startTime = startTime;
                    visitor.receivedHolidayDiscount = holidayCheck.Checked;

                    groupVisitors.Add(visitor);

                    groupListBox.SelectedIndex = -1;
                    groupListBox.Items.Add(nameText.Text);

                    setGroupState();
                }
                else
                {
                    MessageBox.Show("Some of the fields are not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                groupListBox.SelectedIndex = -1;
                setGroupState();
            }
        }

        // Make sure the focus is on the list box before listening to key-down events.
        private void groupListKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var selectedItem = groupListBox.SelectedItem;
                if (selectedItem != null)
                {
                    groupVisitors.RemoveAt(groupListBox.SelectedIndex);
                    groupListBox.Items.Remove(selectedItem);
                    setGroupState();
                }
            }
        }

        private void saveButtonClicked(object sender, EventArgs e)
        {
            Identifiers identifiers = Utils.getLastId();
            int groupId = identifiers.groupId;
            int ticketId = identifiers.ticketId;

            if (!groupCheck.Checked || groupListBox.Items.Count == 0)
            {
                if (validateFields())
                {
                    string name = nameText.Text;
                    string gender = genderCombo.SelectedItem.ToString();
                    int age = int.Parse(ageText.Text);
                    string startTime = startTimePicker.Value.ToString();
                    long phoneNumber = phoneNumberText.Text.Trim().Length == 0 ?
                        Constants.NO_NUMBER : long.Parse(phoneNumberText.Text);

                    Visitor visitor = new Visitor();

                    visitor.groupId = Constants.NO_GROUP;
                    visitor.name = name;
                    visitor.gender = gender;
                    visitor.age = age;
                    visitor.phoneNumber = phoneNumber;
                    visitor.startTime = startTime;

                    if (endTimePicker.Visible)
                    {
                        // TODO add price calculations here

                        visitor.endTime = endTimePicker.Value.ToString();
                        ticketId = int.Parse(tickedIdText.Text.ToString());
                    }

                    visitor.ticketId = ticketId;
                    visitor.receivedHolidayDiscount = holidayCheck.Checked;

                    if (endTimePicker.Visible)
                    {
                        MessageBox.Show("Checked-out at: " + endTimePicker.Value.ToString("g"), "Checked out!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // DEBUG
                        List<Visitor> originalVisitorData = Utils.getFromFile<Visitor>(Constants.VISITOR_FILE);
                        List<Visitor> selectedVisitorData = originalVisitorData.Where(x => x.ticketId == visitor.ticketId).ToList();
                        selectedVisitorData.ForEach(x => x.endTime = visitor.endTime);

                        originalVisitorData.Union(selectedVisitorData);

                        String data = "";

                        originalVisitorData.ForEach(v => data = data + v.toJson() + "\n");

                        Utils.writeToFile(data, Constants.VISITOR_FILE);
                    }
                    else
                    {
                        MessageBox.Show("Ticket saved! Your id is " + ticketId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Save the new visitor info on a file
                        Utils.appendOnFile(visitor.toJson(), Constants.VISITOR_FILE);
                        Utils.setLastId(true, false);
                    }

                    setInitState(true);
                    setFieldState(true);

                    startTimePicker.Enabled = true;
                    tickedIdText.ResetText();
                }
                else
                {
                    MessageBox.Show("Some of the fields are not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!endTimePicker.Visible)
                {
                    foreach (Visitor visitor in groupVisitors)
                    {
                        visitor.ticketId = ticketId;
                        visitor.groupId = groupId;

                        Utils.appendOnFile(visitor.toJson(), Constants.VISITOR_FILE);
                    }

                    Utils.setLastId(true, true);
                    MessageBox.Show("Ticket saved! Your id is " + ticketId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Checked-out at: " + endTimePicker.Value.ToString("g"), "Checked out!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    List<Visitor> originalVisitorData = Utils.getFromFile<Visitor>(Constants.VISITOR_FILE);
                    List<Visitor> selectedVisitorData = originalVisitorData.Where(x => x.ticketId == groupVisitors[0].ticketId).ToList();
                    selectedVisitorData.ForEach(x => x.endTime = endTimePicker.Value.ToString());

                    originalVisitorData.Union(selectedVisitorData);

                    String data = "";

                    originalVisitorData.ForEach(v => data = data + v.toJson() + "\n");

                    Utils.writeToFile(data, Constants.VISITOR_FILE);
                }

                setInitState(true);
                setFieldState(true);

                startTimePicker.Enabled = true;
                groupListBox.Items.Clear();
                tickedIdText.ResetText();
            }

        }

        private bool validateFields()
        {
            // TODO add validation for opening and close time
            // TODO add open and close time in admin panel
            bool isValid = true;
            if (nameText.Text.Length < 1)
            {
                Utils.animateTextBase(nameText);
                isValid = false;
            }

            if (ageText.Text.Length < 1)
            {
                Utils.animateTextBase(ageText);
                isValid = false;
            }

            if (phoneNumberText.Text.Trim().Length > 0 && phoneNumberText.Text.Trim().Length < 9)
            {
                Utils.animateTextBase(phoneNumberText);
                isValid = false;
            }

            if (genderCombo.SelectedItem == null)
            {
                Utils.animateTextBase(genderLabel);
                isValid = false;
            }

            if (endTimePicker.Visible)
            {
                if (endTimePicker.Value.Subtract(startTimePicker.Value).Seconds < 0)
                {
                    isValid = false;
                    Utils.animateTextBase(endTimeLabel);

                    ToolTip toolTip = new ToolTip();
                    toolTip.Show("End time can't be before start time", endTimePicker, new Point(endTimePicker.Size), 2000);

                }
            }


            return isValid;
        }

        private void cancelButtonClicked(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                setInitState(true);
                setFieldState(true);

                tickedIdText.ResetText();

                groupListBox.Items.Clear();
                startTimePicker.Enabled = true;
            }
        }

        private void ageTextKeyPressed(object sender, KeyEventArgs e)
        {
            Utils.validateDigitPressed(sender, e, false);
        }

        private void groupListIndexChanged(object sender, EventArgs e)
        {
            if (groupVisitors.Count > 0 || groupListBox.SelectedIndex != -1)
            {
                // The index changed listener is called also called when the item is deleted from listBox.
                try
                {
                    setVisitorFields(groupVisitors[groupListBox.SelectedIndex]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    System.Diagnostics.Debug.WriteLine("The index was changed to " + groupListBox.SelectedIndex);
                }

            }
        }
    }
}
