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
    /// Person class 
    /// defines 
    /// </summary>
    class Person : IMaintanableCRUD<Person>
    {
        string firstName = "";
        string lastName = "";
        string contactNumber = "";
        string address = "";
        int id = 0;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }
            set
            {
                contactNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Create()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Person (firstName, lastName, contactNumber, address) VALUES (@firstName, @lastName, @contactNumber, @address)", m_dbConnection);
            insertSQL.Parameters.AddWithValue("firstName", this.firstName);
            insertSQL.Parameters.AddWithValue("lastName", this.lastName);
            insertSQL.Parameters.AddWithValue("contactNumber", this.contactNumber);
            insertSQL.Parameters.AddWithValue("address", this.address);
            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return GetLastId();
        }

        public string GetLastId()
        {
            string id = "";
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * from Person order by id DESC LIMIT 1", m_dbConnection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    id = reader["id"].ToString();
                }
            }
            m_dbConnection.Close();
            return id;
        }

        public void Update(Person person)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand updateSQL = new SQLiteCommand("UPDATE Person SET firstName = @firstName, lastName = @lastName, contactNumber = @contactNumber, address = @address  WHERE id=@id", m_dbConnection);
            updateSQL.Parameters.AddWithValue("id", person.id);
            updateSQL.Parameters.AddWithValue("firstName", person.FirstName);
            updateSQL.Parameters.AddWithValue("lastName", person.LastName);
            updateSQL.Parameters.AddWithValue("contactNumber", person.ContactNumber);
            updateSQL.Parameters.AddWithValue("address", person.Address);
            try
            {
                updateSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Person Retrieve(string identity)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Person where identity = @identity", m_dbConnection);
            command.Parameters.AddWithValue("identity", Int32.Parse(identity));
            Person newPerson = new Person();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    newPerson.FirstName = reader["firstName"].ToString();
                    newPerson.LastName = reader["lastName"].ToString();
                    newPerson.ContactNumber= reader["contactNumber"].ToString();
                    newPerson.Address = reader["address"].ToString();
                }
            }
            m_dbConnection.Close();
            return newPerson;
        }
        public void Delete(string identity) {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("delete from Person where id = @identity", m_dbConnection);
            command.Parameters.AddWithValue("identity", Int32.Parse(identity));
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
