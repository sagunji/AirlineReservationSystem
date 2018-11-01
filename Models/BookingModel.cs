using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineReservationSystem.DataClasses;
using System.Data.SQLite;

namespace AirlineReservationSystem.Models
{
    class BookingModel
    {
        public static List<Booking> GetAll()
        {
            List<Booking> bookings = new List<Booking>();
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Booking", m_dbConnection);

            return GetBookingObjects(command);
        }

        public static List<Booking> GetByClient(string clientID, bool showArchieved = false)
        {
            List<Booking> bookings = new List<Booking>();
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Booking where clientId=@clientId AND isArchieved=@isArchieved", m_dbConnection);
            command.Parameters.AddWithValue("clientId", clientID);
            command.Parameters.AddWithValue("isArchieved", showArchieved);

            return GetBookingObjects(command);
        }
        private static List<Booking> GetBookingObjects(SQLiteCommand command)
        {
            List<Booking> bookings = new List<Booking>();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Booking booking = new Booking();
                    try
                    {
                        booking.UniqueId = Guid.Parse(reader["uniqueId"].ToString());
                    }
                    catch (Exception exp)
                    {
                        continue;
                    }

                    booking.FromLocation = reader["fromLocation"].ToString();
                    booking.ToLocation = reader["toLocation"].ToString();
                    booking.DepartureTime = DateTime.Parse(reader["departureTime"].ToString());
                    booking.ArrivalTime = DateTime.Parse(reader["arrivalTime"].ToString());
                    List<string> cargoIds = reader["cargoId"].ToString().Split(',').ToList<string>();
                    List<Cargo> cargo = new List<Cargo>();
                    foreach (string id in cargoIds)
                    {
                        Cargo newCargo = new Cargo();
                        newCargo.CargoId = id;
                        newCargo = newCargo.Retrieve(id);
                        cargo.Add(newCargo);
                    }
                    booking.Cargos = cargo;
                    try
                    {
                        Client client = new Client();
                        client.UniqueId = Guid.Parse(reader["clientId"].ToString());
                        client = client.Retrieve(reader["clientId"].ToString());
                        booking.BookedBy = client;

                    }
                    catch (Exception exp)
                    {
                        continue;
                    }

                    booking.CargoManifest = reader["cargoManifest"].ToString();
                    booking.AssignedPlane = PlaneModel.GetPlaneByIdentity(reader["planeId"].ToString());
                    Passenger pass = new Passenger();
                    pass.ID = reader["passengerId"].ToString();
                    booking.Passenger = pass.Retrieve(pass.ID);
                    bookings.Add(booking);
                }
            }
            return bookings;
        }

        public static Booking GetBookingById(string identity)
        {
            List<Booking> bookings = new List<Booking>();
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Booking where uniqueId=@uniqueId", m_dbConnection);
            command.Parameters.AddWithValue("uniqueId", identity);

            return GetBookingObjects(command).First();
        }
    }
}
