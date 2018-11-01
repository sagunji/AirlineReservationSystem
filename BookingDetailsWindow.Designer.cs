namespace AirlineReservationSystem
{
    partial class BookingDetailsWindow
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
            this.createBooking = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectPlane = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.uploadCargoManifest = new System.Windows.Forms.Button();
            this.editCargo = new System.Windows.Forms.Button();
            this.passedSecurity = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cargoWeight = new System.Windows.Forms.TextBox();
            this.cargoList = new System.Windows.Forms.ListBox();
            this.fromLocation = new System.Windows.Forms.ComboBox();
            this.toLocation = new System.Windows.Forms.ComboBox();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.arrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.selectBooking = new System.Windows.Forms.ComboBox();
            this.deleteBooking = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.clientList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.passContact = new System.Windows.Forms.TextBox();
            this.passFullName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showArchieve = new System.Windows.Forms.CheckBox();
            this.archieveBooking = new System.Windows.Forms.Button();
            this.uploadNewCargomanifest = new System.Windows.Forms.OpenFileDialog();
            this.enableEdit = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // createBooking
            // 
            this.createBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.createBooking.FlatAppearance.BorderSize = 0;
            this.createBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBooking.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBooking.ForeColor = System.Drawing.Color.White;
            this.createBooking.Location = new System.Drawing.Point(25, 509);
            this.createBooking.Name = "createBooking";
            this.createBooking.Size = new System.Drawing.Size(698, 29);
            this.createBooking.TabIndex = 43;
            this.createBooking.Text = "Update Infromation";
            this.createBooking.UseVisualStyleBackColor = false;
            this.createBooking.Click += new System.EventHandler(this.createBooking_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.selectPlane);
            this.groupBox2.Location = new System.Drawing.Point(24, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 59);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Plane";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileNameLabel);
            this.groupBox1.Controls.Add(this.uploadCargoManifest);
            this.groupBox1.Controls.Add(this.editCargo);
            this.groupBox1.Controls.Add(this.passedSecurity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cargoWeight);
            this.groupBox1.Controls.Add(this.cargoList);
            this.groupBox1.Location = new System.Drawing.Point(25, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 177);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Cargo";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(321, 151);
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
            this.uploadCargoManifest.Location = new System.Drawing.Point(162, 142);
            this.uploadCargoManifest.Name = "uploadCargoManifest";
            this.uploadCargoManifest.Size = new System.Drawing.Size(136, 29);
            this.uploadCargoManifest.TabIndex = 24;
            this.uploadCargoManifest.Text = "Upload Manifest";
            this.uploadCargoManifest.UseVisualStyleBackColor = false;
            this.uploadCargoManifest.Click += new System.EventHandler(this.uploadCargoManifest_Click);
            // 
            // editCargo
            // 
            this.editCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.editCargo.FlatAppearance.BorderSize = 0;
            this.editCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCargo.ForeColor = System.Drawing.Color.White;
            this.editCargo.Location = new System.Drawing.Point(14, 142);
            this.editCargo.Name = "editCargo";
            this.editCargo.Size = new System.Drawing.Size(142, 29);
            this.editCargo.TabIndex = 13;
            this.editCargo.Text = "Apply Cargo Edit";
            this.editCargo.UseVisualStyleBackColor = false;
            this.editCargo.Click += new System.EventHandler(this.addCargo_Click);
            // 
            // passedSecurity
            // 
            this.passedSecurity.AutoSize = true;
            this.passedSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passedSecurity.Location = new System.Drawing.Point(352, 101);
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
            this.label10.Location = new System.Drawing.Point(14, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Weight (Kg)";
            // 
            // cargoWeight
            // 
            this.cargoWeight.Location = new System.Drawing.Point(107, 99);
            this.cargoWeight.Name = "cargoWeight";
            this.cargoWeight.Size = new System.Drawing.Size(210, 20);
            this.cargoWeight.TabIndex = 21;
            // 
            // cargoList
            // 
            this.cargoList.FormattingEnabled = true;
            this.cargoList.Location = new System.Drawing.Point(15, 19);
            this.cargoList.Name = "cargoList";
            this.cargoList.Size = new System.Drawing.Size(683, 69);
            this.cargoList.TabIndex = 0;
            // 
            // fromLocation
            // 
            this.fromLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromLocation.FormattingEnabled = true;
            this.fromLocation.Location = new System.Drawing.Point(156, 236);
            this.fromLocation.Name = "fromLocation";
            this.fromLocation.Size = new System.Drawing.Size(186, 21);
            this.fromLocation.TabIndex = 39;
            // 
            // toLocation
            // 
            this.toLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toLocation.FormattingEnabled = true;
            this.toLocation.Location = new System.Drawing.Point(486, 240);
            this.toLocation.Name = "toLocation";
            this.toLocation.Size = new System.Drawing.Size(213, 21);
            this.toLocation.TabIndex = 38;
            // 
            // departureDate
            // 
            this.departureDate.Location = new System.Drawing.Point(156, 196);
            this.departureDate.MinDate = new System.DateTime(2018, 10, 7, 0, 0, 0, 0);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(186, 20);
            this.departureDate.TabIndex = 37;
            // 
            // arrivalDate
            // 
            this.arrivalDate.Location = new System.Drawing.Point(486, 196);
            this.arrivalDate.MinDate = new System.DateTime(2018, 10, 7, 0, 0, 0, 0);
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.Size = new System.Drawing.Size(213, 20);
            this.arrivalDate.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Departure Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Arrival Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "To Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "From Location";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Select Booking";
            // 
            // selectBooking
            // 
            this.selectBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBooking.FormattingEnabled = true;
            this.selectBooking.Location = new System.Drawing.Point(170, 69);
            this.selectBooking.Name = "selectBooking";
            this.selectBooking.Size = new System.Drawing.Size(335, 21);
            this.selectBooking.TabIndex = 14;
            this.selectBooking.SelectedIndexChanged += new System.EventHandler(this.selectBooking_SelectedIndexChanged);
            // 
            // deleteBooking
            // 
            this.deleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.deleteBooking.FlatAppearance.BorderSize = 0;
            this.deleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBooking.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBooking.ForeColor = System.Drawing.Color.White;
            this.deleteBooking.Location = new System.Drawing.Point(529, 59);
            this.deleteBooking.Name = "deleteBooking";
            this.deleteBooking.Size = new System.Drawing.Size(81, 24);
            this.deleteBooking.TabIndex = 27;
            this.deleteBooking.Text = "Delete";
            this.deleteBooking.UseVisualStyleBackColor = false;
            this.deleteBooking.Click += new System.EventHandler(this.deleteBooking_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Filter By Client";
            // 
            // clientList
            // 
            this.clientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientList.FormattingEnabled = true;
            this.clientList.Location = new System.Drawing.Point(170, 13);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(335, 21);
            this.clientList.TabIndex = 45;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.clientList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Passenger Fullname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Passenger Contact";
            // 
            // passContact
            // 
            this.passContact.Location = new System.Drawing.Point(516, 464);
            this.passContact.Name = "passContact";
            this.passContact.Size = new System.Drawing.Size(183, 20);
            this.passContact.TabIndex = 26;
            // 
            // passFullName
            // 
            this.passFullName.Location = new System.Drawing.Point(187, 462);
            this.passFullName.Name = "passFullName";
            this.passFullName.Size = new System.Drawing.Size(155, 20);
            this.passFullName.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.enableEdit);
            this.groupBox3.Controls.Add(this.showArchieve);
            this.groupBox3.Controls.Add(this.archieveBooking);
            this.groupBox3.Controls.Add(this.deleteBooking);
            this.groupBox3.Location = new System.Drawing.Point(12, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 528);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edt/Delete/View Bookings";
            // 
            // showArchieve
            // 
            this.showArchieve.AutoSize = true;
            this.showArchieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArchieve.Location = new System.Drawing.Point(158, 59);
            this.showArchieve.Name = "showArchieve";
            this.showArchieve.Size = new System.Drawing.Size(142, 24);
            this.showArchieve.TabIndex = 49;
            this.showArchieve.Text = "Show Archieved";
            this.showArchieve.UseVisualStyleBackColor = true;
            this.showArchieve.CheckedChanged += new System.EventHandler(this.showArchieve_CheckedChanged);
            // 
            // archieveBooking
            // 
            this.archieveBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.archieveBooking.FlatAppearance.BorderSize = 0;
            this.archieveBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archieveBooking.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archieveBooking.ForeColor = System.Drawing.Color.White;
            this.archieveBooking.Location = new System.Drawing.Point(619, 29);
            this.archieveBooking.Name = "archieveBooking";
            this.archieveBooking.Size = new System.Drawing.Size(84, 51);
            this.archieveBooking.TabIndex = 48;
            this.archieveBooking.Text = "Archeive";
            this.archieveBooking.UseVisualStyleBackColor = false;
            this.archieveBooking.Click += new System.EventHandler(this.archieveBooking_Click);
            // 
            // enableEdit
            // 
            this.enableEdit.AutoSize = true;
            this.enableEdit.Location = new System.Drawing.Point(529, 30);
            this.enableEdit.Name = "enableEdit";
            this.enableEdit.Size = new System.Drawing.Size(80, 17);
            this.enableEdit.TabIndex = 48;
            this.enableEdit.Text = "Edit Enable";
            this.enableEdit.UseVisualStyleBackColor = true;
            // 
            // BookingDetailsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passContact);
            this.Controls.Add(this.passFullName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.selectBooking);
            this.Controls.Add(this.createBooking);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fromLocation);
            this.Controls.Add(this.toLocation);
            this.Controls.Add(this.departureDate);
            this.Controls.Add(this.arrivalDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Name = "BookingDetailsWindow";
            this.Size = new System.Drawing.Size(758, 566);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createBooking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectPlane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBooking;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button uploadCargoManifest;
        private System.Windows.Forms.Button editCargo;
        private System.Windows.Forms.CheckBox passedSecurity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cargoWeight;
        private System.Windows.Forms.ListBox cargoList;
        private System.Windows.Forms.ComboBox fromLocation;
        private System.Windows.Forms.ComboBox toLocation;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.DateTimePicker arrivalDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox selectBooking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox clientList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passContact;
        private System.Windows.Forms.TextBox passFullName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button archieveBooking;
        private System.Windows.Forms.CheckBox showArchieve;
        private System.Windows.Forms.OpenFileDialog uploadNewCargomanifest;
        private System.Windows.Forms.CheckBox enableEdit;
    }
}
