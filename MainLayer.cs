using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineReservationSystem.Connection;


namespace AirlineReservationSystem
{
    public partial class MainLayer : Form
    {
        public MainLayer()
        {
            //NOTE: Uncomment this code for databse operation
            // DatabaseConnection.
            // DatabaseConnection.CreateTables();
            // DatabaseConnection.DropTables();
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            bookingWindow1.PopulatePlaneField();
            bookingWindow1.PopulatePassengerField();
            bookingWindow1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to exit from program?",
                                     "Exit!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            bookingWindow1.Refresh();
            bookingWindow1.PopulatePlaneField();
            bookingDetailsWindow1.PopulatePassengerField();
            bookingWindow1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            clientWindow1.Show();
            clientWindow1.Refresh();
            clientWindow1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            planeWindow1.Refresh();
            planeWindow1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            bookingDetailsWindow1.PopulatePlaneField();
            bookingDetailsWindow1.PopulatePassengerField();
            bookingDetailsWindow1.BringToFront();
        }
    }
}
