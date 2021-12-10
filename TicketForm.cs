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
            // TODO add validation
            
            groupListBox.SelectedIndex = -1;
            groupListBox.Items.Add(nameText.Text);

            // TODO save the info in an object
        }

        // Make sure the focus is on the list box before listening to key-down events.
        private void groupListKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var selectedItem = groupListBox.SelectedItem;
                if (selectedItem != null) {
                    groupListBox.Items.Remove(selectedItem); 
                }
            }
        }

        private void saveButtonClicked(object sender, EventArgs e)
        {
            // TODO check if the ticket is of a group

            // TODO add validation
            string name = nameText.Text;    
            string gender = genderCombo.SelectedItem.ToString();
            int age = int.Parse(ageText.Text);
            string startTime = startTimePicker.Text;
            int phoneNumber = int.Parse(phoneNumberText.Text);

            Identifiers identifiers = Utils.getLastId();
            int groupId = identifiers.groupId;
            int ticketId = identifiers.ticketId;

            Visitor visitor = new Visitor();
            visitor.ticketId = ticketId;

            if (groupCheck.Checked)
            {
                visitor.groupId = groupId;
            }
            else {
                visitor.groupId = Constants.NO_GROUP;
            }
            
            visitor.name = name;
            visitor.gender = gender;
            visitor.age = age;
            visitor.phoneNumber = phoneNumber;

            // FIXME Start time only saves the time not the date.
            visitor.startTime = startTime;

            if (!groupCheck.Checked)
            {
                Utils.appendOnFile(visitor.toJson(), Constants.VISITOR_FILE);
            }

            Utils.setLastId(true, groupCheck.Checked);

        }
    }
}
