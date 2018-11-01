using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineReservationSystem.DataClasses;
using System.Data.SQLite;
using AirlineReservationSystem.Interfaces;

namespace AirlineReservationSystem.DataClasses
{
    public enum ClientType
    {
        Individual = 1,
        Company = 2
    }
    /// <summary>
    /// Client class
    /// defines client property
    /// </summary>
    class Client: IMaintanableCRUD<Client>
    {
        bool isRetunCustomer = false;
        Guid uniqueId = Guid.Empty;
        // Detail of person in the flight if any
        Person realClient = new Person();
        ClientType customerType = ClientType.Individual;
        // by default the client will be on flight
        bool isOnFlight = true;

        Cargo clientCargo = new Cargo();

        public bool IsReturnCustomer
        {
            get
            {
                return isRetunCustomer;
            }
            set
            {
                isRetunCustomer = value;
            }
        }

        public Guid UniqueId
        {
            get
            {
                return uniqueId;
            }
            set
            {
                uniqueId = value;
            }
        }

        public Person RealPerson
        {
            get
            {
                return realClient;
            }
            set
            {
                realClient = value;
            }
        }

        public ClientType CustomerType
        {
            get
            {
                return customerType;
            }
            set
            {
                customerType = value;
            }
        }

        public bool IsOnFlight
        {
            get
            {
                return isOnFlight;
            }
            set
            {
                value = isOnFlight;
            }
        }

        public Cargo ClientCargo
        {
            get
            {
                return clientCargo;
            }
            set
            {
                clientCargo = value;
            }
        }
        public string Create()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Client (uniqueId, personId, type) VALUES (@uniqueId, @personId, @type)", m_dbConnection);
            insertSQL.Parameters.AddWithValue("uniqueId", this.UniqueId.ToString());
            insertSQL.Parameters.AddWithValue("personId", this.RealPerson.Id);
            insertSQL.Parameters.AddWithValue("type", this.CustomerType);     
            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return "yes";
        }
        public void Update(Client client)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand updateSQL = new SQLiteCommand("UPDATE Client SET type = @type, isReturnCustomer = @returnCustomer WHERE uniqueId=@uniqueId", m_dbConnection);
            updateSQL.Parameters.AddWithValue("uniqueId", client.UniqueId.ToString());
            updateSQL.Parameters.AddWithValue("returnCustomer", client.IsReturnCustomer);
            updateSQL.Parameters.AddWithValue("type", client.CustomerType.ToString());
            try
            {
                updateSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Client Retrieve(string identity)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Client, Person where uniqueId = @identity and Person.id=Client.personId", m_dbConnection);
            command.Parameters.AddWithValue("identity", identity);
            Client client = new Client();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Person person = new Person();
                    person.Id = Int32.Parse(reader["personId"].ToString());
                    person.FirstName = reader["firstName"].ToString();
                    person.LastName = reader["lastName"].ToString();
                    person.ContactNumber = reader["contactNumber"].ToString();
                    person.Address = reader["address"].ToString();

                    client.RealPerson = person;

                    client.UniqueId = Guid.Parse(reader["uniqueId"].ToString());

                    ClientType clientType;
                    Enum.TryParse<ClientType>(reader["type"].ToString(), out clientType);
                    client.CustomerType = clientType;
                    if (Int32.Parse(reader["isReturnCustomer"].ToString()) == 0)
                    {
                        client.IsReturnCustomer = false;
                    }
                    else
                    {
                        client.IsReturnCustomer = true;
                    }
                }
            }
            m_dbConnection.Close();
            return client;
        }
        public void Delete(string identity) {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("delete from Client where uniqueId = @uniqueId", m_dbConnection);
            command.Parameters.AddWithValue("uniqueId", identity);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            m_dbConnection.Close();
        }
    }
}
