using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using AirlineReservationSystem.DataClasses;

namespace AirlineReservationSystem.Models
{
    class ClientModel
    {
        public static List<Client> GetAll()
        {
            List<Client> clients = new List<Client>();

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Client, Person where Client.personId = Person.id", m_dbConnection);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Client client = new Client();
                    Person person = new Person();
                    person.Id = Int32.Parse(reader["personId"].ToString());
                    person.FirstName = reader["firstName"].ToString();
                    person.LastName = reader["lastName"].ToString();
                    person.ContactNumber = reader["contactNumber"].ToString();
                    person.Address = reader["address"].ToString();

                    client.RealPerson = person;

                    var abc = reader["uniqueId"].ToString();

                    client.UniqueId = Guid.Parse(reader["uniqueId"].ToString());

                    ClientType clientType;
                    Enum.TryParse<ClientType>(reader["type"].ToString(), out clientType);
                    client.CustomerType = clientType;
                    clients.Add(client);
                }
            }
            return clients;
        }
    }
}
