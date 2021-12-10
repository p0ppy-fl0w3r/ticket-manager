using Coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class AdminPanelForm : Form
    {
        private TextBox[] amountTextBox;
        private MaskedTextBox[] percentTextBox;

        public AdminPanelForm()
        {
            InitializeComponent();

            amountTextBox = new TextBox[] { childOneText, childTwoText, childThreeText, childFourText, childDayText, adultOneText,
                                            adultTwoText, adultThreeText, adultFourText, adultDayText };

            percentTextBox = new MaskedTextBox[] {  holidayDisText, weekendDisText,
                                            seniorDisText, groupFiveText, groupTenText, groupMoreText};


            setTicketDisplay();
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

        private void setTicketDisplay()
        {
            List<TicketPrice> ticketPrice = Utils.getFromFile<TicketPrice>(Constants.TICKET_FILE);
            if (ticketPrice.Count > 0)
            {
                TicketPrice mTicketPrice = ticketPrice[0];

                childOneText.Text = mTicketPrice.childHourPrice.ToString();
                childTwoText.Text = mTicketPrice.childTwoHourPrice.ToString();
                childThreeText.Text = mTicketPrice.childThreeHourPrice.ToString();
                childFourText.Text = mTicketPrice.childFourHourPrice.ToString();
                childDayText.Text = mTicketPrice.childDayPrice.ToString();

                adultOneText.Text = mTicketPrice.hourPrice.ToString();
                adultTwoText.Text = mTicketPrice.twoHourPrice.ToString();
                adultThreeText.Text = mTicketPrice.threeHourPrice.ToString();
                adultFourText.Text = mTicketPrice.fourHourPrice.ToString();
                adultDayText.Text = mTicketPrice.dayPrice.ToString();

                holidayDisText.Text = mTicketPrice.holidayDiscount.ToString();
                weekendDisText.Text = mTicketPrice.weekendDiscount.ToString();
                seniorDisText.Text = mTicketPrice.seniorDiscount.ToString();
                groupFiveText.Text = mTicketPrice.groupFiveDiscount.ToString();
                groupTenText.Text = mTicketPrice.groupTenDiscount.ToString();
                groupMoreText.Text = mTicketPrice.groupFifteenDiscount.ToString();
            }
        }

        private void saveButtonClicked(object sender, EventArgs e)
        {
            TicketPrice ticketPrice = new TicketPrice();

            // TODO add validation
            bool isError = false;
            foreach (TextBox tBox in amountTextBox)
            {
                if (tBox.Text.Length < 1)
                {
                    isError = true;
                    Utils.animateTextBase(tBox);
                }
            }

            foreach (MaskedTextBox maskedBox in percentTextBox)
            {
                if (!maskedBox.MaskFull)
                {
                    isError = true;
                    Utils.animateTextBase(maskedBox);
                }
            }

            if (isError)
            {
                MessageBox.Show("Some of the fields are empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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

                Utils.writeToFile(ticketPrice.toJson(), Constants.TICKET_FILE);

                MessageBox.Show("Ticket prices and discounts were updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearPriceButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox tBox in amountTextBox)
            {
                tBox.ResetText();
            }
        }

        private void clearDiscountButton_Click(object sender, EventArgs e)
        {
            foreach (MaskedTextBox mBox in percentTextBox)
            {
                mBox.ResetText();
            }
        }
    }
}
