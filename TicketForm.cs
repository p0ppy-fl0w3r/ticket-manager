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
            tickedIdText.ResetText();

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

        private void setVisitorFields(Visitor mVisitor) {
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

        private void ticketKeyPressed(object sender, KeyEventArgs e)
        {
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

                    // TODO disable controls
                    if (selectedVisitors.Count == 1)
                    {
                        Visitor mVisitor = selectedVisitors[0];

                        setVisitorFields(mVisitor);
                        // TODO disable end-time if it's been already set
                    }
                    else {
                        groupVisitors = selectedVisitors;
                        groupCheck.Checked = true;

                        foreach (Visitor item in groupVisitors)
                        {
                            groupListBox.Items.Add(item.name);
                        }

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
                    int phoneNumber;
                    if (phoneNumberText.Text.Trim().Length == 0)
                    {
                        phoneNumber = Constants.NO_NUMBER;
                    }
                    else
                    {
                        phoneNumber = int.Parse(phoneNumberText.Text);
                    }

                    Visitor visitor = new Visitor();
                    visitor.ticketId = ticketId;
                    visitor.groupId = Constants.NO_GROUP;
                    visitor.name = name;
                    visitor.gender = gender;
                    visitor.age = age;
                    visitor.phoneNumber = phoneNumber;
                    visitor.startTime = startTime;

                    if (endTimePicker.Enabled)
                    {
                        visitor.endTime = endTimePicker.Value.ToString();
                        ticketId = int.Parse(tickedIdText.Text.ToString());
                    }

                    visitor.receivedHolidayDiscount = holidayCheck.Checked;

                    // TODO replace and rewrite the file.
                    Utils.appendOnFile(visitor.toJson(), Constants.VISITOR_FILE);
                    Utils.setLastId(true, false);

                    MessageBox.Show("Ticket saved! Your id is " + ticketId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setInitState(true);
                    startTimePicker.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Some of the fields are not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (endTimePicker.Enabled)
                {
                    string endTime = endTimePicker.Value.ToString();    
                }

                foreach (Visitor visitor in groupVisitors)
                {
                    visitor.ticketId = ticketId;
                    visitor.groupId = groupId;

                    if (endTimePicker.Enabled)
                    {
                        visitor.endTime = endTimePicker.Value.ToString();
                    }
                    else{
                        visitor.ticketId = ticketId;
                    }

                    // TODO replace and rewrite the file. Currently it saves the ticket as a new entry.
                    Utils.appendOnFile(visitor.toJson(), Constants.VISITOR_FILE);
                }

                if (!endTimePicker.Enabled)
                {
                    Utils.setLastId(true, true);
                    MessageBox.Show("Ticket saved! Your id is " + ticketId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Checked-out at: "+endTimePicker.Value.ToString("g"),"Checked out!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                setInitState(true);
                startTimePicker.Enabled = true;
                groupListBox.Items.Clear();

                // TODO add validation for end date here.
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

            if (endTimePicker.Enabled)
            {
                // TODO check if the end date is before or after start date. 
            }


            return isValid;
        }

        private void cancelButtonClicked(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                setInitState(true);
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
                    System.Diagnostics.Debug.WriteLine("The index was changed to "+groupListBox.SelectedIndex);
                }
                
            }
        }
    }
}
