using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using AirlineReservationSystem.Interfaces;

namespace AirlineReservationSystem.DataClasses
{
    /// <summary>
    /// Passenger class
    /// defines property of client class
    /// </summary>
    class Passenger: IMaintanableCRUD<Passenger>
    {
        string clientId = "";
        Person traveller = new Person();
        string id = "0";

        public string ID
        {
            get
            {
                return id
                    ;
            }
            set
            {
                id = value;
            }
        }

        public string ClientId
        {
            get
            {
                return clientId;
            }
            set
            {
                clientId = value;
            }
        }
        public Person Traveller
        {
            get
            {
                return traveller;
            }
            set
            {
                traveller = value;
            }
        }
        public string Create()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Passenger (clientId, name, contact) VALUES (@clientId, @name, @contact)", m_dbConnection);
            insertSQL.Parameters.AddWithValue("clientId", this.ClientId);
            insertSQL.Parameters.AddWithValue("name", this.Traveller.FirstName);
            insertSQL.Parameters.AddWithValue("contact", this.Traveller.ContactNumber);
            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return "Yes";
        }
        public void Update(Passenger traveller)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand updateSQL = new SQLiteCommand("Update Passenger SET clientId=@clientId, name = @name, contact = @contact where id=@passengerId", m_dbConnection);
            updateSQL.Parameters.AddWithValue("clientId", this.ClientId);
            updateSQL.Parameters.AddWithValue("name", this.Traveller.FirstName);
            updateSQL.Parameters.AddWithValue("contact", this.Traveller.ContactNumber);
            updateSQL.Parameters.AddWithValue("contact", this.Traveller.ContactNumber);
            updateSQL.Parameters.AddWithValue("passengerId", this.id);
            try
            {
                updateSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Passenger Retrieve(string identity)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Passenger where id = @id", m_dbConnection);
            command.Parameters.AddWithValue("id", identity);
            Passenger newPassenger = new Passenger();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    newPassenger.ID = reader["id"].ToString();
                    Person pass = new Person();
                    pass.FirstName = reader["name"].ToString();
                    pass.ContactNumber = reader["contact"].ToString();
                    newPassenger.Traveller = pass;
                    newPassenger.ClientId = reader["clientId"].ToString();
                }
            }
            m_dbConnection.Close();
            return newPassenger;
        }
        public void Delete(string identity)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand deleteSQL = new SQLiteCommand("Delete from Passenger where id=@identity", m_dbConnection);
            deleteSQL.Parameters.AddWithValue("identity", identity);
            try
            {
                deleteSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string getIdOfLastTraveller()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Passenger order by id DESC LIMIT 1", m_dbConnection);
            Passenger newPassenger = new Passenger();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return reader["id"].ToString();
                }
            }
            m_dbConnection.Close();
            return "";
        }
    }
}
