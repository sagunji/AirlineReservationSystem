namespace AirlineReservationSystem
{
    partial class BookingWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arrivalDate = new System.Windows.Forms.DateTimePicker();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.toLocation = new System.Windows.Forms.ComboBox();
            this.fromLocation = new System.Windows.Forms.ComboBox();
            this.selectPassenger = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeCargo = new System.Windows.Forms.Button();
            this.generateUniqueCargoId = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.uploadCargoManifest = new System.Windows.Forms.Button();
            this.addCargo = new System.Windows.Forms.Button();
            this.passedSecurity = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cargoWeight = new System.Windows.Forms.TextBox();
            this.cargoId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cargoList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uniqueIdGenerateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.createBooking = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.selectPlane = new System.Windows.Forms.ComboBox();
            this.remainingSeats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remainingCargo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bookingIdTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.onFlight = new System.Windows.Forms.CheckBox();
            this.passengerFullName = new System.Windows.Forms.TextBox();
            this.passengerContact = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arrival Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departure Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Client Information";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // arrivalDate
            // 
            this.arrivalDate.Location = new System.Drawing.Point(491, 125);
            this.arrivalDate.MinDate = new System.DateTime(2018, 10, 7, 0, 0, 0, 0);
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.Size = new System.Drawing.Size(215, 20);
            this.arrivalDate.TabIndex = 13;
            // 
            // departureDate
            // 
            this.departureDate.Location = new System.Drawing.Point(161, 125);
            this.departureDate.MinDate = new System.DateTime(2018, 10, 7, 0, 0, 0, 0);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(201, 20);
            this.departureDate.TabIndex = 14;
            // 
            // toLocation
            // 
            this.toLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toLocation.FormattingEnabled = true;
            this.toLocation.Location = new System.Drawing.Point(491, 168);
            this.toLocation.Name = "toLocation";
            this.toLocation.Size = new System.Drawing.Size(215, 21);
            this.toLocation.TabIndex = 15;
            // 
            // fromLocation
            // 
            this.fromLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromLocation.FormattingEnabled = true;
            this.fromLocation.Location = new System.Drawing.Point(161, 165);
            this.fromLocation.Name = "fromLocation";
            this.fromLocation.Size = new System.Drawing.Size(203, 21);
            this.fromLocation.TabIndex = 16;
            // 
            // selectPassenger
            // 
            this.selectPassenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPassenger.FormattingEnabled = true;
            this.selectPassenger.Location = new System.Drawing.Point(161, 391);
            this.selectPassenger.Name = "selectPassenger";
            this.selectPassenger.Size = new System.Drawing.Size(240, 21);
            this.selectPassenger.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeCargo);
            this.groupBox1.Controls.Add(this.generateUniqueCargoId);
            this.groupBox1.Controls.Add(this.fileNameLabel);
            this.groupBox1.Controls.Add(this.uploadCargoManifest);
            this.groupBox1.Controls.Add(this.addCargo);
            this.groupBox1.Controls.Add(this.passedSecurity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cargoWeight);
            this.groupBox1.Controls.Add(this.cargoId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cargoList);
            this.groupBox1.Location = new System.Drawing.Point(30, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 174);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Cargo";
            // 
            // removeCargo
            // 
            this.removeCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.removeCargo.FlatAppearance.BorderSize = 0;
            this.removeCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCargo.ForeColor = System.Drawing.Color.White;
            this.removeCargo.Location = new System.Drawing.Point(523, 130);
            this.removeCargo.Name = "removeCargo";
            this.removeCargo.Size = new System.Drawing.Size(142, 29);
            this.removeCargo.TabIndex = 27;
            this.removeCargo.Text = "Remove Cargo";
            this.removeCargo.UseVisualStyleBackColor = false;
            this.removeCargo.Click += new System.EventHandler(this.removeCargo_Click);
            // 
            // generateUniqueCargoId
            // 
            this.generateUniqueCargoId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.generateUniqueCargoId.FlatAppearance.BorderSize = 0;
            this.generateUniqueCargoId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateUniqueCargoId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateUniqueCargoId.ForeColor = System.Drawing.Color.White;
            this.generateUniqueCargoId.Location = new System.Drawing.Point(260, 15);
            this.generateUniqueCargoId.Name = "generateUniqueCargoId";
            this.generateUniqueCargoId.Size = new System.Drawing.Size(74, 24);
            this.generateUniqueCargoId.TabIndex = 26;
            this.generateUniqueCargoId.Text = "G";
            this.generateUniqueCargoId.UseVisualStyleBackColor = false;
            this.generateUniqueCargoId.Click += new System.EventHandler(this.generateUniqueCargoId_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(520, 99);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(91, 13);
            this.fileNameLabel.TabIndex = 25;
            this.fileNameLabel.Text = "(No File Selected)";
            // 
            // uploadCargoManifest
            // 
            this.uploadCargoManifest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.uploadCargoManifest.FlatAppearance.BorderSize = 0;
            this.uploadCargoManifest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadCargoManifest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadCargoManifest.ForeColor = System.Drawing.Color.White;
            this.uploadCargoManifest.Location = new System.Drawing.Point(372, 90);
            this.uploadCargoManifest.Name = "uploadCargoManifest";
            this.uploadCargoManifest.Size = new System.Drawing.Size(142, 29);
            this.uploadCargoManifest.TabIndex = 24;
            this.uploadCargoManifest.Text = "Upload Manifest";
            this.uploadCargoManifest.UseVisualStyleBackColor = false;
            this.uploadCargoManifest.Click += new System.EventHandler(this.uploadCargoManifest_Click);
            // 
            // addCargo
            // 
            this.addCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.addCargo.FlatAppearance.BorderSize = 0;
            this.addCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCargo.ForeColor = System.Drawing.Color.White;
            this.addCargo.Location = new System.Drawing.Point(372, 130);
            this.addCargo.Name = "addCargo";
            this.addCargo.Size = new System.Drawing.Size(142, 29);
            this.addCargo.TabIndex = 13;
            this.addCargo.Text = "Add Cargo";
            this.addCargo.UseVisualStyleBackColor = false;
            this.addCargo.Click += new System.EventHandler(this.addCargo_Click);
            // 
            // passedSecurity
            // 
            this.passedSecurity.AutoSize = true;
            this.passedSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passedSecurity.Location = new System.Drawing.Point(347, 51);
            this.passedSecurity.Name = "passedSecurity";
            this.passedSecurity.Size = new System.Drawing.Size(142, 24);
            this.passedSecurity.TabIndex = 23;
            this.passedSecurity.Text = "Passed Security";
            this.passedSecurity.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Weight (Kg)";
            // 
            // cargoWeight
            // 
            this.cargoWeight.Location = new System.Drawing.Point(103, 53);
            this.cargoWeight.Name = "cargoWeight";
            this.cargoWeight.Size = new System.Drawing.Size(210, 20);
            this.cargoWeight.TabIndex = 21;
            // 
            // cargoId
            // 
            this.cargoId.Location = new System.Drawing.Point(104, 16);
            this.cargoId.Name = "cargoId";
            this.cargoId.ReadOnly = true;
            this.cargoId.Size = new System.Drawing.Size(150, 20);
            this.cargoId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cargo Id";
            // 
            // cargoList
            // 
            this.cargoList.FormattingEnabled = true;
            this.cargoList.Location = new System.Drawing.Point(14, 90);
            this.cargoList.Name = "cargoList";
            this.cargoList.Size = new System.Drawing.Size(349, 69);
            this.cargoList.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // createBooking
            // 
            this.createBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.createBooking.FlatAppearance.BorderSize = 0;
            this.createBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBooking.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBooking.ForeColor = System.Drawing.Color.White;
            this.createBooking.Location = new System.Drawing.Point(30, 509);
            this.createBooking.Name = "createBooking";
            this.createBooking.Size = new System.Drawing.Size(629, 29);
            this.createBooking.TabIndex = 27;
            this.createBooking.Text = "Create Booking";
            this.createBooking.UseVisualStyleBackColor = false;
            this.createBooking.Click += new System.EventHandler(this.createBooking_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Remaining Seats";
            // 
            // selectPlane
            // 
            this.selectPlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPlane.FormattingEnabled = true;
            this.selectPlane.Location = new System.Drawing.Point(184, 29);
            this.selectPlane.Name = "selectPlane";
            this.selectPlane.Size = new System.Drawing.Size(240, 21);
            this.selectPlane.TabIndex = 7;
            this.selectPlane.SelectedIndexChanged += new System.EventHandler(this.selectPlane_SelectedIndexChanged);
            // 
            // remainingSeats
            // 
            this.remainingSeats.Location = new System.Drawing.Point(184, 61);
            this.remainingSeats.Name = "remainingSeats";
            this.remainingSeats.ReadOnly = true;
            this.remainingSeats.Size = new System.Drawing.Size(103, 20);
            this.remainingSeats.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Remaining Cargo Wt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Plane";
            // 
            // remainingCargo
            // 
            this.remainingCargo.Location = new System.Drawing.Point(484, 59);
            this.remainingCargo.Name = "remainingCargo";
            this.remainingCargo.ReadOnly = true;
            this.remainingCargo.Size = new System.Drawing.Size(103, 20);
            this.remainingCargo.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remainingCargo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.remainingSeats);
            this.groupBox2.Controls.Add(this.selectPlane);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(30, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 92);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Plane";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(50, 913);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(629, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "Create Booking";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(402, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 24);
            this.button2.TabIndex = 30;
            this.button2.Text = "G";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bookingIdTB
            // 
            this.bookingIdTB.Location = new System.Drawing.Point(153, 473);
            this.bookingIdTB.Name = "bookingIdTB";
            this.bookingIdTB.ReadOnly = true;
            this.bookingIdTB.Size = new System.Drawing.Size(240, 20);
            this.bookingIdTB.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Booking Id";
            // 
            // onFlight
            // 
            this.onFlight.AutoSize = true;
            this.onFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onFlight.Location = new System.Drawing.Point(418, 392);
            this.onFlight.Name = "onFlight";
            this.onFlight.Size = new System.Drawing.Size(101, 24);
            this.onFlight.TabIndex = 32;
            this.onFlight.Text = "Is on flight";
            this.onFlight.UseVisualStyleBackColor = true;
            this.onFlight.CheckedChanged += new System.EventHandler(this.onFlight_CheckedChanged);
            // 
            // passengerFullName
            // 
            this.passengerFullName.Location = new System.Drawing.Point(161, 435);
            this.passengerFullName.Name = "passengerFullName";
            this.passengerFullName.Size = new System.Drawing.Size(210, 20);
            this.passengerFullName.TabIndex = 27;
            // 
            // passengerContact
            // 
            this.passengerContact.Location = new System.Drawing.Point(491, 435);
            this.passengerContact.Name = "passengerContact";
            this.passengerContact.Size = new System.Drawing.Size(210, 20);
            this.passengerContact.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Full Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(414, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Contact";
            // 
            // BookingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.passengerContact);
            this.Controls.Add(this.passengerFullName);
            this.Controls.Add(this.onFlight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bookingIdTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.createBooking);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectPassenger);
            this.Controls.Add(this.fromLocation);
            this.Controls.Add(this.toLocation);
            this.Controls.Add(this.departureDate);
            this.Controls.Add(this.arrivalDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookingWindow";
            this.Size = new System.Drawing.Size(727, 550);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker arrivalDate;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.ComboBox toLocation;
        private System.Windows.Forms.ComboBox fromLocation;
        private System.Windows.Forms.ComboBox selectPassenger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox cargoList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cargoWeight;
        private System.Windows.Forms.TextBox cargoId;
        private System.Windows.Forms.CheckBox passedSecurity;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addCargo;
        private System.Windows.Forms.Button uploadCargoManifest;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button generateUniqueCargoId;
        private System.Windows.Forms.ToolTip uniqueIdGenerateTooltip;
        private System.Windows.Forms.Button createBooking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectPlane;
        private System.Windows.Forms.TextBox remainingSeats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remainingCargo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox bookingIdTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox onFlight;
        private System.Windows.Forms.TextBox passengerFullName;
        private System.Windows.Forms.TextBox passengerContact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button removeCargo;
    }
}
