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
            tickedIdText.Enabled = false;
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
                Console.WriteLine("Enter pressed.");
            }
            else
            {
                // Check if the user pressed a digit.
                Utils.validateDigitPressed(sender, e, false);
            }
        }
    }
}
