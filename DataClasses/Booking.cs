using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using AirlineReservationSystem.Interfaces;
using AirlineReservationSystem.Models;

namespace AirlineReservationSystem.DataClasses
{
    /// <summary>
    /// Booking class
    /// Contains inforamtion for a simgle booking
    /// </summary>
    class Booking: IMaintanableCRUD<Booking>
    {
        Plane assignedPlane = new Plane();
        Client bookedBy = new Client();
        List<Cargo> cargos = new List<Cargo>();
        Passenger passenger= new Passenger();
        string fromLocation = "";
        string toLocation = "";
        Guid uniqueId = Guid.Empty;
        bool isArchieved = false;

        DateTime departureTime = DateTime.Now;
        DateTime arrivalTime = DateTime.Now;

        string cargoManifest = "";

        public Plane AssignedPlane
        {
            get
            {
                return assignedPlane;
            }
            set
            {
                assignedPlane = value;
            }
        }

        public Client BookedBy
        {
            get
            {
                return bookedBy;
            }
            set
            {
                bookedBy = value;
            }
        }

        public List<Cargo> Cargos
        {
            get
            {
                return cargos;
            }
            set
            {
                cargos = value;
            }
        }

        public Passenger Passenger
        {
            get
            {
                return passenger;
            }
            set
            {
                passenger = value;
            }
        }

        public string FromLocation
        {
            get
            {
                return fromLocation;
            }
            set
            {
                fromLocation = value;
            }
        }

        public string ToLocation
        {
            get
            {
                return toLocation;
            }
            set
            {
                toLocation = value;
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

        public DateTime DepartureTime
        {
            get
            {
                return departureTime;
            }
            set
            {
                departureTime = value;
            }
        }

        public DateTime ArrivalTime
        {
            get
            {
                return arrivalTime;
            }
            set
            {
                arrivalTime = value;
            }
        }

        public string CargoManifest
        {
            get
            {
                return cargoManifest;
            }
            set
            {
                cargoManifest = value;
            }
        }

        public bool IsArchieved
        {
            get
            {
                return isArchieved;
            }
            set
            {
                isArchieved = value;
            }
        }

        private string CombineCargoList()
        {
            return Cargos.ToString();
        }

        private string CombineCargoIds()
        {
            string cargs = String.Join(",", Cargos.Select(x => x.CargoId).ToList());
            return cargs;
        }

        public int GetTotalCargoWeight()
        {
            int weight = 0;
            foreach (Cargo cargo in Cargos)
            {
                weight += cargo.Weight;
            }
            return weight;
        }

        public string Create()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Booking (uniqueId, planeId, clientId, cargoId, fromLocation, toLocation, arrivalTime, departureTime, cargoManifest, passengerId) VALUES (@uniqueId, @planeId, @clientId, @cargoId, @fromLocation, @toLocation, @arrivalTime, @departureTime, @cargoManifest, @passengerId)", m_dbConnection);
            insertSQL.Parameters.AddWithValue("uniqueId", this.UniqueId.ToString());
            insertSQL.Parameters.AddWithValue("planeId", this.assignedPlane.Identity);
            insertSQL.Parameters.AddWithValue("clientId", bookedBy.UniqueId.ToString());
            insertSQL.Parameters.AddWithValue("cargoId", CombineCargoIds());
            insertSQL.Parameters.AddWithValue("fromLocation", this.fromLocation);
            insertSQL.Parameters.AddWithValue("toLocation", this.toLocation);
            insertSQL.Parameters.AddWithValue("arrivalTime", this.arrivalTime);
            insertSQL.Parameters.AddWithValue("departureTime", this.departureTime);
            insertSQL.Parameters.AddWithValue("cargoManifest", this.CargoManifest);
            insertSQL.Parameters.AddWithValue("passengerId", this.Passenger.ID);
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
        public void Update(Booking booking)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand updateSQL = new SQLiteCommand(@"Update Booking 
                                                        SET planeId=@planeId, 
                                                        clientId=@clientId,
                                                        cargoId=@cargoId,
                                                        fromLocation= @fromLocation,
                                                        toLocation=@toLocation,
                                                        arrivalTime=@arrivalTime,
                                                        departureTime=@depatureTime,
                                                        cargoManifest=@cargoManifest,
                                                        isArchieved=@isArchieved
                                                        where uniqueId=@uniqueId", m_dbConnection);
            updateSQL.Parameters.AddWithValue("uniqueId", booking.UniqueId.ToString());
            updateSQL.Parameters.AddWithValue("planeId", booking.assignedPlane.Identity);
            updateSQL.Parameters.AddWithValue("clientId", booking.bookedBy.UniqueId.ToString());
            updateSQL.Parameters.AddWithValue("cargoId", booking.CombineCargoIds());
            updateSQL.Parameters.AddWithValue("fromLocation", booking.fromLocation);
            updateSQL.Parameters.AddWithValue("toLocation", booking.toLocation);
            updateSQL.Parameters.AddWithValue("arrivalTime", booking.arrivalTime);
            updateSQL.Parameters.AddWithValue("depatureTime", booking.departureTime);
            updateSQL.Parameters.AddWithValue("cargoManifest", booking.CargoManifest);
            updateSQL.Parameters.AddWithValue("isArchieved", booking.IsArchieved);
            try
            {
                updateSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Booking Retrieve(string identity)
        {
            return BookingModel.GetBookingById(identity);
        }
        public void Delete(string identity)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand deleteSQL = new SQLiteCommand("Delete from Booking where uniqueId=@identity", m_dbConnection);
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
    }
}
