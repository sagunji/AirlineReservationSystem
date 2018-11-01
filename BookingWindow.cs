using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineReservationSystem.DataClasses;
using AirlineReservationSystem.Models;
using AirlineReservationSystem.ApplicationFiles;
using System.IO;

namespace AirlineReservationSystem
{
    public partial class BookingWindow : UserControl
    {
        List<Cargo> listOfCargos = new List<Cargo>();
        Passenger passenger = new Passenger();
        string cargoManifest = "";
        public BookingWindow()
        {
            InitializeComponent();
            PopulatePlaneField();
            PopulatePassengerField();
            setLocation();
        }

        private void setLocation()
        {
            foreach (var item in Locations.Places)
            {
                toLocation.Items.Add(item);
                fromLocation.Items.Add(item);
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
        public void PopulatePassengerField()
        {
            selectPassenger.Items.Clear();
            selectPassenger.Items.Add("");
            foreach (string item in ClientModel.GetAll().Select(x => x.RealPerson.FirstName + " " + x.UniqueId).ToList())
            {
                selectPassenger.Items.Add(item);
            }
        }

        private void generateUniqueCargoId_Click(object sender, EventArgs e)
        {
            Guid uniqueCargoId = Guid.NewGuid();
            cargoId.Text = uniqueCargoId.ToString();
        }

        private void uploadCargoManifest_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                cargoManifest = Path.Combine(Path.Combine(rootDirectory, "CargoManifests"), Path.GetFileName(fileName));

                fileNameLabel.Text = DateTime.Now.ToFileTime() + "_" +Path.GetFileName(fileName);

                File.Copy(fileName, Path.Combine(Path.Combine(rootDirectory, "CargoManifests"), fileNameLabel.Text));
            }
        }
        private void addCargo_Click(object sender, EventArgs e)
        {
            if (selectPlane.SelectedItem == null)
            {
                MessageBox.Show("Please select a plane.");
                return;
            }
            if (String.IsNullOrEmpty(cargoId.Text))
            {
                return;
            }

                if (String.IsNullOrEmpty(cargoWeight.Text))
            {
                return;
            }

            Cargo cargo = new Cargo();
            int value = 0;
            if(Int32.TryParse(cargoWeight.Text, out value))
            {
                cargo.Weight = value;
            } else
            {
                MessageBox.Show("Please enter valid weight.");
                return;
            }

            int remainingWeight = Int32.Parse(remainingCargo.Text);
            if (remainingWeight < cargo.Weight)
            {
                MessageBox.Show("The cargo cannot be added. Weight exceeds the limit.");
                return;
            }
            
            cargo.IsSecurityChecked = passedSecurity.Checked;
            cargo.CargoId = cargoId.Text;
            if (selectPlane.SelectedItem == null)
            {
                return;
            }
            cargo.CargoOn = PlaneModel.GetPlaneByIdentity(selectPlane.SelectedItem.ToString()).CanCarry;
            cargo.Create();
            listOfCargos.Add(cargo);
            cargoWeight.Text = "";
            cargoList.Items.Add(cargo.CargoId);
            cargoId.Text = "";
            remainingCargo.Text = (Int32.Parse(remainingCargo.Text) - cargo.Weight).ToString();
            passedSecurity.Checked = false;
        }

        private void selectPlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            remainingCargo.Clear();
            remainingSeats.Clear();
            Plane plane = PlaneModel.GetPlaneByIdentity(selectPlane.SelectedItem.ToString());
            
            List<Booking> bookings = BookingModel.GetAll().FindAll(x => x.AssignedPlane.Identity == selectPlane.SelectedItem.ToString());
            int cargoWeight = 0;
            int totalPassenger = 0;
            if (bookings.Count > 0)
            {
                foreach (Booking book in bookings)
                {
                    cargoWeight += book.GetTotalCargoWeight();
                    if ((PlaneCarryType.Passenger == plane.CanCarry || PlaneCarryType.Both== plane.CanCarry) && book.BookedBy.IsOnFlight)
                    {
                        totalPassenger++;
                    }
                }
            }
            remainingCargo.Text = (plane.MaxCargo - cargoWeight).ToString();
            remainingSeats.Text = (plane.MaxPassenger - totalPassenger).ToString();

            if (PlaneCarryType.Cargo == plane.CanCarry)
            {
                onFlight.Enabled = false;
                addCargo.Enabled = true;
            }
            else if (PlaneCarryType.Passenger == plane.CanCarry)
            {
                addCargo.Enabled = false;
                onFlight.Enabled = true;
            }
            else
            {
                addCargo.Enabled = true;
                onFlight.Enabled = true;
            }
        }

        private void createBooking_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            if (selectPlane.SelectedItem == null)
            {
                MessageBox.Show("Please select a plane type.");
                return;
            }
            if (String.IsNullOrEmpty(bookingIdTB.Text))
            {
                MessageBox.Show("Please generate a new booking id.");
                return;
            }
            booking.AssignedPlane = PlaneModel.GetPlaneByIdentity(selectPlane.SelectedItem.ToString());
            DateTime departureTime = departureDate.Value;
            DateTime arrivalTime = arrivalDate.Value;

            if (departureTime <= DateTime.Now)
            {
                MessageBox.Show("Please choose date which is not today.");
                return;
            }
            if (departureTime <= DateTime.Now)
            {
                MessageBox.Show("Please choose date which is not today.");
                return;
            }
            if ((arrivalTime - departureTime).TotalHours <= 24)
            {
                MessageBox.Show("Difference between arrival and departure should be more than one day.");
                return;
            }

            booking.ArrivalTime = arrivalTime;
            booking.DepartureTime = departureTime;

            if (fromLocation.SelectedItem == null || toLocation.SelectedItem == null)
            {
                MessageBox.Show("Please enter the missing destination selection.");
                return;
            }

            if (fromLocation.SelectedItem.ToString() == toLocation.SelectedItem.ToString())
            {
                MessageBox.Show("To and from location cannot be the same");
                return;
            }

            booking.ToLocation = toLocation.SelectedItem.ToString();
            booking.FromLocation= fromLocation.SelectedItem.ToString();
            string clientIdentity = selectPassenger.SelectedItem.ToString().Split(new char[] { ' ' }).Last().TrimStart().Trim();

            if (PlaneCarryType.Cargo == booking.AssignedPlane.CanCarry || PlaneCarryType.Both== booking.AssignedPlane.CanCarry)
            {
                booking.Cargos = listOfCargos;
            }
            //else if (PlaneCarryType.Passenger == booking.AssignedPlane.CanCarry || PlaneCarryType.Both == booking.AssignedPlane.CanCarry)
            //{
            if (String.IsNullOrEmpty(passengerFullName.Text) || String.IsNullOrEmpty(passengerContact.Text))
            {
                MessageBox.Show("Please input the fullname and contact for security purpose");
                return;
            }
            Passenger traveller = new Passenger();
            traveller.ClientId = clientIdentity;
            traveller.Traveller.FirstName = passengerFullName.Text;
            traveller.Traveller.ContactNumber = passengerContact.Text;
            traveller.Create();
            string idOfTraveller = traveller.getIdOfLastTraveller();
            if (String.IsNullOrEmpty(idOfTraveller))
            {
                MessageBox.Show("Something went wrong.");
                return;
            }
            traveller.ID = idOfTraveller;
            booking.Passenger = traveller;
            //}
            booking.CargoManifest = cargoManifest;
            if (selectPassenger.SelectedItem == null)
            {
                MessageBox.Show("Please choose a client.");
                return;
            }
            
            Client bookedBy = new Client();
            
            bookedBy.UniqueId = Guid.Parse(clientIdentity);
            bookedBy = bookedBy.Retrieve(bookedBy.UniqueId.ToString());
            if (onFlight.Checked && onFlight.Enabled)
            {
                bookedBy.IsOnFlight = onFlight.Checked;
                bookedBy.Update(bookedBy);
            }
            booking.BookedBy = bookedBy;
            booking.UniqueId = Guid.Parse(bookingIdTB.Text);
            booking.Create();
            SetToDefault();
        }

        private void SetToDefault()
        {
            bookingIdTB.Text = String.Empty;
            cargoList.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guid uniqueBookingId = Guid.NewGuid();
            bookingIdTB.Text = uniqueBookingId.ToString();
        }

        private void removeCargo_Click(object sender, EventArgs e)
        {
            string cargoId = cargoList.SelectedItem.ToString();
            Cargo toBeRemovedCargo = listOfCargos.Find(x => x.CargoId == cargoId);
            if (toBeRemovedCargo != null)
            {
                remainingCargo.Text = (Int32.Parse(remainingCargo.Text) + toBeRemovedCargo.Weight).ToString();
                listOfCargos.Remove(toBeRemovedCargo);
                cargoList.Items.Remove(cargoId);
            }
        }

        private void onFlight_CheckedChanged(object sender, EventArgs e)
        {
            if (onFlight.Checked)
            {
                if (Int32.Parse(remainingSeats.Text) > 0)
                {
                    remainingSeats.Text = (Int32.Parse(remainingSeats.Text) - 1).ToString();
                } else {
                    MessageBox.Show("The seats are full for this plane.");
                }
            }
            else
            {
                remainingSeats.Text = (Int32.Parse(remainingSeats.Text) + 1).ToString();
            }
        }
    }
}
