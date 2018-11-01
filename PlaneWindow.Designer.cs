namespace AirlineReservationSystem
{
    partial class PlaneWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isArchieved = new System.Windows.Forms.CheckBox();
            this.planeTypeCB = new System.Windows.Forms.ComboBox();
            this.planeIdentityTB = new System.Windows.Forms.TextBox();
            this.clientGuid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isRetired = new System.Windows.Forms.CheckBox();
            this.planeMaxPassengerTB = new System.Windows.Forms.MaskedTextBox();
            this.planeMaxCargoWtTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.updatePlane = new System.Windows.Forms.Button();
            this.deletePlane = new System.Windows.Forms.Button();
            this.editPlane = new System.Windows.Forms.Button();
            this.planeListCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.editArchievePlane = new System.Windows.Forms.CheckBox();
            this.editPlaneMaxPassenger = new System.Windows.Forms.MaskedTextBox();
            this.editPlaneType = new System.Windows.Forms.ComboBox();
            this.editPlaneMaxCargoWt = new System.Windows.Forms.TextBox();
            this.editPlaneRetire = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isArchieved);
            this.groupBox1.Controls.Add(this.planeTypeCB);
            this.groupBox1.Controls.Add(this.planeIdentityTB);
            this.groupBox1.Controls.Add(this.clientGuid);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.addClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.isRetired);
            this.groupBox1.Controls.Add(this.planeMaxPassengerTB);
            this.groupBox1.Controls.Add(this.planeMaxCargoWtTB);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Plane";
            // 
            // isArchieved
            // 
            this.isArchieved.AutoSize = true;
            this.isArchieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isArchieved.Location = new System.Drawing.Point(453, 95);
            this.isArchieved.Name = "isArchieved";
            this.isArchieved.Size = new System.Drawing.Size(89, 24);
            this.isArchieved.TabIndex = 37;
            this.isArchieved.Text = "Archieve";
            this.isArchieved.UseVisualStyleBackColor = true;
            // 
            // planeTypeCB
            // 
            this.planeTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planeTypeCB.FormattingEnabled = true;
            this.planeTypeCB.Location = new System.Drawing.Point(147, 57);
            this.planeTypeCB.Name = "planeTypeCB";
            this.planeTypeCB.Size = new System.Drawing.Size(177, 21);
            this.planeTypeCB.TabIndex = 36;
            this.planeTypeCB.SelectedIndexChanged += new System.EventHandler(this.planeTypeCB_SelectedIndexChanged);
            // 
            // planeIdentityTB
            // 
            this.planeIdentityTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planeIdentityTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.planeIdentityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeIdentityTB.Location = new System.Drawing.Point(147, 24);
            this.planeIdentityTB.MaxLength = 7;
            this.planeIdentityTB.Name = "planeIdentityTB";
            this.planeIdentityTB.Size = new System.Drawing.Size(177, 26);
            this.planeIdentityTB.TabIndex = 35;
            this.planeIdentityTB.TextChanged += new System.EventHandler(this.planeIdentityTB_TextChanged);
            // 
            // clientGuid
            // 
            this.clientGuid.AutoSize = true;
            this.clientGuid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientGuid.Location = new System.Drawing.Point(131, 42);
            this.clientGuid.Name = "clientGuid";
            this.clientGuid.Size = new System.Drawing.Size(0, 20);
            this.clientGuid.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Unique Identity : ";
            // 
            // addClient
            // 
            this.addClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.addClient.FlatAppearance.BorderSize = 0;
            this.addClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClient.ForeColor = System.Drawing.Color.White;
            this.addClient.Location = new System.Drawing.Point(398, 129);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(180, 29);
            this.addClient.TabIndex = 32;
            this.addClient.Text = "Add Plane";
            this.addClient.UseVisualStyleBackColor = false;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Max Cargo Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Max Passenger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Type";
            // 
            // isRetired
            // 
            this.isRetired.AutoSize = true;
            this.isRetired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isRetired.Location = new System.Drawing.Point(350, 95);
            this.isRetired.Name = "isRetired";
            this.isRetired.Size = new System.Drawing.Size(97, 24);
            this.isRetired.TabIndex = 27;
            this.isRetired.Text = "Is Retired";
            this.isRetired.UseVisualStyleBackColor = true;
            // 
            // planeMaxPassengerTB
            // 
            this.planeMaxPassengerTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planeMaxPassengerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeMaxPassengerTB.Location = new System.Drawing.Point(147, 93);
            this.planeMaxPassengerTB.Name = "planeMaxPassengerTB";
            this.planeMaxPassengerTB.Size = new System.Drawing.Size(177, 26);
            this.planeMaxPassengerTB.TabIndex = 26;
            this.planeMaxPassengerTB.TextChanged += new System.EventHandler(this.planeMaxPassengerTB_TextChanged);
            // 
            // planeMaxCargoWtTB
            // 
            this.planeMaxCargoWtTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planeMaxCargoWtTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeMaxCargoWtTB.Location = new System.Drawing.Point(147, 131);
            this.planeMaxCargoWtTB.Name = "planeMaxCargoWtTB";
            this.planeMaxCargoWtTB.Size = new System.Drawing.Size(177, 26);
            this.planeMaxCargoWtTB.TabIndex = 25;
            this.planeMaxCargoWtTB.TextChanged += new System.EventHandler(this.planeMaxCargoWtTB_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.updatePlane);
            this.groupBox2.Controls.Add(this.deletePlane);
            this.groupBox2.Controls.Add(this.editPlane);
            this.groupBox2.Controls.Add(this.planeListCB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.editArchievePlane);
            this.groupBox2.Controls.Add(this.editPlaneMaxPassenger);
            this.groupBox2.Controls.Add(this.editPlaneType);
            this.groupBox2.Controls.Add(this.editPlaneMaxCargoWt);
            this.groupBox2.Controls.Add(this.editPlaneRetire);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(15, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit/Delete Plane";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(180, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(177, 24);
            this.checkBox3.TabIndex = 55;
            this.checkBox3.Text = "Show Archieved Only";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // updatePlane
            // 
            this.updatePlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.updatePlane.FlatAppearance.BorderSize = 0;
            this.updatePlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePlane.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePlane.ForeColor = System.Drawing.Color.White;
            this.updatePlane.Location = new System.Drawing.Point(28, 251);
            this.updatePlane.Name = "updatePlane";
            this.updatePlane.Size = new System.Drawing.Size(692, 29);
            this.updatePlane.TabIndex = 54;
            this.updatePlane.Text = "Update Plane Information";
            this.updatePlane.UseVisualStyleBackColor = false;
            this.updatePlane.Click += new System.EventHandler(this.updatePlane_Click);
            // 
            // deletePlane
            // 
            this.deletePlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.deletePlane.FlatAppearance.BorderSize = 0;
            this.deletePlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlane.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlane.ForeColor = System.Drawing.Color.White;
            this.deletePlane.Location = new System.Drawing.Point(467, 82);
            this.deletePlane.Name = "deletePlane";
            this.deletePlane.Size = new System.Drawing.Size(97, 29);
            this.deletePlane.TabIndex = 49;
            this.deletePlane.Text = "Delete";
            this.deletePlane.UseVisualStyleBackColor = false;
            this.deletePlane.Click += new System.EventHandler(this.deletePlane_Click);
            // 
            // editPlane
            // 
            this.editPlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.editPlane.FlatAppearance.BorderSize = 0;
            this.editPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPlane.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPlane.ForeColor = System.Drawing.Color.White;
            this.editPlane.Location = new System.Drawing.Point(467, 29);
            this.editPlane.Name = "editPlane";
            this.editPlane.Size = new System.Drawing.Size(97, 29);
            this.editPlane.TabIndex = 38;
            this.editPlane.Text = "Edit";
            this.editPlane.UseVisualStyleBackColor = false;
            this.editPlane.Click += new System.EventHandler(this.editPlane_Click);
            // 
            // planeListCB
            // 
            this.planeListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planeListCB.FormattingEnabled = true;
            this.planeListCB.Location = new System.Drawing.Point(180, 29);
            this.planeListCB.Name = "planeListCB";
            this.planeListCB.Size = new System.Drawing.Size(144, 21);
            this.planeListCB.TabIndex = 48;
            this.planeListCB.SelectedIndexChanged += new System.EventHandler(this.planeListCB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Planes";
            // 
            // editArchievePlane
            // 
            this.editArchievePlane.AutoSize = true;
            this.editArchievePlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editArchievePlane.Location = new System.Drawing.Point(283, 207);
            this.editArchievePlane.Name = "editArchievePlane";
            this.editArchievePlane.Size = new System.Drawing.Size(89, 24);
            this.editArchievePlane.TabIndex = 47;
            this.editArchievePlane.Text = "Archieve";
            this.editArchievePlane.UseVisualStyleBackColor = true;
            // 
            // editPlaneMaxPassenger
            // 
            this.editPlaneMaxPassenger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPlaneMaxPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPlaneMaxPassenger.Location = new System.Drawing.Point(180, 124);
            this.editPlaneMaxPassenger.Name = "editPlaneMaxPassenger";
            this.editPlaneMaxPassenger.ReadOnly = true;
            this.editPlaneMaxPassenger.Size = new System.Drawing.Size(144, 26);
            this.editPlaneMaxPassenger.TabIndex = 39;
            // 
            // editPlaneType
            // 
            this.editPlaneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editPlaneType.FormattingEnabled = true;
            this.editPlaneType.Location = new System.Drawing.Point(180, 90);
            this.editPlaneType.Name = "editPlaneType";
            this.editPlaneType.Size = new System.Drawing.Size(144, 21);
            this.editPlaneType.TabIndex = 46;
            this.editPlaneType.SelectedIndexChanged += new System.EventHandler(this.editPlaneType_SelectedIndexChanged);
            // 
            // editPlaneMaxCargoWt
            // 
            this.editPlaneMaxCargoWt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPlaneMaxCargoWt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPlaneMaxCargoWt.Location = new System.Drawing.Point(180, 165);
            this.editPlaneMaxCargoWt.Name = "editPlaneMaxCargoWt";
            this.editPlaneMaxCargoWt.ReadOnly = true;
            this.editPlaneMaxCargoWt.Size = new System.Drawing.Size(144, 26);
            this.editPlaneMaxCargoWt.TabIndex = 38;
            // 
            // editPlaneRetire
            // 
            this.editPlaneRetire.AutoSize = true;
            this.editPlaneRetire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPlaneRetire.Location = new System.Drawing.Point(180, 207);
            this.editPlaneRetire.Name = "editPlaneRetire";
            this.editPlaneRetire.Size = new System.Drawing.Size(97, 24);
            this.editPlaneRetire.TabIndex = 40;
            this.editPlaneRetire.Text = "Is Retired";
            this.editPlaneRetire.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Max Cargo Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Max Passenger";
            // 
            // PlaneWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PlaneWindow";
            this.Size = new System.Drawing.Size(797, 516);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox planeTypeCB;
        private System.Windows.Forms.TextBox planeIdentityTB;
        private System.Windows.Forms.Label clientGuid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isRetired;
        private System.Windows.Forms.MaskedTextBox planeMaxPassengerTB;
        private System.Windows.Forms.TextBox planeMaxCargoWtTB;
        private System.Windows.Forms.CheckBox isArchieved;
        private System.Windows.Forms.ComboBox planeListCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox editArchievePlane;
        private System.Windows.Forms.MaskedTextBox editPlaneMaxPassenger;
        private System.Windows.Forms.ComboBox editPlaneType;
        private System.Windows.Forms.TextBox editPlaneMaxCargoWt;
        private System.Windows.Forms.CheckBox editPlaneRetire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deletePlane;
        private System.Windows.Forms.Button editPlane;
        private System.Windows.Forms.Button updatePlane;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}
