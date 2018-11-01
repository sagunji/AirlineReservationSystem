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

namespace AirlineReservationSystem
{
    public partial class ClientWindow : UserControl
    {

        bool isEditActive = false;
        public ClientWindow()
        {
            InitializeComponent();
            customerTypeList.DataSource = Enum.GetValues(typeof(ClientType));
            editClientType.DataSource = Enum.GetValues(typeof(ClientType));

            PersonModel.GetAll();
            List<Client> clients = ClientModel.GetAll();
            LoadClientList();

        }

        private void LoadClientList()
        {
            clientListCB.Items.Clear();
            List<string> clients = ClientModel.GetAll().Select(x => x.RealPerson.FirstName + " " + x.UniqueId.ToString()).ToList();
            clientListCB.Items.Add("");
            foreach (string item in clients)
            {
                clientListCB.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> clientUniqueId = clientListCB.SelectedItem.ToString().Split(new char[0]).ToList();
            if (String.IsNullOrEmpty(clientUniqueId.Last()))
            {
                return;
            }
            editClientFirstNameTB.Clear();
            editClientLastNameTB.Clear();
            editClientAddressTB.Clear();
            editClientContactTB.Clear();
            editCompanyName.Clear();
            Client client= new Client();
            client = client.Retrieve(clientUniqueId.Last());


            editClientType.SelectedItem = client.CustomerType;

            if (client.CustomerType == ClientType.Company)
            {
                editCompanyName.Text = client.RealPerson.FirstName;
                editClientFirstNameTB.Enabled = false;
                editClientLastNameTB.Enabled = false;
            } else
            {
                editClientFirstNameTB.Text = client.RealPerson.FirstName;
                editClientLastNameTB.Text = client.RealPerson.LastName;
                editCompanyName.Enabled = false;
            }

            editClientAddressTB.Text = client.RealPerson.Address;
            editClientContactTB.Text = client.RealPerson.ContactNumber;
            returnCustomer.Checked = client.IsReturnCustomer;
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            ClientType clientType;
            Enum.TryParse<ClientType>(customerTypeList.SelectedValue.ToString(), out clientType);

            if (String.IsNullOrEmpty(customerId.Text))
            {
                return;
            }

            Client client = new Client();
            client.CustomerType = clientType;
            client.UniqueId = Guid.Parse(customerId.Text);

            string contactNumber = clientContactTB.Text.Trim();
            string address = clientAddressTB.Text.Trim();

            if (String.IsNullOrEmpty(contactNumber) || String.IsNullOrEmpty(address))
            {
                return;
            }

            Person person = new Person();
            person.ContactNumber = contactNumber;
            person.Address = address;

            if (clientType == ClientType.Company)
            {
                string name = companyName.Text.Trim();
                person.FirstName = name;

            }
            else
            {
                string firstName = clientFirstNameTB.Text.Trim();
                string lastName = clientLastNameTB.Text.Trim();

                if (!String.IsNullOrEmpty(firstName) && !String.IsNullOrEmpty(lastName))
                {
                    person.FirstName = firstName;
                    person.LastName = lastName;   
                }
            }
            string id = person.Create();
            client.RealPerson = person;
            PersonModel.GetAll();
            client.RealPerson.Id = Int32.Parse(id);
            client.Create();
            LoadClientList();

            ClearClientAddFields();
            MessageBox.Show("Succefully added client.");
        }

        private void ClearClientAddFields()
        {
            //customerTypeList = ClientType.Individual;
            customerId.Clear();
            clientFirstNameTB.Clear();
            clientLastNameTB.Clear(); ;
            companyName.Clear();
            clientAddressTB.Clear();
            clientContactTB.Clear();
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            if (isEditActive)
            {
                isEditActive = false;
                MessageBox.Show("Edit has been deactivated.");
            } else
            {
                isEditActive = true;
                MessageBox.Show("Edit has been activated.");
            }
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            if (clientListCB.SelectedItem == null)
            {
                return;
            }
            List<string> clientUniqueId = clientListCB.SelectedItem.ToString().Split(new char[0]).ToList();
            if (String.IsNullOrEmpty(clientUniqueId.Last()))
            {
                return;
            }
            Client client = new Client();
            client = client.Retrieve(clientUniqueId.Last());

            client.RealPerson.Delete(client.RealPerson.Id.ToString());
            client.Delete(client.UniqueId.ToString());
            client = new Client();
            MessageBox.Show("Successfully deleted client.");
            LoadClientList();
        }

        private void updateClient_Click(object sender, EventArgs e)
        {
            if (isEditActive)
            {
                if (clientListCB.SelectedItem == null)
                {
                    MessageBox.Show("No client id has been selected.");
                    return;
                }
                List<string> clientUniqueId = clientListCB.SelectedItem.ToString().Split(new char[0]).ToList();
                if (String.IsNullOrEmpty(clientUniqueId.Last()))
                {
                    return;
                }
                Client client = new Client();
                client = client.Retrieve(clientUniqueId.Last());

                ClientType clientType;
                Enum.TryParse<ClientType>(editClientType.SelectedValue.ToString(), out clientType);

                client.CustomerType = clientType;
                client.IsReturnCustomer = returnCustomer.Checked;
                client.RealPerson.ContactNumber = editClientContactTB.Text.Trim();
                client.RealPerson.Address = editClientAddressTB.Text.Trim();

                if (clientType == ClientType.Company)
                {
                    string name = editCompanyName.Text.Trim();
                    client.RealPerson.FirstName = name;

                }
                else
                {
                    string firstName = editClientFirstNameTB.Text.Trim();
                    string lastName = editClientLastNameTB.Text.Trim();

                    if (!String.IsNullOrEmpty(firstName) && !String.IsNullOrEmpty(lastName))
                    {
                        client.RealPerson.FirstName = firstName;
                        client.RealPerson.LastName = lastName;
                    }
                }
                client.RealPerson.Update(client.RealPerson);
                client.Update(client);
                ClearEditFields();
                clientListCB.SelectedItem = "";
                client = new Client();
                MessageBox.Show("Succefully updated client.");
                isEditActive = false;
            }
            else
            {
                MessageBox.Show("Please click on edit to activate edit mode.");
            }
        }

        private void ClearEditFields()
        {
            editCompanyName.Text = "";
            editClientLastNameTB.Text = "";
            editClientAddressTB.Text = "";
            editClientContactTB.Text = "";
            editClientFirstNameTB.Text = "";
            returnCustomer.Checked = false;
        }

        private void generateCustomerId_Click(object sender, EventArgs e)
        {
            Guid uniqueId = Guid.NewGuid();

            customerId.Text = uniqueId.ToString();
        }

        private void customerTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientType clientType;
            Enum.TryParse<ClientType>(customerTypeList.SelectedValue.ToString(), out clientType);

            if (clientType == ClientType.Company)
            {
                clientFirstNameTB.Enabled = false;
                clientLastNameTB.Enabled = false;
                companyName.Enabled = true;
            }
            else
            {
                companyName.Enabled = false;
                clientFirstNameTB.Enabled = true;
                clientLastNameTB.Enabled = true;
            }
        }
    }
}
