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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.currentForm = Constants.LOGIN_FORM;
        }

        private void hourTextPressed(object sender, KeyEventArgs e)
        {
            Utils.validateDigitPressed(sender, e, true);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Utils.currentForm = Constants.REPORT_FORM;
        }

        private void saveButtonClicked(object sender, EventArgs e)
        {
            TicketPrice ticketPrice = new TicketPrice();

            // TODO add validation

            ticketPrice.childHourPrice = double.Parse(childOneText.Text);
            ticketPrice.childTwoHourPrice = double.Parse(childTwoText.Text);
            ticketPrice.childThreeHourPrice = double.Parse(childThreeText.Text);
            ticketPrice.childFourHourPrice = double.Parse(childFourText.Text);
            ticketPrice.childDayPrice = double.Parse(childDayText.Text);

            ticketPrice.hourPrice = double.Parse(adultOneText.Text);
            ticketPrice.twoHourPrice = double.Parse(adultTwoText.Text);
            ticketPrice.threeHourPrice = double.Parse(adultThreeText.Text);
            ticketPrice.fourHourPrice = double.Parse(adultFourText.Text);
            ticketPrice.dayPrice = double.Parse(adultDayText.Text);

            ticketPrice.holidayDiscount = double.Parse(holidayDisText.Text.Substring(0, 4));
            ticketPrice.weekendDiscount = double.Parse(weekendDisText.Text.Substring(0, 4));
            ticketPrice.seniorDiscount = double.Parse(seniorDisText.Text.Substring(0, 4));
            ticketPrice.groupFiveDiscount = double.Parse(groupFiveText.Text.Substring(0, 4));
            ticketPrice.groupTenDiscount = double.Parse(groupTenText.Text.Substring(0, 4));
            ticketPrice.groupFifteenDiscount = double.Parse(groupMoreText.Text.Substring(0, 4));

            // TODO add verification message
            Utils.writeToFile(ticketPrice.toJson(), Constants.TICKET_FILE);

        }
    }
}
