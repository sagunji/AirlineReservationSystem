using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using AirlineReservationSystem.DataClasses;

namespace AirlineReservationSystem.Models
{
    class PersonModel
    {
        public static List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Person", m_dbConnection);
            
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Person person = new Person();
                    person.Id = Convert.ToInt32(reader["id"].ToString());
                    person.FirstName = reader["firstName"].ToString();
                    person.LastName = reader["lastName"].ToString();
                    person.ContactNumber = reader["contactNumber"].ToString();
                    person.Address = reader["address"].ToString();
                    persons.Add(person);
                }
            }
            return persons;
        }
    }
}
