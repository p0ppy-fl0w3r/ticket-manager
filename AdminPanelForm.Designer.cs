﻿using System.Windows.Forms;

namespace Coursework
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logOutButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.pricePanel = new System.Windows.Forms.Panel();
            this.clearPriceButton = new System.Windows.Forms.Button();
            this.adultDayText = new System.Windows.Forms.TextBox();
            this.adultFourText = new System.Windows.Forms.TextBox();
            this.adultThreeText = new System.Windows.Forms.TextBox();
            this.adultTwoText = new System.Windows.Forms.TextBox();
            this.adultOneText = new System.Windows.Forms.TextBox();
            this.adultLabel = new System.Windows.Forms.Label();
            this.wholeDayLabel = new System.Windows.Forms.Label();
            this.fourHrLabel = new System.Windows.Forms.Label();
            this.threeHrLabel = new System.Windows.Forms.Label();
            this.twoHrLabel = new System.Windows.Forms.Label();
            this.oneHrLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountPanel = new System.Windows.Forms.Panel();
            this.childDisText = new System.Windows.Forms.MaskedTextBox();
            this.childLabel = new System.Windows.Forms.Label();
            this.clearDiscountButton = new System.Windows.Forms.Button();
            this.groupMoreText = new System.Windows.Forms.MaskedTextBox();
            this.groupMoreLabel = new System.Windows.Forms.Label();
            this.groupTenText = new System.Windows.Forms.MaskedTextBox();
            this.groupTenLabel = new System.Windows.Forms.Label();
            this.groupFiveText = new System.Windows.Forms.MaskedTextBox();
            this.groupFiveLabel = new System.Windows.Forms.Label();
            this.seniorDisText = new System.Windows.Forms.MaskedTextBox();
            this.seniorCitizenLabel = new System.Windows.Forms.Label();
            this.holidayDisText = new System.Windows.Forms.MaskedTextBox();
            this.holidayLabel = new System.Windows.Forms.Label();
            this.weekendDisText = new System.Windows.Forms.MaskedTextBox();
            this.weekendLabel = new System.Windows.Forms.Label();
            this.adminSaveButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.openTimeLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.closeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.closeLabel = new System.Windows.Forms.Label();
            this.pricePanel.SuspendLayout();
            this.discountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(597, 10);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logOutButton.Size = new System.Drawing.Size(64, 24);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logoutClicked);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(10, 49);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(110, 48);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Pricing";
            // 
            // pricePanel
            // 
            this.pricePanel.BackColor = System.Drawing.Color.GhostWhite;
            this.pricePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePanel.Controls.Add(this.clearPriceButton);
            this.pricePanel.Controls.Add(this.adultDayText);
            this.pricePanel.Controls.Add(this.adultFourText);
            this.pricePanel.Controls.Add(this.adultThreeText);
            this.pricePanel.Controls.Add(this.adultTwoText);
            this.pricePanel.Controls.Add(this.adultOneText);
            this.pricePanel.Controls.Add(this.adultLabel);
            this.pricePanel.Controls.Add(this.wholeDayLabel);
            this.pricePanel.Controls.Add(this.fourHrLabel);
            this.pricePanel.Controls.Add(this.threeHrLabel);
            this.pricePanel.Controls.Add(this.twoHrLabel);
            this.pricePanel.Controls.Add(this.oneHrLabel);
            this.pricePanel.Location = new System.Drawing.Point(10, 100);
            this.pricePanel.Name = "pricePanel";
            this.pricePanel.Size = new System.Drawing.Size(652, 126);
            this.pricePanel.TabIndex = 2;
            // 
            // clearPriceButton
            // 
            this.clearPriceButton.BackColor = System.Drawing.Color.RosyBrown;
            this.clearPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPriceButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.clearPriceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearPriceButton.Location = new System.Drawing.Point(575, 68);
            this.clearPriceButton.Name = "clearPriceButton";
            this.clearPriceButton.Size = new System.Drawing.Size(64, 28);
            this.clearPriceButton.TabIndex = 17;
            this.clearPriceButton.Text = "Clear";
            this.clearPriceButton.UseVisualStyleBackColor = false;
            this.clearPriceButton.Click += new System.EventHandler(this.clearPriceButton_Click);
            // 
            // adultDayText
            // 
            this.adultDayText.AllowDrop = true;
            this.adultDayText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adultDayText.Location = new System.Drawing.Point(467, 75);
            this.adultDayText.Name = "adultDayText";
            this.adultDayText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adultDayText.Size = new System.Drawing.Size(43, 20);
            this.adultDayText.TabIndex = 16;
            this.adultDayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adultDayText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hourTextPressed);
            // 
            // adultFourText
            // 
            this.adultFourText.AllowDrop = true;
            this.adultFourText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adultFourText.Location = new System.Drawing.Point(377, 75);
            this.adultFourText.Name = "adultFourText";
            this.adultFourText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adultFourText.Size = new System.Drawing.Size(43, 20);
            this.adultFourText.TabIndex = 15;
            this.adultFourText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adultFourText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hourTextPressed);
            // 
            // adultThreeText
            // 
            this.adultThreeText.AllowDrop = true;
            this.adultThreeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adultThreeText.Location = new System.Drawing.Point(287, 74);
            this.adultThreeText.Name = "adultThreeText";
            this.adultThreeText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adultThreeText.Size = new System.Drawing.Size(43, 20);
            this.adultThreeText.TabIndex = 14;
            this.adultThreeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adultThreeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hourTextPressed);
            // 
            // adultTwoText
            // 
            this.adultTwoText.AllowDrop = true;
            this.adultTwoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adultTwoText.Location = new System.Drawing.Point(197, 73);
            this.adultTwoText.Name = "adultTwoText";
            this.adultTwoText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adultTwoText.Size = new System.Drawing.Size(43, 20);
            this.adultTwoText.TabIndex = 13;
            this.adultTwoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adultTwoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hourTextPressed);
            // 
            // adultOneText
            // 
            this.adultOneText.AllowDrop = true;
            this.adultOneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adultOneText.Location = new System.Drawing.Point(107, 73);
            this.adultOneText.Name = "adultOneText";
            this.adultOneText.Size = new System.Drawing.Size(43, 20);
            this.adultOneText.TabIndex = 12;
            this.adultOneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adultOneText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hourTextPressed);
            // 
            // adultLabel
            // 
            this.adultLabel.AutoSize = true;
            this.adultLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.adultLabel.Location = new System.Drawing.Point(3, 74);
            this.adultLabel.Name = "adultLabel";
            this.adultLabel.Size = new System.Drawing.Size(90, 24);
            this.adultLabel.TabIndex = 11;
            this.adultLabel.Text = "Normal Price";
            // 
            // wholeDayLabel
            // 
            this.wholeDayLabel.AutoSize = true;
            this.wholeDayLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.wholeDayLabel.Location = new System.Drawing.Point(463, 33);
            this.wholeDayLabel.Name = "wholeDayLabel";
            this.wholeDayLabel.Size = new System.Drawing.Size(78, 24);
            this.wholeDayLabel.TabIndex = 4;
            this.wholeDayLabel.Text = "Whole Day";
            // 
            // fourHrLabel
            // 
            this.fourHrLabel.AutoSize = true;
            this.fourHrLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.fourHrLabel.Location = new System.Drawing.Point(373, 33);
            this.fourHrLabel.Name = "fourHrLabel";
            this.fourHrLabel.Size = new System.Drawing.Size(56, 24);
            this.fourHrLabel.TabIndex = 3;
            this.fourHrLabel.Text = "4 hours";
            // 
            // threeHrLabel
            // 
            this.threeHrLabel.AutoSize = true;
            this.threeHrLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.threeHrLabel.Location = new System.Drawing.Point(283, 33);
            this.threeHrLabel.Name = "threeHrLabel";
            this.threeHrLabel.Size = new System.Drawing.Size(56, 24);
            this.threeHrLabel.TabIndex = 2;
            this.threeHrLabel.Text = "3 hours";
            // 
            // twoHrLabel
            // 
            this.twoHrLabel.AutoSize = true;
            this.twoHrLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.twoHrLabel.Location = new System.Drawing.Point(193, 33);
            this.twoHrLabel.Name = "twoHrLabel";
            this.twoHrLabel.Size = new System.Drawing.Size(56, 24);
            this.twoHrLabel.TabIndex = 1;
            this.twoHrLabel.Text = "2 hours";
            // 
            // oneHrLabel
            // 
            this.oneHrLabel.AutoSize = true;
            this.oneHrLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.oneHrLabel.Location = new System.Drawing.Point(103, 33);
            this.oneHrLabel.Name = "oneHrLabel";
            this.oneHrLabel.Size = new System.Drawing.Size(50, 24);
            this.oneHrLabel.TabIndex = 0;
            this.oneHrLabel.Text = "1 hour";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold);
            this.discountLabel.Location = new System.Drawing.Point(269, 239);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(133, 48);
            this.discountLabel.TabIndex = 3;
            this.discountLabel.Text = "Discount";
            // 
            // discountPanel
            // 
            this.discountPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.discountPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountPanel.Controls.Add(this.closeTimePicker);
            this.discountPanel.Controls.Add(this.closeLabel);
            this.discountPanel.Controls.Add(this.startTimePicker);
            this.discountPanel.Controls.Add(this.openTimeLabel);
            this.discountPanel.Controls.Add(this.childDisText);
            this.discountPanel.Controls.Add(this.childLabel);
            this.discountPanel.Controls.Add(this.clearDiscountButton);
            this.discountPanel.Controls.Add(this.groupMoreText);
            this.discountPanel.Controls.Add(this.groupMoreLabel);
            this.discountPanel.Controls.Add(this.groupTenText);
            this.discountPanel.Controls.Add(this.groupTenLabel);
            this.discountPanel.Controls.Add(this.groupFiveText);
            this.discountPanel.Controls.Add(this.groupFiveLabel);
            this.discountPanel.Controls.Add(this.seniorDisText);
            this.discountPanel.Controls.Add(this.seniorCitizenLabel);
            this.discountPanel.Controls.Add(this.holidayDisText);
            this.discountPanel.Controls.Add(this.holidayLabel);
            this.discountPanel.Controls.Add(this.weekendDisText);
            this.discountPanel.Controls.Add(this.weekendLabel);
            this.discountPanel.Location = new System.Drawing.Point(10, 290);
            this.discountPanel.Name = "discountPanel";
            this.discountPanel.Size = new System.Drawing.Size(652, 129);
            this.discountPanel.TabIndex = 17;
            // 
            // childDisText
            // 
            this.childDisText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.childDisText.Location = new System.Drawing.Point(99, 93);
            this.childDisText.Mask = "00.0%";
            this.childDisText.Name = "childDisText";
            this.childDisText.Size = new System.Drawing.Size(51, 20);
            this.childDisText.TabIndex = 30;
            this.childDisText.ValidatingType = typeof(int);
            // 
            // childLabel
            // 
            this.childLabel.AutoSize = true;
            this.childLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.childLabel.Location = new System.Drawing.Point(40, 93);
            this.childLabel.Name = "childLabel";
            this.childLabel.Size = new System.Drawing.Size(42, 24);
            this.childLabel.TabIndex = 29;
            this.childLabel.Text = "Child";
            // 
            // clearDiscountButton
            // 
            this.clearDiscountButton.BackColor = System.Drawing.Color.RosyBrown;
            this.clearDiscountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDiscountButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.clearDiscountButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearDiscountButton.Location = new System.Drawing.Point(575, 30);
            this.clearDiscountButton.Name = "clearDiscountButton";
            this.clearDiscountButton.Size = new System.Drawing.Size(64, 28);
            this.clearDiscountButton.TabIndex = 18;
            this.clearDiscountButton.Text = "Clear";
            this.clearDiscountButton.UseVisualStyleBackColor = false;
            this.clearDiscountButton.Click += new System.EventHandler(this.clearDiscountButton_Click);
            // 
            // groupMoreText
            // 
            this.groupMoreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupMoreText.Location = new System.Drawing.Point(483, 55);
            this.groupMoreText.Mask = "00.0%";
            this.groupMoreText.Name = "groupMoreText";
            this.groupMoreText.Size = new System.Drawing.Size(51, 20);
            this.groupMoreText.TabIndex = 28;
            this.groupMoreText.ValidatingType = typeof(int);
            // 
            // groupMoreLabel
            // 
            this.groupMoreLabel.AutoSize = true;
            this.groupMoreLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupMoreLabel.Location = new System.Drawing.Point(377, 54);
            this.groupMoreLabel.Name = "groupMoreLabel";
            this.groupMoreLabel.Size = new System.Drawing.Size(92, 24);
            this.groupMoreLabel.TabIndex = 27;
            this.groupMoreLabel.Text = "Group of 15+";
            // 
            // groupTenText
            // 
            this.groupTenText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupTenText.Location = new System.Drawing.Point(279, 53);
            this.groupTenText.Mask = "00.0%";
            this.groupTenText.Name = "groupTenText";
            this.groupTenText.Size = new System.Drawing.Size(51, 20);
            this.groupTenText.TabIndex = 26;
            this.groupTenText.ValidatingType = typeof(int);
            // 
            // groupTenLabel
            // 
            this.groupTenLabel.AutoSize = true;
            this.groupTenLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupTenLabel.Location = new System.Drawing.Point(181, 54);
            this.groupTenLabel.Name = "groupTenLabel";
            this.groupTenLabel.Size = new System.Drawing.Size(92, 24);
            this.groupTenLabel.TabIndex = 25;
            this.groupTenLabel.Text = "Group of 10+";
            // 
            // groupFiveText
            // 
            this.groupFiveText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupFiveText.Location = new System.Drawing.Point(99, 53);
            this.groupFiveText.Mask = "00.0%";
            this.groupFiveText.Name = "groupFiveText";
            this.groupFiveText.Size = new System.Drawing.Size(51, 20);
            this.groupFiveText.TabIndex = 24;
            this.groupFiveText.ValidatingType = typeof(int);
            // 
            // groupFiveLabel
            // 
            this.groupFiveLabel.AutoSize = true;
            this.groupFiveLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupFiveLabel.Location = new System.Drawing.Point(8, 54);
            this.groupFiveLabel.Name = "groupFiveLabel";
            this.groupFiveLabel.Size = new System.Drawing.Size(85, 24);
            this.groupFiveLabel.TabIndex = 23;
            this.groupFiveLabel.Text = "Group of 5+";
            // 
            // seniorDisText
            // 
            this.seniorDisText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seniorDisText.Location = new System.Drawing.Point(483, 13);
            this.seniorDisText.Mask = "00.0%";
            this.seniorDisText.Name = "seniorDisText";
            this.seniorDisText.Size = new System.Drawing.Size(51, 20);
            this.seniorDisText.TabIndex = 22;
            this.seniorDisText.ValidatingType = typeof(int);
            // 
            // seniorCitizenLabel
            // 
            this.seniorCitizenLabel.AutoSize = true;
            this.seniorCitizenLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.seniorCitizenLabel.Location = new System.Drawing.Point(377, 14);
            this.seniorCitizenLabel.Name = "seniorCitizenLabel";
            this.seniorCitizenLabel.Size = new System.Drawing.Size(95, 24);
            this.seniorCitizenLabel.TabIndex = 21;
            this.seniorCitizenLabel.Text = "Senior Citizen";
            // 
            // holidayDisText
            // 
            this.holidayDisText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holidayDisText.Location = new System.Drawing.Point(279, 13);
            this.holidayDisText.Mask = "00.0%";
            this.holidayDisText.Name = "holidayDisText";
            this.holidayDisText.Size = new System.Drawing.Size(51, 20);
            this.holidayDisText.TabIndex = 20;
            this.holidayDisText.ValidatingType = typeof(int);
            // 
            // holidayLabel
            // 
            this.holidayLabel.AutoSize = true;
            this.holidayLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.holidayLabel.Location = new System.Drawing.Point(197, 14);
            this.holidayLabel.Name = "holidayLabel";
            this.holidayLabel.Size = new System.Drawing.Size(58, 24);
            this.holidayLabel.TabIndex = 19;
            this.holidayLabel.Text = "Holiday";
            // 
            // weekendDisText
            // 
            this.weekendDisText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekendDisText.Location = new System.Drawing.Point(99, 13);
            this.weekendDisText.Mask = "00.0%";
            this.weekendDisText.Name = "weekendDisText";
            this.weekendDisText.Size = new System.Drawing.Size(51, 20);
            this.weekendDisText.TabIndex = 18;
            this.weekendDisText.ValidatingType = typeof(int);
            // 
            // weekendLabel
            // 
            this.weekendLabel.AutoSize = true;
            this.weekendLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.weekendLabel.Location = new System.Drawing.Point(20, 14);
            this.weekendLabel.Name = "weekendLabel";
            this.weekendLabel.Size = new System.Drawing.Size(73, 24);
            this.weekendLabel.TabIndex = 17;
            this.weekendLabel.Text = "Weekends";
            // 
            // adminSaveButton
            // 
            this.adminSaveButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminSaveButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.adminSaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminSaveButton.Location = new System.Drawing.Point(302, 432);
            this.adminSaveButton.Name = "adminSaveButton";
            this.adminSaveButton.Size = new System.Drawing.Size(75, 32);
            this.adminSaveButton.TabIndex = 29;
            this.adminSaveButton.Text = "Save";
            this.adminSaveButton.UseVisualStyleBackColor = false;
            this.adminSaveButton.Click += new System.EventHandler(this.saveButtonClicked);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(527, 12);
            this.reportButton.Name = "reportButton";
            this.reportButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportButton.Size = new System.Drawing.Size(64, 24);
            this.reportButton.TabIndex = 30;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // openTimeLabel
            // 
            this.openTimeLabel.AutoSize = true;
            this.openTimeLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.openTimeLabel.Location = new System.Drawing.Point(193, 93);
            this.openTimeLabel.Name = "openTimeLabel";
            this.openTimeLabel.Size = new System.Drawing.Size(78, 24);
            this.openTimeLabel.TabIndex = 31;
            this.openTimeLabel.Text = "Open Time";
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(279, 92);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(73, 20);
            this.startTimePicker.TabIndex = 32;
            // 
            // closeTimePicker
            // 
            this.closeTimePicker.CustomFormat = "hh:mm tt";
            this.closeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.closeTimePicker.Location = new System.Drawing.Point(480, 91);
            this.closeTimePicker.Name = "closeTimePicker";
            this.closeTimePicker.ShowUpDown = true;
            this.closeTimePicker.Size = new System.Drawing.Size(73, 20);
            this.closeTimePicker.TabIndex = 34;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.closeLabel.Location = new System.Drawing.Point(394, 92);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(78, 24);
            this.closeLabel.TabIndex = 33;
            this.closeLabel.Text = "Close Time";
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(672, 486);
            this.ControlBox = false;
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.adminSaveButton);
            this.Controls.Add(this.discountPanel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.pricePanel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.logOutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.pricePanel.ResumeLayout(false);
            this.pricePanel.PerformLayout();
            this.discountPanel.ResumeLayout(false);
            this.discountPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button logOutButton;
        private Label priceLabel;
        private Panel pricePanel;
        private Label wholeDayLabel;
        private Label fourHrLabel;
        private Label threeHrLabel;
        private Label twoHrLabel;
        private Label oneHrLabel;
        private TextBox adultDayText;
        private TextBox adultFourText;
        private TextBox adultThreeText;
        private TextBox adultTwoText;
        private TextBox adultOneText;
        private Label adultLabel;
        private Label discountLabel;
        private Panel discountPanel;
        private Label weekendLabel;
        private MaskedTextBox weekendDisText;
        private MaskedTextBox holidayDisText;
        private Label holidayLabel;
        private MaskedTextBox groupMoreText;
        private Label groupMoreLabel;
        private MaskedTextBox groupTenText;
        private Label groupTenLabel;
        private MaskedTextBox groupFiveText;
        private Label groupFiveLabel;
        private MaskedTextBox seniorDisText;
        private Label seniorCitizenLabel;
        private Button clearPriceButton;
        private Button clearDiscountButton;
        private Button adminSaveButton;
        private Button reportButton;
        private MaskedTextBox childDisText;
        private Label childLabel;
        private DateTimePicker startTimePicker;
        private Label openTimeLabel;
        private DateTimePicker closeTimePicker;
        private Label closeLabel;
    }
}