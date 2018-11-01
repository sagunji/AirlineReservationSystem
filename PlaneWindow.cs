using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AirlineReservationSystem.DataClasses;
using AirlineReservationSystem.Models;

namespace AirlineReservationSystem
{
    public partial class PlaneWindow : UserControl
    {
        bool isWeightValid = false;
        bool isPassangerNumberValid = false;
        bool isPlaneIdValid = false;

        bool isEditActive = false;
        public PlaneWindow()
        {
            InitializeComponent();
            planeTypeCB.DataSource = Enum.GetValues(typeof(PlaneCarryType));
            editPlaneType.DataSource = Enum.GetValues(typeof(PlaneCarryType));
            loadPlaneList();
        }

        private void loadPlaneList(bool showArchieved = false)
        {
            planeListCB.Items.Clear();
            planeListCB.Items.Add("");
            foreach (string item in PlaneModel.GetAll(showArchieved).Select(x => x.Identity).ToList())
            {
                planeListCB.Items.Add(item);
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            PlaneCarryType planeCarryType;
            Enum.TryParse<PlaneCarryType>(planeTypeCB.SelectedValue.ToString(), out planeCarryType);
            
            if (planeCarryType == PlaneCarryType.Cargo && !isWeightValid || planeCarryType == PlaneCarryType.Passenger && !isPassangerNumberValid)
            {
                return;
            }
            if (!isPlaneIdValid)
            {
                return;
            }

            Plane plane = new Plane();
            plane.CanCarry = planeCarryType;
            if (planeCarryType == PlaneCarryType.Cargo || planeCarryType == PlaneCarryType.Both)
            {
                plane.MaxCargo = Int32.Parse(planeMaxCargoWtTB.Text);
            }
            if (planeCarryType == PlaneCarryType.Passenger || planeCarryType == PlaneCarryType.Both)
            {
                plane.MaxPassenger = Int32.Parse(planeMaxPassengerTB.Text);
            }
            plane.IsRetired = isRetired.Checked;
            plane.Identity = planeIdentityTB.Text;
            plane.IsArchieved = isArchieved.Checked;
                

            plane.Create();

            planeIdentityTB.Text = "";
            planeIdentityTB.BackColor = Color.White;
            planeMaxCargoWtTB.Text = "";
            planeMaxCargoWtTB.BackColor = Color.White;
            planeMaxPassengerTB.Text = "";
            planeMaxPassengerTB.BackColor = Color.White;
            isRetired.Checked = false;
            isArchieved.Checked = false;

            loadPlaneList();

            MessageBox.Show("Successfully added a new plane.");

        }

        private void editPlane_Click(object sender, EventArgs e)
        {
            if (planeListCB.SelectedItem == null)
            {
                return;
            }

            string planeIdentity = planeListCB.SelectedItem.ToString();
            if (isEditActive)
            {
                isEditActive = false;
                editPlaneMaxCargoWt.ReadOnly = true;
                editPlaneMaxPassenger.ReadOnly = true;
            }
            else
            {
                isEditActive = true;
                editPlaneMaxCargoWt.ReadOnly = false;
                editPlaneMaxPassenger.ReadOnly = false;
            }
            
            MessageBox.Show(String.Format("Edit has been {0}.", isEditActive ? "Activated": "Deavtivated"));

        }

        private void deletePlane_Click(object sender, EventArgs e)
        {
            if (planeListCB.SelectedItem == null)
            {
                return;
            }
            string planeIdentity = planeListCB.SelectedItem.ToString();
            if (String.IsNullOrEmpty(planeIdentity))
            {
                return;
            }
            Plane toBeDeletedPlane = new Plane();
            toBeDeletedPlane.Identity = planeIdentity;

            toBeDeletedPlane.Delete(planeIdentity);
            loadPlaneList();
            MessageBox.Show(String.Format("Deleted Plane of identity {0}.", planeIdentity));
        }

        private void updatePlane_Click(object sender, EventArgs e)
        {
            if (!isEditActive)
            {
                return;
            }

            string planeIdentity = planeListCB.SelectedItem.ToString();
            if (String.IsNullOrEmpty(planeIdentity))
            {
                return;
            }

            PlaneCarryType planeCarryType;
            Enum.TryParse<PlaneCarryType>(editPlaneType.SelectedValue.ToString(), out planeCarryType);

            Plane updatePlane = new Plane();
            updatePlane.Identity = planeIdentity;
            updatePlane.CanCarry = planeCarryType;
            updatePlane.IsRetired = editPlaneRetire.Checked;
            updatePlane.IsArchieved = editArchievePlane.Checked;
            if (planeCarryType == PlaneCarryType.Cargo || planeCarryType == PlaneCarryType.Both)
            {
                updatePlane.MaxCargo = Int32.Parse(planeMaxCargoWtTB.Text);
            }
            if (planeCarryType == PlaneCarryType.Passenger || planeCarryType == PlaneCarryType.Both)
            {
                updatePlane.MaxPassenger = Int32.Parse(planeMaxPassengerTB.Text);
            }

            updatePlane.Update(updatePlane);
            loadPlaneList();
            MessageBox.Show(String.Format("Updated Plane of identity {0}.", planeIdentity));
        }

        private void planeTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaneCarryType planeCarryType;
            Enum.TryParse<PlaneCarryType>(planeTypeCB.SelectedValue.ToString(), out planeCarryType);

            if (planeCarryType == PlaneCarryType.Cargo)
            {
                planeMaxPassengerTB.Enabled = false;
                planeMaxCargoWtTB.Enabled = true;
            }
            if (planeCarryType == PlaneCarryType.Passenger)
            {
                planeMaxPassengerTB.Enabled = true;
                planeMaxCargoWtTB.Enabled = false;
            }
            if (planeCarryType == PlaneCarryType.Both)
            {
                planeMaxPassengerTB.Enabled = true;
                planeMaxCargoWtTB.Enabled = true;
            }
        }

        private void planeMaxCargoWtTB_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            bool cargoValue = Int32.TryParse(planeMaxCargoWtTB.Text, out value);
            if (!cargoValue)
            {
                isWeightValid = false;
                planeMaxCargoWtTB.BackColor = Color.Red;
            } else
            {
                isWeightValid = true;
                planeMaxCargoWtTB.BackColor = Color.White;
            }
        }

        Regex regex = new Regex(@"([A-Z])([A-Z])([A-Z])-([0-9])([0-9])([0-9])");
        private void planeIdentityTB_TextChanged(object sender, EventArgs e)
        {
            Match match = regex.Match(planeIdentityTB.Text);
            if (!match.Success)
            {
                isPlaneIdValid = false;
                planeIdentityTB.BackColor = Color.Red;
            } else
            {
                isPlaneIdValid = true;
                planeIdentityTB.BackColor = Color.White;
            }
        }

        private void planeMaxPassengerTB_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            bool planeMaxValue = Int32.TryParse(planeMaxPassengerTB.Text, out value);
            if (!planeMaxValue)
            {
                isPassangerNumberValid = false;
                planeMaxPassengerTB.BackColor = Color.Red;
            }
            else
            {
                isPassangerNumberValid = true;
                planeMaxPassengerTB.BackColor = Color.White;
            }
        }

        private void planeListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string planeIdentity = planeListCB.SelectedItem.ToString();
            if (String.IsNullOrEmpty(planeIdentity))
            {
                return;
            }

            Plane plane = PlaneModel.GetPlaneByIdentity(planeIdentity);

            editPlaneType.SelectedItem = plane.CanCarry;

            editPlaneMaxCargoWt.ReadOnly = true;
            editPlaneMaxPassenger.ReadOnly = true;

            editPlaneRetire.Checked = plane.IsRetired;
            editArchievePlane.Checked = plane.IsArchieved;
            editPlaneMaxCargoWt.Text = plane.MaxCargo.ToString();
            editPlaneMaxPassenger.Text = plane.MaxPassenger.ToString();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            bool value = checkBox3.Checked;
            if (value)
            {
                loadPlaneList(value);
            } else
            {
                loadPlaneList();
            }
        }

        private void editPlaneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaneCarryType planeCarryType;
            Enum.TryParse<PlaneCarryType>(editPlaneType.SelectedValue.ToString(), out planeCarryType);

            if (planeCarryType == PlaneCarryType.Cargo)
            {
                editPlaneMaxPassenger.Enabled = false;
                editPlaneMaxCargoWt.Enabled = true;
            }
            if (planeCarryType == PlaneCarryType.Passenger)
            {
                editPlaneMaxPassenger.Enabled = true;
                editPlaneMaxCargoWt.Enabled = false;
            }
            if (planeCarryType == PlaneCarryType.Both)
            {
                editPlaneMaxPassenger.Enabled = true;
                editPlaneMaxCargoWt.Enabled = true;
            }
        }
    }
}
