using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using AirlineReservationSystem.DataClasses;

namespace AirlineReservationSystem.Models
{
    class PlaneModel
    {
        public static List<Plane> GetAll(bool isArchieved = false)
        {
            List<Plane> planes = new List<Plane>();

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Plane where isArchieved=@isArchieved", m_dbConnection);
            command.Parameters.AddWithValue("isArchieved", isArchieved ? 1 : 0);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Plane plane = new Plane();
                    PlaneCarryType planeCarryType;
                    Enum.TryParse<PlaneCarryType>(reader["type"].ToString(), out planeCarryType);
                    plane.Identity = reader["identity"].ToString();
                    plane.CanCarry = planeCarryType;
                    plane.MaxCargo = Int32.Parse(reader["maxCargoWeight"].ToString());
                    plane.MaxPassenger = Int32.Parse(reader["maxPassenger"].ToString());

                    if (Int32.Parse(reader["isRetired"].ToString()) == 0)
                    {
                        plane.IsRetired = false;
                    } else
                    {
                        plane.IsRetired = true;
                    }
                    if (Int32.Parse(reader["isArchieved"].ToString()) == 0)
                    {
                        plane.IsArchieved = false;
                    }
                    else
                    {
                        plane.IsArchieved = true;
                    }

                    planes.Add(plane);
                }
            }
            m_dbConnection.Close();
            return planes;
        }

        public static Plane GetPlaneByIdentity(string identity)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Plane where identity = @identity LIMIT 1", m_dbConnection);
            command.Parameters.AddWithValue("identity", identity);
            Plane plane = new Plane();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    PlaneCarryType planeCarryType;
                    Enum.TryParse<PlaneCarryType>(reader["type"].ToString(), out planeCarryType);
                    plane.Identity = reader["identity"].ToString();
                    plane.CanCarry = planeCarryType; 
                    plane.MaxCargo = Int32.Parse(reader["maxCargoWeight"].ToString());  
                    plane.MaxPassenger = Int32.Parse(reader["maxPassenger"].ToString());
                    if (Int32.Parse(reader["isRetired"].ToString()) == 0)
                    {
                        plane.IsRetired = false;
                    }
                    else
                    {
                        plane.IsRetired = true;
                    }
                    if (Int32.Parse(reader["isArchieved"].ToString()) == 0)
                    {
                        plane.IsArchieved = false;
                    }
                    else
                    {
                        plane.IsArchieved = true;
                    }

                }
            }
            m_dbConnection.Close();
            return plane;
        }

        public static bool IsPlaneAlreadyRegistered(string identity) 
        {
            bool hasRows = false;
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Plane where identity = @identity LIMIT 1", m_dbConnection);
            command.Parameters.AddWithValue("identity", identity);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                 hasRows = reader.HasRows;
            }
            m_dbConnection.Close();
            return hasRows;
        }

        public static bool DeletePlane(string identity)
        {
            if (IsPlaneAlreadyRegistered(identity))
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
                m_dbConnection.Open();
                SQLiteCommand command = new SQLiteCommand("delete * from Plane where identity = @identity", m_dbConnection);
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
                return true;
            }
            else
            {
                return false;
            }
        }

       public static void RemainingSeats(string identity)
        {
            Plane plane = GetPlaneByIdentity(identity);
            //plane.MaxPassenger=
        }
    }
}
