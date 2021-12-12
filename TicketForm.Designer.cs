using System.Windows.Forms;

namespace Coursework
{
    partial class TicketForm
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.customerInfoPanel = new System.Windows.Forms.Panel();
            this.phoneNumberText = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.groupCheck = new System.Windows.Forms.CheckBox();
            this.holidayCheck = new System.Windows.Forms.CheckBox();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.tickedIdText = new System.Windows.Forms.TextBox();
            this.netTotalLabel = new System.Windows.Forms.Label();
            this.grossTotalLabel = new System.Windows.Forms.Label();
            this.weekendDiscount = new System.Windows.Forms.Label();
            this.holidayDisLabel = new System.Windows.Forms.Label();
            this.seniorCountLabel = new System.Windows.Forms.Label();
            this.adultCountLabel = new System.Windows.Forms.Label();
            this.childCountLabel = new System.Windows.Forms.Label();
            this.ticketIdLabel = new System.Windows.Forms.Label();
            this.groupListBox = new System.Windows.Forms.ListBox();
            this.nextPersonButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.customerInfoPanel.SuspendLayout();
            this.ticketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(597, 10);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(64, 24);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log-out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // customerInfoPanel
            // 
            this.customerInfoPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.customerInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerInfoPanel.Controls.Add(this.phoneNumberText);
            this.customerInfoPanel.Controls.Add(this.phoneNumberLabel);
            this.customerInfoPanel.Controls.Add(this.endTimePicker);
            this.customerInfoPanel.Controls.Add(this.endTimeLabel);
            this.customerInfoPanel.Controls.Add(this.startTimePicker);
            this.customerInfoPanel.Controls.Add(this.startTimeLabel);
            this.customerInfoPanel.Controls.Add(this.groupCheck);
            this.customerInfoPanel.Controls.Add(this.holidayCheck);
            this.customerInfoPanel.Controls.Add(this.genderCombo);
            this.customerInfoPanel.Controls.Add(this.genderLabel);
            this.customerInfoPanel.Controls.Add(this.ageText);
            this.customerInfoPanel.Controls.Add(this.ageLabel);
            this.customerInfoPanel.Controls.Add(this.nameText);
            this.customerInfoPanel.Controls.Add(this.nameLabel);
            this.customerInfoPanel.Location = new System.Drawing.Point(10, 62);
            this.customerInfoPanel.Name = "customerInfoPanel";
            this.customerInfoPanel.Size = new System.Drawing.Size(652, 180);
            this.customerInfoPanel.TabIndex = 1;
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumberText.Location = new System.Drawing.Point(96, 139);
            this.phoneNumberText.Mask = "0000000000";
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberText.TabIndex = 20;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.phoneNumberLabel.Location = new System.Drawing.Point(15, 137);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(73, 24);
            this.phoneNumberLabel.TabIndex = 19;
            this.phoneNumberLabel.Text = "Phone no.";
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "hh:mm tt";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(339, 134);
            this.endTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.endTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(102, 20);
            this.endTimePicker.TabIndex = 18;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.endTimeLabel.Location = new System.Drawing.Point(258, 136);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(68, 24);
            this.endTimeLabel.TabIndex = 17;
            this.endTimeLabel.Text = "End Time";
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(96, 78);
            this.startTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.startTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(102, 20);
            this.startTimePicker.TabIndex = 16;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.startTimeLabel.Location = new System.Drawing.Point(15, 80);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(74, 24);
            this.startTimeLabel.TabIndex = 15;
            this.startTimeLabel.Text = "Start Time";
            // 
            // groupCheck
            // 
            this.groupCheck.AutoSize = true;
            this.groupCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupCheck.Location = new System.Drawing.Point(478, 77);
            this.groupCheck.Name = "groupCheck";
            this.groupCheck.Size = new System.Drawing.Size(111, 23);
            this.groupCheck.TabIndex = 14;
            this.groupCheck.Text = "Group Ticket";
            this.groupCheck.UseVisualStyleBackColor = true;
            this.groupCheck.CheckedChanged += new System.EventHandler(this.groupTicketChanged);
            // 
            // holidayCheck
            // 
            this.holidayCheck.AutoSize = true;
            this.holidayCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.holidayCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holidayCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.holidayCheck.Location = new System.Drawing.Point(262, 77);
            this.holidayCheck.Name = "holidayCheck";
            this.holidayCheck.Size = new System.Drawing.Size(139, 23);
            this.holidayCheck.TabIndex = 13;
            this.holidayCheck.Text = "Holiday Discount";
            this.holidayCheck.UseVisualStyleBackColor = true;
            // 
            // genderCombo
            // 
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "Male",
            "Female ",
            "Other"});
            this.genderCombo.Location = new System.Drawing.Point(485, 24);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(104, 21);
            this.genderCombo.TabIndex = 12;
            this.genderCombo.Text = "--Select Gender--";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.genderLabel.Location = new System.Drawing.Point(418, 25);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 24);
            this.genderLabel.TabIndex = 11;
            this.genderLabel.Text = "Gender";
            // 
            // ageText
            // 
            this.ageText.AllowDrop = true;
            this.ageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageText.Location = new System.Drawing.Point(311, 25);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(40, 20);
            this.ageText.TabIndex = 10;
            this.ageText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ageTextKeyPressed);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.ageLabel.Location = new System.Drawing.Point(258, 24);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(34, 24);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Age";
            // 
            // nameText
            // 
            this.nameText.AllowDrop = true;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameText.Location = new System.Drawing.Point(96, 25);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(140, 20);
            this.nameText.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(15, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 24);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // ticketPanel
            // 
            this.ticketPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.ticketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketPanel.Controls.Add(this.tickedIdText);
            this.ticketPanel.Controls.Add(this.netTotalLabel);
            this.ticketPanel.Controls.Add(this.grossTotalLabel);
            this.ticketPanel.Controls.Add(this.weekendDiscount);
            this.ticketPanel.Controls.Add(this.holidayDisLabel);
            this.ticketPanel.Controls.Add(this.seniorCountLabel);
            this.ticketPanel.Controls.Add(this.adultCountLabel);
            this.ticketPanel.Controls.Add(this.childCountLabel);
            this.ticketPanel.Controls.Add(this.ticketIdLabel);
            this.ticketPanel.Location = new System.Drawing.Point(10, 266);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(249, 208);
            this.ticketPanel.TabIndex = 15;
            // 
            // tickedIdText
            // 
            this.tickedIdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tickedIdText.Location = new System.Drawing.Point(90, 9);
            this.tickedIdText.Name = "tickedIdText";
            this.tickedIdText.Size = new System.Drawing.Size(100, 20);
            this.tickedIdText.TabIndex = 22;
            this.tickedIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ticketKeyPressed);
            // 
            // netTotalLabel
            // 
            this.netTotalLabel.AutoSize = true;
            this.netTotalLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.netTotalLabel.Location = new System.Drawing.Point(52, 166);
            this.netTotalLabel.Name = "netTotalLabel";
            this.netTotalLabel.Size = new System.Drawing.Size(80, 24);
            this.netTotalLabel.TabIndex = 21;
            this.netTotalLabel.Text = "Net Total : ";
            // 
            // grossTotalLabel
            // 
            this.grossTotalLabel.AutoSize = true;
            this.grossTotalLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.grossTotalLabel.Location = new System.Drawing.Point(43, 144);
            this.grossTotalLabel.Name = "grossTotalLabel";
            this.grossTotalLabel.Size = new System.Drawing.Size(88, 23);
            this.grossTotalLabel.TabIndex = 20;
            this.grossTotalLabel.Text = "Gross Total : ";
            // 
            // weekendDiscount
            // 
            this.weekendDiscount.AutoSize = true;
            this.weekendDiscount.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.weekendDiscount.Location = new System.Drawing.Point(3, 121);
            this.weekendDiscount.Name = "weekendDiscount";
            this.weekendDiscount.Size = new System.Drawing.Size(129, 23);
            this.weekendDiscount.TabIndex = 19;
            this.weekendDiscount.Text = "Weekend Discount : ";
            // 
            // holidayDisLabel
            // 
            this.holidayDisLabel.AutoSize = true;
            this.holidayDisLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.holidayDisLabel.Location = new System.Drawing.Point(12, 101);
            this.holidayDisLabel.Name = "holidayDisLabel";
            this.holidayDisLabel.Size = new System.Drawing.Size(119, 23);
            this.holidayDisLabel.TabIndex = 18;
            this.holidayDisLabel.Text = "Holiday Discount : ";
            // 
            // seniorCountLabel
            // 
            this.seniorCountLabel.AutoSize = true;
            this.seniorCountLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.seniorCountLabel.Location = new System.Drawing.Point(31, 81);
            this.seniorCountLabel.Name = "seniorCountLabel";
            this.seniorCountLabel.Size = new System.Drawing.Size(100, 23);
            this.seniorCountLabel.TabIndex = 17;
            this.seniorCountLabel.Text = "Senior Citizen : ";
            // 
            // adultCountLabel
            // 
            this.adultCountLabel.AutoSize = true;
            this.adultCountLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.adultCountLabel.Location = new System.Drawing.Point(80, 61);
            this.adultCountLabel.Name = "adultCountLabel";
            this.adultCountLabel.Size = new System.Drawing.Size(51, 23);
            this.adultCountLabel.TabIndex = 16;
            this.adultCountLabel.Text = "Adult : ";
            // 
            // childCountLabel
            // 
            this.childCountLabel.AutoSize = true;
            this.childCountLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.childCountLabel.Location = new System.Drawing.Point(81, 42);
            this.childCountLabel.Name = "childCountLabel";
            this.childCountLabel.Size = new System.Drawing.Size(50, 23);
            this.childCountLabel.TabIndex = 15;
            this.childCountLabel.Text = "Child : ";
            // 
            // ticketIdLabel
            // 
            this.ticketIdLabel.AutoSize = true;
            this.ticketIdLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.ticketIdLabel.Location = new System.Drawing.Point(15, 9);
            this.ticketIdLabel.Name = "ticketIdLabel";
            this.ticketIdLabel.Size = new System.Drawing.Size(69, 24);
            this.ticketIdLabel.TabIndex = 15;
            this.ticketIdLabel.Text = "Ticket ID:";
            // 
            // groupListBox
            // 
            this.groupListBox.FormattingEnabled = true;
            this.groupListBox.Location = new System.Drawing.Point(285, 262);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.Size = new System.Drawing.Size(166, 212);
            this.groupListBox.TabIndex = 16;
            this.groupListBox.SelectedIndexChanged += new System.EventHandler(this.groupListIndexChanged);
            this.groupListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupListKeyDown);
            // 
            // nextPersonButton
            // 
            this.nextPersonButton.BackColor = System.Drawing.Color.PaleGreen;
            this.nextPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPersonButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nextPersonButton.Location = new System.Drawing.Point(524, 266);
            this.nextPersonButton.Name = "nextPersonButton";
            this.nextPersonButton.Size = new System.Drawing.Size(87, 36);
            this.nextPersonButton.TabIndex = 17;
            this.nextPersonButton.Text = "Next";
            this.nextPersonButton.UseVisualStyleBackColor = false;
            this.nextPersonButton.Click += new System.EventHandler(this.nextPersonButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(575, 423);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 36);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClicked);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Crimson;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancel.Location = new System.Drawing.Point(474, 423);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 36);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.cancelButtonClicked);
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkoutButton.Location = new System.Drawing.Point(524, 337);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(87, 36);
            this.checkoutButton.TabIndex = 20;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 486);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nextPersonButton);
            this.Controls.Add(this.groupListBox);
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.customerInfoPanel);
            this.Controls.Add(this.logoutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.customerInfoPanel.ResumeLayout(false);
            this.customerInfoPanel.PerformLayout();
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button logoutButton;
        private Panel customerInfoPanel;
        private TextBox nameText;
        private Label nameLabel;
        private TextBox ageText;
        private Label ageLabel;
        private ComboBox genderCombo;
        private Label genderLabel;
        private CheckBox holidayCheck;
        private CheckBox groupCheck;
        private Panel ticketPanel;
        private ListBox groupListBox;
        private Label ticketIdLabel;
        private Button nextPersonButton;
        private Button saveButton;
        private Button Cancel;
        private Label netTotalLabel;
        private Label grossTotalLabel;
        private Label weekendDiscount;
        private Label holidayDisLabel;
        private Label seniorCountLabel;
        private Label adultCountLabel;
        private Label childCountLabel;
        private Label startTimeLabel;
        private Button checkoutButton;
        private TextBox tickedIdText;
        private DateTimePicker startTimePicker;
        private MaskedTextBox phoneNumberText;
        private Label phoneNumberLabel;
        private DateTimePicker endTimePicker;
        private Label endTimeLabel;
    }
}