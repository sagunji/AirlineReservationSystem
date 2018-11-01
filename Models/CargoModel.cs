using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineReservationSystem.DataClasses;
using System.Data.SQLite;

namespace AirlineReservationSystem.Models
{
    class CargoModel
    {
        public static List<Cargo> GetAll()
        {
            List<Cargo> cargos = new List<Cargo>();
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Cargo", m_dbConnection);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Cargo newCargo = new Cargo();
                    PlaneCarryType planeCarryType;
                    Enum.TryParse<PlaneCarryType>(reader["planeCarryType"].ToString(), out planeCarryType);
                    newCargo.CargoOn = planeCarryType;
                    newCargo.Weight = Int32.Parse(reader["weight"].ToString());
                    if (Int32.Parse(reader["isSecurityChecked"].ToString()) == 0)
                    {
                        newCargo.IsSecurityChecked = false;
                    }
                    else
                    {
                        newCargo.IsSecurityChecked = true;
                    }
                    newCargo.CargoId = reader["uniqueId"].ToString();
                    cargos.Add(newCargo);
                }
            }
            return cargos;
        }
    }
}
