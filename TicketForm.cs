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

            setInitState();

        }

        private void setInitState()
        {
            tickedIdText.Enabled = false;
            endTimeLabel.Visible = false;
            endTimePicker.Visible = false;
            nextPersonButton.Enabled = false;
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
            if (validateFields())
            {
                holidayCheck.Enabled = false;
                groupCheck.Enabled = false;
                startTimePicker.Enabled = false;

                string name = nameText.Text;
                string gender = genderCombo.SelectedItem.ToString();
                int age = int.Parse(ageText.Text);
                string startTime = startTimePicker.Value.ToString();

                long phoneNumber;
                if (phoneNumberText.Text.Trim().Length == 0)
                {
                    phoneNumber = 0;
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

                groupVisitors.Add(visitor);

                groupListBox.SelectedIndex = -1;
                groupListBox.Items.Add(nameText.Text);
            }
            else
            {
                MessageBox.Show("Some of the fields are not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // TODO reset fields 

            Identifiers identifiers = Utils.getLastId();
            int groupId = identifiers.groupId;
            int ticketId = identifiers.ticketId;

            if (!groupCheck.Checked)
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

                    Utils.appendOnFile(visitor.toJson(), Constants.VISITOR_FILE);
                    Utils.setLastId(true, groupCheck.Checked);
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

                Utils.setLastId(true, groupCheck.Checked);
            }

        }

        private bool validateFields()
        {
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
    }
}
