using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineReservationSystem.DataClasses;
using AirlineReservationSystem.Models;
using AirlineReservationSystem.ApplicationFiles;

namespace AirlineReservationSystem
{
    public partial class BookingDetailsWindow : UserControl
    {
        public BookingDetailsWindow()
        {
            InitializeComponent();
            cargoList.SelectedIndexChanged += CargoList_SelectedIndexChanged;
            setLocation();
            //populateBookingList();
        }
        List<Booking> bookings = new List<Booking>();
        Booking book = new Booking();

        public void populateBookingList()
        {
            string clientId = clientList.SelectedItem.ToString().Split(' ').Last();
            bookings = BookingModel.GetByClient(clientId, showArchieve.Checked);
            selectBooking.Items.Clear();
            selectBooking.Items.Add("");
            foreach (string item in bookings.Select(x => x.UniqueId.ToString()).ToList())
            {
                selectBooking.Items.Add(item);
            }
        }

        public void PopulatePlaneField()
        {
            selectPlane.Items.Clear();
            selectPlane.Items.Add("");
            foreach (string item in PlaneModel.GetAll().Select(x => x.Identity).ToList())
            {
                selectPlane.Items.Add(item);
            }
        }

        private void setLocation()
        {
            foreach (var item in Locations.Places)
            {
                toLocation.Items.Add(item);
                fromLocation.Items.Add(item);
            }
        }
        public void PopulatePassengerField()
        {
            clientList.Items.Clear();
            clientList.Items.Add("");
            foreach (string item in ClientModel.GetAll().Select(x => x.RealPerson.FirstName + " " + x.UniqueId).ToList())
            {
                clientList.Items.Add(item);
            }
        }

        private void addCargo_Click(object sender, EventArgs e)
        {
            if (cargoList.SelectedItem == null)
            {
                MessageBox.Show("Please select a cargo to be updated.");
                return;
            }
            string cargoIdToBeUpdated = cargoList.SelectedItem.ToString();
            Cargo cargo = new Cargo();
            cargo.CargoOn = PlaneModel.GetPlaneByIdentity(selectPlane.SelectedItem.ToString()).CanCarry;
            cargo.CargoId = cargoIdToBeUpdated;
            cargo.Weight = Int32.Parse(cargoWeight.Text);
            cargo.IsSecurityChecked = passedSecurity.Checked;

            cargo.Update(cargo);
            MessageBox.Show("Cargo Details has been updated");
            cargoWeight.Text = "";
            passedSecurity.Checked = false;
            cargoList.ClearSelected();
        }

        private void selectBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = selectBooking.SelectedItem.ToString();
            book = bookings.Find(x => x.UniqueId.ToString() == selected.Trim());
            if (book != null)
            {
                departureDate.Value = book.DepartureTime;
                arrivalDate.Value = book.ArrivalTime;
                toLocation.SelectedItem = book.ToLocation;
                fromLocation.SelectedItem = book.FromLocation;
                cargoList.Items.Clear();
                foreach (string cargo in book.Cargos.Select(x=> x.CargoId))
                {
                    cargoList.Items.Add(cargo);
                    
                }
                selectPlane.SelectedItem = book.AssignedPlane.Identity;
                fileNameLabel.Text = book.CargoManifest.Split(Path.DirectorySeparatorChar).Last();
                if (!String.IsNullOrEmpty(book.Passenger.ID))
                {
                    Passenger pass = new Passenger();
                    pass = pass.Retrieve(book.Passenger.ID);
                    passFullName.Text = pass.Traveller.FirstName;
                    passContact.Text = pass.Traveller.ContactNumber;
                }
                
            }
            else
            {
                MessageBox.Show("There is no such booking in the system.");
            }
        }

        private void CargoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargoList.SelectedItem == null)
            {
                return;
            }
            string cargoId = cargoList.SelectedItem.ToString();
            Cargo cargoInformation = new Cargo();
            cargoInformation.CargoId = cargoId;
            cargoInformation = cargoInformation.Retrieve(cargoId);
            cargoWeight.Text = cargoInformation.Weight.ToString();
            passedSecurity.Checked = cargoInformation.IsSecurityChecked;
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDefaultState();
            populateBookingList();
        }

        private void deleteBooking_Click(object sender, EventArgs e)
        {
            if (selectBooking.SelectedItem == null)
            {
                return;
            }
            string bookingId = selectBooking.SelectedItem.ToString();
            Booking booking = new Booking();
            booking.Delete(bookingId);
            populateBookingList();
        }

        private void archieveBooking_Click(object sender, EventArgs e)
        {
            if (selectBooking.SelectedItem ==null)
            {
                return;
            }
            string bookingID = selectBooking.SelectedItem.ToString();

            Booking booking = new Booking();
            booking.UniqueId = Guid.Parse(bookingID);
            booking = booking.Retrieve(bookingID.ToString());
            booking.IsArchieved = true;
            booking.Update(booking);
            SetDefaultState();
        }

        private void showArchieve_CheckedChanged(object sender, EventArgs e)
        {
            populateBookingList();
        }

        public void SetDefaultState()
        {
            selectPlane.SelectedIndex = 0;
            cargoList.Items.Clear();
            cargoWeight.Clear();
            passedSecurity.Checked = false;
            fromLocation.SelectedIndex = 0;
            toLocation.SelectedIndex = 0;
            departureDate.Value = DateTime.Now;
            arrivalDate.Value = DateTime.Now;
        }

        private void selectPlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void createBooking_Click(object sender, EventArgs e)
        {
            if (!enableEdit.Checked)
            {
                MessageBox.Show("Enable edit option first.");
                return;
            }
            if (selectBooking.SelectedItem == null)
            {
                return;
            }
            string selected = selectBooking.SelectedItem.ToString();
            Booking updatedBooking = bookings.Find(x => x.UniqueId.ToString() == selected.Trim());
            if (selectPlane.SelectedItem == null)
            {
                return;
            }
            if (selectPlane.SelectedItem.ToString() != book.AssignedPlane.Identity)
            {
                Plane newPlane = PlaneModel.GetPlaneByIdentity(selectPlane.SelectedItem.ToString());
                if (newPlane.CanCarry == book.AssignedPlane.CanCarry)
                {
                    updatedBooking.AssignedPlane = newPlane;
                }
                else if ((newPlane.CanCarry == PlaneCarryType.Cargo && book.AssignedPlane.CanCarry == PlaneCarryType.Passenger) ||
                    (newPlane.CanCarry == PlaneCarryType.Passenger && book.AssignedPlane.CanCarry == PlaneCarryType.Cargo))
                {
                    MessageBox.Show("Cannot change the plane from cargo plane to passenger plane or vice verse");
                    return;
                } else if ((newPlane.CanCarry == PlaneCarryType.Both && book.AssignedPlane.CanCarry == PlaneCarryType.Cargo) ||
                    (newPlane.CanCarry == PlaneCarryType.Both && book.AssignedPlane.CanCarry == PlaneCarryType.Passenger))
                {
                    updatedBooking.AssignedPlane = newPlane;
                } else if (book.AssignedPlane.CanCarry == PlaneCarryType.Both && newPlane.CanCarry == PlaneCarryType.Cargo)
                {
                    if (book.BookedBy.IsOnFlight)
                    {
                        MessageBox.Show("There are already some passengers. Cannot change the plane type");
                        return;
                    }
                    updatedBooking.AssignedPlane = newPlane;
                }
                else if (book.AssignedPlane.CanCarry == PlaneCarryType.Both && newPlane.CanCarry == PlaneCarryType.Passenger)
                {
                    if (book.Cargos.Count > 0)
                    {
                        MessageBox.Show("There are already some cargos. Cannot change the plane type.");
                        return;
                    }
                    updatedBooking.AssignedPlane = newPlane;
                }
                else
                {
                    MessageBox.Show("Some unhandled case occured.");
                    return;
                }
            }
            if (fromLocation.SelectedItem.ToString() == toLocation.SelectedItem.ToString())
            {
                MessageBox.Show("Destination and arrival place cannot be the same.");
                return;
            }
            updatedBooking.FromLocation = fromLocation.SelectedItem.ToString();
            updatedBooking.ToLocation = toLocation.SelectedItem.ToString();

            if (departureDate.Value < DateTime.Now || arrivalDate.Value < DateTime.Now.AddDays(1))
            {
                MessageBox.Show("The Departure date or Arrival date is not valid.");
                return;
            }
            updatedBooking.DepartureTime = departureDate.Value;
            updatedBooking.ArrivalTime = arrivalDate.Value;
            if (!String.IsNullOrEmpty(newCargoManifest))
            {
                updatedBooking.CargoManifest = newCargoManifest;
            }
            
            Passenger currentPassenger = new Passenger();
            currentPassenger.ID = book.Passenger.ID;
            currentPassenger.ClientId = book.Passenger.ClientId;
            currentPassenger.Traveller.FirstName = passFullName.Text;
            currentPassenger.Traveller.ContactNumber= passContact.Text;
            currentPassenger.Update(currentPassenger);

            updatedBooking.Update(updatedBooking);
            MessageBox.Show("Successfully Updated");
            SetDefaultState();
        }
        string newCargoManifest = "";
        private void uploadCargoManifest_Click(object sender, EventArgs e)
        {
            if (File.Exists(book.CargoManifest))
            {
                var confirmResult = MessageBox.Show("Are you sure delete old one and upload new one?",
                                     "Exit!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }
                try
                {
                    if (uploadNewCargomanifest.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var fileName = uploadNewCargomanifest.FileName;
                        var rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                        newCargoManifest = Path.Combine(Path.Combine(rootDirectory, "CargoManifests"), Path.GetFileName(fileName));

                        fileNameLabel.Text = Path.GetFileName(fileName);

                        File.Copy(fileName, Path.Combine(Path.Combine(rootDirectory, "CargoManifests"), Path.GetFileName(fileName)));
                    }
                    File.Delete(book.CargoManifest);
                }
                catch(Exception exp)
                {
                    MessageBox.Show("Error: {0}", exp.Message);
                }
            }
            else
            {
                MessageBox.Show("Something went wront whilst uploading.");
            }
        }
    }
}
