namespace AirlineReservationSystem
{
    partial class ClientWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerTypeList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.generateCustomerId = new System.Windows.Forms.Button();
            this.customerId = new System.Windows.Forms.TextBox();
            this.clientGuid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientContactTB = new System.Windows.Forms.MaskedTextBox();
            this.clientAddressTB = new System.Windows.Forms.TextBox();
            this.clientLastNameTB = new System.Windows.Forms.MaskedTextBox();
            this.clientFirstNameTB = new System.Windows.Forms.TextBox();
            this.updateClient = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.returnCustomer = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.editClient = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.clientListCB = new System.Windows.Forms.ComboBox();
            this.editClientContactTB = new System.Windows.Forms.MaskedTextBox();
            this.editClientFirstNameTB = new System.Windows.Forms.TextBox();
            this.editClientAddressTB = new System.Windows.Forms.TextBox();
            this.editClientLastNameTB = new System.Windows.Forms.MaskedTextBox();
            this.companyName = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.editCompanyName = new System.Windows.Forms.MaskedTextBox();
            this.editClientType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.companyName);
            this.groupBox1.Controls.Add(this.customerTypeList);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.generateCustomerId);
            this.groupBox1.Controls.Add(this.customerId);
            this.groupBox1.Controls.Add(this.clientGuid);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.addClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clientContactTB);
            this.groupBox1.Controls.Add(this.clientAddressTB);
            this.groupBox1.Controls.Add(this.clientLastNameTB);
            this.groupBox1.Controls.Add(this.clientFirstNameTB);
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creation of new client";
            // 
            // customerTypeList
            // 
            this.customerTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerTypeList.FormattingEnabled = true;
            this.customerTypeList.Location = new System.Drawing.Point(140, 56);
            this.customerTypeList.Name = "customerTypeList";
            this.customerTypeList.Size = new System.Drawing.Size(208, 21);
            this.customerTypeList.TabIndex = 26;
            this.customerTypeList.SelectedIndexChanged += new System.EventHandler(this.customerTypeList_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Customer Type";
            // 
            // generateCustomerId
            // 
            this.generateCustomerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.generateCustomerId.FlatAppearance.BorderSize = 0;
            this.generateCustomerId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateCustomerId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCustomerId.ForeColor = System.Drawing.Color.White;
            this.generateCustomerId.Location = new System.Drawing.Point(387, 16);
            this.generateCustomerId.Name = "generateCustomerId";
            this.generateCustomerId.Size = new System.Drawing.Size(60, 29);
            this.generateCustomerId.TabIndex = 24;
            this.generateCustomerId.Text = "G";
            this.generateCustomerId.UseVisualStyleBackColor = false;
            this.generateCustomerId.Click += new System.EventHandler(this.generateCustomerId_Click);
            // 
            // customerId
            // 
            this.customerId.Location = new System.Drawing.Point(144, 19);
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            this.customerId.Size = new System.Drawing.Size(211, 20);
            this.customerId.TabIndex = 23;
            // 
            // clientGuid
            // 
            this.clientGuid.AutoSize = true;
            this.clientGuid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientGuid.Location = new System.Drawing.Point(142, 28);
            this.clientGuid.Name = "clientGuid";
            this.clientGuid.Size = new System.Drawing.Size(0, 20);
            this.clientGuid.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Unique Identity : ";
            // 
            // addClient
            // 
            this.addClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.addClient.FlatAppearance.BorderSize = 0;
            this.addClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClient.ForeColor = System.Drawing.Color.White;
            this.addClient.Location = new System.Drawing.Point(523, 131);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(180, 29);
            this.addClient.TabIndex = 19;
            this.addClient.Text = "Add Client";
            this.addClient.UseVisualStyleBackColor = false;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // clientContactTB
            // 
            this.clientContactTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientContactTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContactTB.Location = new System.Drawing.Point(372, 92);
            this.clientContactTB.Name = "clientContactTB";
            this.clientContactTB.Size = new System.Drawing.Size(136, 26);
            this.clientContactTB.TabIndex = 3;
            // 
            // clientAddressTB
            // 
            this.clientAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientAddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddressTB.Location = new System.Drawing.Point(372, 133);
            this.clientAddressTB.Name = "clientAddressTB";
            this.clientAddressTB.Size = new System.Drawing.Size(136, 26);
            this.clientAddressTB.TabIndex = 2;
            // 
            // clientLastNameTB
            // 
            this.clientLastNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientLastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLastNameTB.Location = new System.Drawing.Point(101, 133);
            this.clientLastNameTB.Name = "clientLastNameTB";
            this.clientLastNameTB.Size = new System.Drawing.Size(153, 26);
            this.clientLastNameTB.TabIndex = 1;
            // 
            // clientFirstNameTB
            // 
            this.clientFirstNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientFirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientFirstNameTB.Location = new System.Drawing.Point(101, 92);
            this.clientFirstNameTB.Name = "clientFirstNameTB";
            this.clientFirstNameTB.Size = new System.Drawing.Size(153, 26);
            this.clientFirstNameTB.TabIndex = 0;
            // 
            // updateClient
            // 
            this.updateClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.updateClient.FlatAppearance.BorderSize = 0;
            this.updateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateClient.ForeColor = System.Drawing.Color.White;
            this.updateClient.Location = new System.Drawing.Point(11, 207);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(692, 29);
            this.updateClient.TabIndex = 5;
            this.updateClient.Text = "Update Client Information";
            this.updateClient.UseVisualStyleBackColor = false;
            this.updateClient.Click += new System.EventHandler(this.updateClient_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.returnCustomer);
            this.groupBox2.Controls.Add(this.editCompanyName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.editClientType);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.deleteClient);
            this.groupBox2.Controls.Add(this.updateClient);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.editClient);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.clientListCB);
            this.groupBox2.Controls.Add(this.editClientContactTB);
            this.groupBox2.Controls.Add(this.editClientFirstNameTB);
            this.groupBox2.Controls.Add(this.editClientAddressTB);
            this.groupBox2.Controls.Add(this.editClientLastNameTB);
            this.groupBox2.Location = new System.Drawing.Point(14, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit or delete client";
            // 
            // returnCustomer
            // 
            this.returnCustomer.AutoSize = true;
            this.returnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnCustomer.Location = new System.Drawing.Point(524, 163);
            this.returnCustomer.Name = "returnCustomer";
            this.returnCustomer.Size = new System.Drawing.Size(150, 24);
            this.returnCustomer.TabIndex = 19;
            this.returnCustomer.Text = "Return Customer";
            this.returnCustomer.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Clients";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contact";
            // 
            // deleteClient
            // 
            this.deleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.deleteClient.FlatAppearance.BorderSize = 0;
            this.deleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClient.ForeColor = System.Drawing.Color.White;
            this.deleteClient.Location = new System.Drawing.Point(612, 33);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(91, 29);
            this.deleteClient.TabIndex = 10;
            this.deleteClient.Text = "Delete";
            this.deleteClient.UseVisualStyleBackColor = false;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Last Name";
            // 
            // editClient
            // 
            this.editClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.editClient.FlatAppearance.BorderSize = 0;
            this.editClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClient.ForeColor = System.Drawing.Color.White;
            this.editClient.Location = new System.Drawing.Point(514, 33);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(92, 29);
            this.editClient.TabIndex = 11;
            this.editClient.Text = "Edit";
            this.editClient.UseVisualStyleBackColor = false;
            this.editClient.Click += new System.EventHandler(this.editClient_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "First Name";
            // 
            // clientListCB
            // 
            this.clientListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientListCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientListCB.FormattingEnabled = true;
            this.clientListCB.Location = new System.Drawing.Point(101, 34);
            this.clientListCB.Name = "clientListCB";
            this.clientListCB.Size = new System.Drawing.Size(407, 28);
            this.clientListCB.TabIndex = 0;
            this.clientListCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // editClientContactTB
            // 
            this.editClientContactTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editClientContactTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientContactTB.Location = new System.Drawing.Point(373, 122);
            this.editClientContactTB.Name = "editClientContactTB";
            this.editClientContactTB.Size = new System.Drawing.Size(136, 26);
            this.editClientContactTB.TabIndex = 13;
            // 
            // editClientFirstNameTB
            // 
            this.editClientFirstNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editClientFirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientFirstNameTB.Location = new System.Drawing.Point(102, 122);
            this.editClientFirstNameTB.Name = "editClientFirstNameTB";
            this.editClientFirstNameTB.Size = new System.Drawing.Size(153, 26);
            this.editClientFirstNameTB.TabIndex = 10;
            // 
            // editClientAddressTB
            // 
            this.editClientAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editClientAddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientAddressTB.Location = new System.Drawing.Point(373, 163);
            this.editClientAddressTB.Name = "editClientAddressTB";
            this.editClientAddressTB.Size = new System.Drawing.Size(136, 26);
            this.editClientAddressTB.TabIndex = 12;
            // 
            // editClientLastNameTB
            // 
            this.editClientLastNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editClientLastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientLastNameTB.Location = new System.Drawing.Point(102, 163);
            this.editClientLastNameTB.Name = "editClientLastNameTB";
            this.editClientLastNameTB.Size = new System.Drawing.Size(153, 26);
            this.editClientLastNameTB.TabIndex = 11;
            // 
            // companyName
            // 
            this.companyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(514, 52);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(189, 26);
            this.companyName.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(383, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Company Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(387, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Company Name";
            // 
            // editCompanyName
            // 
            this.editCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCompanyName.Location = new System.Drawing.Point(518, 80);
            this.editCompanyName.Name = "editCompanyName";
            this.editCompanyName.Size = new System.Drawing.Size(189, 26);
            this.editCompanyName.TabIndex = 31;
            // 
            // editClientType
            // 
            this.editClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editClientType.FormattingEnabled = true;
            this.editClientType.Location = new System.Drawing.Point(144, 84);
            this.editClientType.Name = "editClientType";
            this.editClientType.Size = new System.Drawing.Size(208, 21);
            this.editClientType.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Customer Type";
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientWindow";
            this.Size = new System.Drawing.Size(752, 465);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateClient;
        private System.Windows.Forms.MaskedTextBox clientContactTB;
        private System.Windows.Forms.TextBox clientAddressTB;
        private System.Windows.Forms.MaskedTextBox clientLastNameTB;
        private System.Windows.Forms.TextBox clientFirstNameTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientListCB;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button editClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox editClientContactTB;
        private System.Windows.Forms.TextBox editClientFirstNameTB;
        private System.Windows.Forms.TextBox editClientAddressTB;
        private System.Windows.Forms.MaskedTextBox editClientLastNameTB;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label clientGuid;
        private System.Windows.Forms.CheckBox returnCustomer;
        private System.Windows.Forms.Button generateCustomerId;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox customerTypeList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox companyName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox editCompanyName;
        private System.Windows.Forms.ComboBox editClientType;
        private System.Windows.Forms.Label label14;
    }
}
