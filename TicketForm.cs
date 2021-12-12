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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Utils.validateDigitPressed(sender, e, false);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            tickedIdText.Enabled = true;
        }

        private void ticketKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                tickedIdText.ResetText();
                tickedIdText.Enabled = false;
                ticketIdLabel.Focus();
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
                    MessageBox.Show("Some of the fields are not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    visitor.receivedHolidayDiscount = holidayCheck.Checked;

                    Utils.appendOnFile(visitor.toJson(), Constants.VISITOR_FILE);
                    Utils.setLastId(true, false);

                    MessageBox.Show("Ticket saved! Your id is "+ticketId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setInitState(true);
                }
                else
                {
                    MessageBox.Show("Some of the fields are not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                foreach (Visitor visitor in groupVisitors)
                {
                    visitor.ticketId = ticketId;
                    visitor.groupId = groupId;

                    Utils.appendOnFile(visitor.toJson(), Constants.VISITOR_FILE);
                }

                Utils.setLastId(true,true);

                MessageBox.Show("Ticket saved! Your id is " + ticketId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setInitState(true);
                groupListBox.Items.Clear();
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


            return isValid;
        }

        private void cancelButtonClicked(object sender, EventArgs e)
        {
            setInitState(true);
        }
    }
}
