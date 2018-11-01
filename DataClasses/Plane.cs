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
    public enum PlaneCarryType
    {
        Cargo = 1,
        Passenger = 2,
        Both = 3
    }
    class Plane: IMaintanableCRUD<Plane>
    {
        string identity = "";
        PlaneCarryType defaultCarryType = PlaneCarryType.Passenger;
        int maxPassenger = 0;
        int maxCargoInKg = 0;

        bool isRetired = false;
        bool isArchieved = false;

        public string Identity {
            get
            {
                return identity;
            }
            set {
                identity = value;
            }
        }
        public PlaneCarryType CanCarry {
            get
            {
                return defaultCarryType;
            }
            set
            {
                defaultCarryType = value;
            }
        }

        public int MaxPassenger {
            get
            {
                return maxPassenger;
            }
            set
            {
                maxPassenger = value;
            }
        }
        public int MaxCargo {
            get
            {
                return maxCargoInKg;
            }
            set
            {
                maxCargoInKg = value;
            }
        }
        public bool IsRetired {
            get
            {
                return isRetired;
            }
            set
            {
                isRetired = value;
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

        public string Create() {
            if (PlaneModel.IsPlaneAlreadyRegistered(this.Identity))
            {
                return "No";
            }
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Plane (identity, type, maxCargoWeight, maxPassenger, isRetired, isArchieved) VALUES (@identity, @type, @maxCargoWeight, @maxPassenger, @isRetired, @isArchieved)", m_dbConnection);
            insertSQL.Parameters.AddWithValue("identity", this.Identity);
            insertSQL.Parameters.AddWithValue("type",this.CanCarry);
            insertSQL.Parameters.AddWithValue("maxCargoWeight", this.MaxCargo);
            insertSQL.Parameters.AddWithValue("maxPassenger", this.MaxPassenger);
            insertSQL.Parameters.AddWithValue("isRetired", this.IsRetired);
            insertSQL.Parameters.AddWithValue("isArchieved", this.IsArchieved);
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
        public void Update(Plane plane) {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand updateSQL = new SQLiteCommand("UPDATE Plane SET type = @type, maxCargoWeight = @maxCargoWeight, maxPassenger = @maxPassenger, isRetired = @isRetired, isArchieved = @isArchieved) WHERE identity=@identity", m_dbConnection);
            updateSQL.Parameters.AddWithValue("type", this.CanCarry);
            updateSQL.Parameters.AddWithValue("maxCargoWeight", this.MaxCargo);
            updateSQL.Parameters.AddWithValue("maxPassenger", this.MaxPassenger);
            updateSQL.Parameters.AddWithValue("isRetired", this.IsRetired);
            updateSQL.Parameters.AddWithValue("isArchieved", this.IsArchieved);
            updateSQL.Parameters.AddWithValue("identity", this.identity);
            try
            {
                updateSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Plane Retrieve(string identity) {
            
            return new Plane();
        }
        public void Delete(string identity) {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("delete from Plane where identity = @identity", m_dbConnection);
            command.Parameters.AddWithValue("identity", identity);
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
