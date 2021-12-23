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

            amountTextBox = new TextBox[] { adultOneText, adultTwoText, adultThreeText, adultFourText, adultDayText };

            percentTextBox = new MaskedTextBox[] {  holidayDisText, weekendDisText,
                                            seniorDisText,childDisText, groupFiveText, groupTenText, groupMoreText};


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

                adultOneText.Text = mTicketPrice.hourPrice.ToString();
                adultTwoText.Text = mTicketPrice.twoHourPrice.ToString();
                adultThreeText.Text = mTicketPrice.threeHourPrice.ToString();
                adultFourText.Text = mTicketPrice.fourHourPrice.ToString();
                adultDayText.Text = mTicketPrice.dayPrice.ToString();

                holidayDisText.Text = Utils.properDoubleString(mTicketPrice.holidayDiscount);
                weekendDisText.Text = Utils.properDoubleString(mTicketPrice.weekendDiscount);
                seniorDisText.Text = Utils.properDoubleString(mTicketPrice.seniorDiscount);
                childDisText.Text = Utils.properDoubleString(mTicketPrice.childDiscount);
                groupFiveText.Text = Utils.properDoubleString(mTicketPrice.groupFiveDiscount);
                groupTenText.Text = Utils.properDoubleString(mTicketPrice.groupTenDiscount);
                groupMoreText.Text = Utils.properDoubleString(mTicketPrice.groupFifteenDiscount);

                startTimePicker.Value = DateTime.Parse(mTicketPrice.openTime);
                closeTimePicker.Value = DateTime.Parse(mTicketPrice.closeTime);
            }
        }

        private void saveButtonClicked(object sender, EventArgs e)
        {
            TicketPrice ticketPrice = new TicketPrice();

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

            if (closeTimePicker.Value.Subtract(startTimePicker.Value).TotalMinutes <= 0)
            {
                isError = true;
                Utils.animateTextBase(openTimeLabel);
                Utils.animateTextBase(closeLabel);

                ToolTip toolTip = new ToolTip();
                toolTip.Show("End time can't be before start time", closeTimePicker, new Point(closeTimePicker.Size), 2000);
            }

            System.Diagnostics.Debug.WriteLine("Sub time: " + closeTimePicker.Value.Subtract(startTimePicker.Value).TotalMinutes.ToString());

            if (isError)
            {
                MessageBox.Show("Some of the fields are not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ticketPrice.hourPrice = double.Parse(adultOneText.Text);
                ticketPrice.twoHourPrice = double.Parse(adultTwoText.Text);
                ticketPrice.threeHourPrice = double.Parse(adultThreeText.Text);
                ticketPrice.fourHourPrice = double.Parse(adultFourText.Text);
                ticketPrice.dayPrice = double.Parse(adultDayText.Text);

                ticketPrice.holidayDiscount = double.Parse(holidayDisText.Text.Substring(0, 4));
                ticketPrice.weekendDiscount = double.Parse(weekendDisText.Text.Substring(0, 4));
                ticketPrice.seniorDiscount = double.Parse(seniorDisText.Text.Substring(0, 4));
                ticketPrice.childDiscount = double.Parse(childDisText.Text.Substring(0, 4));
                ticketPrice.groupFiveDiscount = double.Parse(groupFiveText.Text.Substring(0, 4));
                ticketPrice.groupTenDiscount = double.Parse(groupTenText.Text.Substring(0, 4));
                ticketPrice.groupFifteenDiscount = double.Parse(groupMoreText.Text.Substring(0, 4));

                ticketPrice.openTime = startTimePicker.Value.ToString();
                ticketPrice.closeTime = closeTimePicker.Value.ToString();

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
