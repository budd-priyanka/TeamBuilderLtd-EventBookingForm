namespace TeamBuilder
{
    partial class TeamBuilder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamBuilder));
            this.exitButton = new System.Windows.Forms.Button();
            this.locationHeading = new System.Windows.Forms.Label();
            this.eventHaeding = new System.Windows.Forms.Label();
            this.eventsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locationListbox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mealRadioGroup = new System.Windows.Forms.GroupBox();
            this.noMealRadioButton = new System.Windows.Forms.RadioButton();
            this.fullBoardRadioButton = new System.Windows.Forms.RadioButton();
            this.halfBoardRadioButton = new System.Windows.Forms.RadioButton();
            this.breakfastOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.mealHeading = new System.Windows.Forms.Label();
            this.quantityPanel = new System.Windows.Forms.Panel();
            this.eventAndLocationLabel = new System.Windows.Forms.Label();
            this.stockCounter = new System.Windows.Forms.NumericUpDown();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.addToBookingButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.bookingReviewListbox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.confirmButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelEditingButton = new System.Windows.Forms.Button();
            this.generateManagementReportButton = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.printedCertificateLabel = new System.Windows.Forms.Label();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.reviewButtonsPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.bookingCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.confirmationPanel = new System.Windows.Forms.Panel();
            this.finalConfirmationListbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.eventsPanel.SuspendLayout();
            this.mealRadioGroup.SuspendLayout();
            this.quantityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockCounter)).BeginInit();
            this.reviewButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.confirmationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(143, 462);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(196, 45);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Click to Exit the application");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // locationHeading
            // 
            this.locationHeading.AutoSize = true;
            this.locationHeading.Enabled = false;
            this.locationHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationHeading.Location = new System.Drawing.Point(455, 17);
            this.locationHeading.Name = "locationHeading";
            this.locationHeading.Size = new System.Drawing.Size(235, 40);
            this.locationHeading.TabIndex = 2;
            this.locationHeading.Text = "Please select your VENUE/s\r\npreference";
            // 
            // eventHaeding
            // 
            this.eventHaeding.AutoSize = true;
            this.eventHaeding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventHaeding.Location = new System.Drawing.Point(20, 17);
            this.eventHaeding.Name = "eventHaeding";
            this.eventHaeding.Size = new System.Drawing.Size(232, 40);
            this.eventHaeding.TabIndex = 0;
            this.eventHaeding.Text = "Please select your EVENT/s\r\npreference";
            // 
            // eventsPanel
            // 
            this.eventsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventsPanel.Controls.Add(this.label2);
            this.eventsPanel.Controls.Add(this.label1);
            this.eventsPanel.Controls.Add(this.locationListbox);
            this.eventsPanel.Controls.Add(this.label8);
            this.eventsPanel.Controls.Add(this.label7);
            this.eventsPanel.Controls.Add(this.label5);
            this.eventsPanel.Controls.Add(this.label6);
            this.eventsPanel.Controls.Add(this.mealRadioGroup);
            this.eventsPanel.Controls.Add(this.label4);
            this.eventsPanel.Controls.Add(this.eventsListBox);
            this.eventsPanel.Controls.Add(this.mealHeading);
            this.eventsPanel.Controls.Add(this.eventHaeding);
            this.eventsPanel.Controls.Add(this.locationHeading);
            this.eventsPanel.Location = new System.Drawing.Point(429, 18);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(1089, 238);
            this.eventsPanel.TabIndex = 0;
            this.eventsPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 109;
            this.label2.Text = "Fees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Location Name";
            // 
            // locationListbox
            // 
            this.locationListbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationListbox.Enabled = false;
            this.locationListbox.FormattingEnabled = true;
            this.locationListbox.ItemHeight = 20;
            this.locationListbox.Items.AddRange(new object[] {
            "Cork\t\t€250",
            "Dublin\t\t€165",
            "Galway\t\t€225",
            "Belmullet\t\t€305",
            "Belfast\t\t€95"});
            this.locationListbox.Location = new System.Drawing.Point(458, 104);
            this.locationListbox.Name = "locationListbox";
            this.locationListbox.ScrollAlwaysVisible = true;
            this.locationListbox.Size = new System.Drawing.Size(241, 124);
            this.locationListbox.TabIndex = 3;
            this.locationListbox.SelectedIndexChanged += new System.EventHandler(this.LocationListbox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Event Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(843, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "(Charges per day)";
            // 
            // mealRadioGroup
            // 
            this.mealRadioGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealRadioGroup.Controls.Add(this.noMealRadioButton);
            this.mealRadioGroup.Controls.Add(this.fullBoardRadioButton);
            this.mealRadioGroup.Controls.Add(this.halfBoardRadioButton);
            this.mealRadioGroup.Controls.Add(this.breakfastOnlyRadioButton);
            this.mealRadioGroup.Enabled = false;
            this.mealRadioGroup.Location = new System.Drawing.Point(749, 78);
            this.mealRadioGroup.Margin = new System.Windows.Forms.Padding(0);
            this.mealRadioGroup.Name = "mealRadioGroup";
            this.mealRadioGroup.Padding = new System.Windows.Forms.Padding(0);
            this.mealRadioGroup.Size = new System.Drawing.Size(211, 151);
            this.mealRadioGroup.TabIndex = 4;
            this.mealRadioGroup.TabStop = false;
            // 
            // noMealRadioButton
            // 
            this.noMealRadioButton.AutoSize = true;
            this.noMealRadioButton.Checked = true;
            this.noMealRadioButton.Location = new System.Drawing.Point(13, 111);
            this.noMealRadioButton.Name = "noMealRadioButton";
            this.noMealRadioButton.Size = new System.Drawing.Size(92, 24);
            this.noMealRadioButton.TabIndex = 4;
            this.noMealRadioButton.TabStop = true;
            this.noMealRadioButton.Text = "No Meal";
            this.noMealRadioButton.UseVisualStyleBackColor = true;
            this.noMealRadioButton.CheckedChanged += new System.EventHandler(this.NoMealRadioButton_CheckedChanged);
            // 
            // fullBoardRadioButton
            // 
            this.fullBoardRadioButton.AutoSize = true;
            this.fullBoardRadioButton.Location = new System.Drawing.Point(12, 24);
            this.fullBoardRadioButton.Name = "fullBoardRadioButton";
            this.fullBoardRadioButton.Size = new System.Drawing.Size(172, 24);
            this.fullBoardRadioButton.TabIndex = 1;
            this.fullBoardRadioButton.Text = "Full Board -  €49.50";
            this.fullBoardRadioButton.UseVisualStyleBackColor = true;
            this.fullBoardRadioButton.CheckedChanged += new System.EventHandler(this.FullBoardRadioButton_CheckedChanged);
            // 
            // halfBoardRadioButton
            // 
            this.halfBoardRadioButton.AutoSize = true;
            this.halfBoardRadioButton.Location = new System.Drawing.Point(12, 52);
            this.halfBoardRadioButton.Name = "halfBoardRadioButton";
            this.halfBoardRadioButton.Size = new System.Drawing.Size(176, 24);
            this.halfBoardRadioButton.TabIndex = 2;
            this.halfBoardRadioButton.Text = "Half Board -  €37.50";
            this.halfBoardRadioButton.UseVisualStyleBackColor = true;
            this.halfBoardRadioButton.CheckedChanged += new System.EventHandler(this.HalfBoardRadioButton_CheckedChanged);
            // 
            // breakfastOnlyRadioButton
            // 
            this.breakfastOnlyRadioButton.AutoSize = true;
            this.breakfastOnlyRadioButton.Location = new System.Drawing.Point(12, 81);
            this.breakfastOnlyRadioButton.Name = "breakfastOnlyRadioButton";
            this.breakfastOnlyRadioButton.Size = new System.Drawing.Size(182, 24);
            this.breakfastOnlyRadioButton.TabIndex = 3;
            this.breakfastOnlyRadioButton.Text = "Breakfast Only -  €12";
            this.breakfastOnlyRadioButton.UseVisualStyleBackColor = true;
            this.breakfastOnlyRadioButton.CheckedChanged += new System.EventHandler(this.BreakfastOnlyRadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(550, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "(Charges per day)";
            // 
            // eventsListBox
            // 
            this.eventsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventsListBox.ForeColor = System.Drawing.Color.Black;
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 20;
            this.eventsListBox.Items.AddRange(new object[] {
            "Murder Mystery Weekend\t2 Days\t€600",
            "CSI Weekend\t\t3 Days\t€1,000",
            "The Great Outdoors\t4 Days\t€1,500",
            "The Chase\t\t6 Days\t€1,800",
            "Digital Refresh\t\t2 Days\t€599",
            "Action Photography\t\t5 Days\t€999",
            "Team Ryder Cup\t\t3 Days\t€619",
            "Abseiling\t\t\t2 Days\t€499",
            "War Games\t\t6 Days\t€1,999",
            "Find Wally\t\t5 Days\t€799"});
            this.eventsListBox.Location = new System.Drawing.Point(20, 103);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.ScrollAlwaysVisible = true;
            this.eventsListBox.Size = new System.Drawing.Size(385, 124);
            this.eventsListBox.TabIndex = 2;
            this.eventsListBox.SelectedIndexChanged += new System.EventHandler(this.EventsListBox_SelectedIndexChanged);
            // 
            // mealHeading
            // 
            this.mealHeading.AutoSize = true;
            this.mealHeading.Enabled = false;
            this.mealHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealHeading.Location = new System.Drawing.Point(745, 17);
            this.mealHeading.Name = "mealHeading";
            this.mealHeading.Size = new System.Drawing.Size(208, 40);
            this.mealHeading.TabIndex = 8;
            this.mealHeading.Text = "Please select your MEAL\r\npreference";
            // 
            // quantityPanel
            // 
            this.quantityPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityPanel.Controls.Add(this.eventAndLocationLabel);
            this.quantityPanel.Controls.Add(this.stockCounter);
            this.quantityPanel.Controls.Add(this.instructionLabel);
            this.quantityPanel.Enabled = false;
            this.quantityPanel.Location = new System.Drawing.Point(435, 262);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.Size = new System.Drawing.Size(593, 105);
            this.quantityPanel.TabIndex = 0;
            // 
            // eventAndLocationLabel
            // 
            this.eventAndLocationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventAndLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventAndLocationLabel.ForeColor = System.Drawing.Color.Black;
            this.eventAndLocationLabel.Location = new System.Drawing.Point(49, 69);
            this.eventAndLocationLabel.Name = "eventAndLocationLabel";
            this.eventAndLocationLabel.Size = new System.Drawing.Size(318, 20);
            this.eventAndLocationLabel.TabIndex = 101;
            // 
            // stockCounter
            // 
            this.stockCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCounter.Location = new System.Drawing.Point(373, 44);
            this.stockCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.stockCounter.Name = "stockCounter";
            this.stockCounter.Size = new System.Drawing.Size(110, 35);
            this.stockCounter.TabIndex = 5;
            this.stockCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stockCounter.ValueChanged += new System.EventHandler(this.StockCounter_ValueChanged);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(42, 40);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(278, 20);
            this.instructionLabel.TabIndex = 98;
            this.instructionLabel.Text = "Please Enter the quantity of places for";
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.quantityErrorLabel.Location = new System.Drawing.Point(481, 374);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(464, 29);
            this.quantityErrorLabel.TabIndex = 107;
            this.quantityErrorLabel.Text = "There are no available places for booking.";
            this.quantityErrorLabel.Visible = false;
            // 
            // addToBookingButton
            // 
            this.addToBookingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addToBookingButton.Enabled = false;
            this.addToBookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToBookingButton.Location = new System.Drawing.Point(26, 45);
            this.addToBookingButton.Name = "addToBookingButton";
            this.addToBookingButton.Size = new System.Drawing.Size(196, 45);
            this.addToBookingButton.TabIndex = 6;
            this.addToBookingButton.Text = "Add To Booking";
            this.toolTip1.SetToolTip(this.addToBookingButton, "Click to add to your other bookings");
            this.addToBookingButton.UseVisualStyleBackColor = true;
            this.addToBookingButton.Click += new System.EventHandler(this.AddToBookingButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(26, 208);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(196, 45);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "&Edit";
            this.toolTip1.SetToolTip(this.editButton, "Click to edit");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // bookingReviewListbox
            // 
            this.bookingReviewListbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookingReviewListbox.Enabled = false;
            this.bookingReviewListbox.FormattingEnabled = true;
            this.bookingReviewListbox.HorizontalScrollbar = true;
            this.bookingReviewListbox.ItemHeight = 20;
            this.bookingReviewListbox.Location = new System.Drawing.Point(424, 557);
            this.bookingReviewListbox.Name = "bookingReviewListbox";
            this.bookingReviewListbox.ScrollAlwaysVisible = true;
            this.bookingReviewListbox.Size = new System.Drawing.Size(747, 104);
            this.bookingReviewListbox.TabIndex = 5;
            this.bookingReviewListbox.Visible = false;
            this.bookingReviewListbox.SelectedIndexChanged += new System.EventHandler(this.BookingReviewListbox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.Enabled = false;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(26, 99);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(196, 45);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "&Confirm my bookings";
            this.toolTip1.SetToolTip(this.confirmButton, "Click to confirm the added booking/s ");
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(26, 44);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(196, 45);
            this.saveChangesButton.TabIndex = 10;
            this.saveChangesButton.Text = "&Save Changes";
            this.toolTip1.SetToolTip(this.saveChangesButton, "Click to save the edited changes");
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Visible = false;
            this.saveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(26, 265);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(196, 45);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "&Delete";
            this.toolTip1.SetToolTip(this.deleteButton, "Click to delete the choosen event");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // cancelEditingButton
            // 
            this.cancelEditingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelEditingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEditingButton.Location = new System.Drawing.Point(26, 208);
            this.cancelEditingButton.Name = "cancelEditingButton";
            this.cancelEditingButton.Size = new System.Drawing.Size(196, 45);
            this.cancelEditingButton.TabIndex = 11;
            this.cancelEditingButton.Text = "Cancel &Editing";
            this.toolTip1.SetToolTip(this.cancelEditingButton, "Click to go to the previous screen");
            this.cancelEditingButton.UseVisualStyleBackColor = true;
            this.cancelEditingButton.Visible = false;
            this.cancelEditingButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // generateManagementReportButton
            // 
            this.generateManagementReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateManagementReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateManagementReportButton.Location = new System.Drawing.Point(143, 403);
            this.generateManagementReportButton.Name = "generateManagementReportButton";
            this.generateManagementReportButton.Size = new System.Drawing.Size(196, 45);
            this.generateManagementReportButton.TabIndex = 1;
            this.generateManagementReportButton.Text = "&Generate Report";
            this.toolTip1.SetToolTip(this.generateManagementReportButton, "Click to generate management report");
            this.generateManagementReportButton.UseVisualStyleBackColor = true;
            this.generateManagementReportButton.Click += new System.EventHandler(this.GenerateManagementReportButton_Click);
            // 
            // printedCertificateLabel
            // 
            this.printedCertificateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printedCertificateLabel.AutoSize = true;
            this.printedCertificateLabel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.printedCertificateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printedCertificateLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.printedCertificateLabel.Location = new System.Drawing.Point(641, 486);
            this.printedCertificateLabel.Name = "printedCertificateLabel";
            this.printedCertificateLabel.Size = new System.Drawing.Size(348, 20);
            this.printedCertificateLabel.TabIndex = 102;
            this.printedCertificateLabel.Text = "*You receive a Printed Certificate FREE of Cost.";
            this.printedCertificateLabel.Visible = false;
            // 
            // reviewLabel
            // 
            this.reviewLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewLabel.ForeColor = System.Drawing.Color.Black;
            this.reviewLabel.Location = new System.Drawing.Point(446, 529);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(249, 20);
            this.reviewLabel.TabIndex = 102;
            this.reviewLabel.Text = "Review your Booking preference/s";
            this.reviewLabel.Visible = false;
            // 
            // reviewButtonsPanel
            // 
            this.reviewButtonsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reviewButtonsPanel.Controls.Add(this.deleteButton);
            this.reviewButtonsPanel.Controls.Add(this.confirmButton);
            this.reviewButtonsPanel.Controls.Add(this.clearButton);
            this.reviewButtonsPanel.Controls.Add(this.editButton);
            this.reviewButtonsPanel.Controls.Add(this.cancelEditingButton);
            this.reviewButtonsPanel.Controls.Add(this.saveChangesButton);
            this.reviewButtonsPanel.Controls.Add(this.addToBookingButton);
            this.reviewButtonsPanel.Location = new System.Drawing.Point(1179, 270);
            this.reviewButtonsPanel.Name = "reviewButtonsPanel";
            this.reviewButtonsPanel.Size = new System.Drawing.Size(336, 416);
            this.reviewButtonsPanel.TabIndex = 0;
            this.reviewButtonsPanel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.Enabled = false;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(26, 153);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(196, 45);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Click to clear the selections made");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // bookingCostLabel
            // 
            this.bookingCostLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookingCostLabel.AutoSize = true;
            this.bookingCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingCostLabel.Location = new System.Drawing.Point(446, 421);
            this.bookingCostLabel.Name = "bookingCostLabel";
            this.bookingCostLabel.Size = new System.Drawing.Size(337, 29);
            this.bookingCostLabel.TabIndex = 103;
            this.bookingCostLabel.Text = "Estimated Total Booking Cost:";
            this.bookingCostLabel.Visible = false;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalCostLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(801, 419);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(155, 34);
            this.totalCostLabel.TabIndex = 104;
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.totalCostLabel.Visible = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPictureBox.Image = global::TeamBuilder.Properties.Resources.teamBuilderLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(73, 99);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(326, 231);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 106;
            this.logoPictureBox.TabStop = false;
            // 
            // confirmationPanel
            // 
            this.confirmationPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmationPanel.Controls.Add(this.finalConfirmationListbox);
            this.confirmationPanel.Controls.Add(this.label3);
            this.confirmationPanel.Controls.Add(this.cancelButton);
            this.confirmationPanel.Controls.Add(this.okButton);
            this.confirmationPanel.Location = new System.Drawing.Point(422, 8);
            this.confirmationPanel.Name = "confirmationPanel";
            this.confirmationPanel.Size = new System.Drawing.Size(1164, 730);
            this.confirmationPanel.TabIndex = 110;
            this.confirmationPanel.Visible = false;
            // 
            // finalConfirmationListbox
            // 
            this.finalConfirmationListbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finalConfirmationListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalConfirmationListbox.FormattingEnabled = true;
            this.finalConfirmationListbox.HorizontalScrollbar = true;
            this.finalConfirmationListbox.ItemHeight = 25;
            this.finalConfirmationListbox.Location = new System.Drawing.Point(179, 84);
            this.finalConfirmationListbox.Name = "finalConfirmationListbox";
            this.finalConfirmationListbox.ScrollAlwaysVisible = true;
            this.finalConfirmationListbox.Size = new System.Drawing.Size(799, 329);
            this.finalConfirmationListbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm the following events";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(651, 447);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(285, 45);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(256, 450);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(285, 45);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "&Ok";
            this.toolTip1.SetToolTip(this.okButton, "Click to write the bookings into the file");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TeamBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1552, 936);
            this.Controls.Add(this.confirmationPanel);
            this.Controls.Add(this.generateManagementReportButton);
            this.Controls.Add(this.quantityErrorLabel);
            this.Controls.Add(this.quantityPanel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.bookingCostLabel);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.reviewButtonsPanel);
            this.Controls.Add(this.printedCertificateLabel);
            this.Controls.Add(this.bookingReviewListbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.eventsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeamBuilder";
            this.Text = "Team Builder";
            this.Load += new System.EventHandler(this.TeamBuilder_Load);
            this.eventsPanel.ResumeLayout(false);
            this.eventsPanel.PerformLayout();
            this.mealRadioGroup.ResumeLayout(false);
            this.mealRadioGroup.PerformLayout();
            this.quantityPanel.ResumeLayout(false);
            this.quantityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockCounter)).EndInit();
            this.reviewButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.confirmationPanel.ResumeLayout(false);
            this.confirmationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label locationHeading;
        private System.Windows.Forms.Label eventHaeding;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel eventsPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label mealHeading;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ListBox bookingReviewListbox;
        private System.Windows.Forms.Panel quantityPanel;
        private System.Windows.Forms.Label eventAndLocationLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button addToBookingButton;
        private System.Windows.Forms.NumericUpDown stockCounter;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox mealRadioGroup;
        private System.Windows.Forms.RadioButton noMealRadioButton;
        private System.Windows.Forms.RadioButton fullBoardRadioButton;
        private System.Windows.Forms.RadioButton halfBoardRadioButton;
        private System.Windows.Forms.RadioButton breakfastOnlyRadioButton;
        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.Label printedCertificateLabel;
        private System.Windows.Forms.Panel reviewButtonsPanel;
        private System.Windows.Forms.Label bookingCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox locationListbox;
        private System.Windows.Forms.Label quantityErrorLabel;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelEditingButton;
        private System.Windows.Forms.Button generateManagementReportButton;
        private System.Windows.Forms.Panel confirmationPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox finalConfirmationListbox;
    }
}

