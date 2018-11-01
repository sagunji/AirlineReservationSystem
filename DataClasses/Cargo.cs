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
    /// Cargo Class
    /// defines a cargo property
    /// </summary>
    class Cargo: IMaintanableCRUD<Cargo>
    {
        PlaneCarryType cargoOn = PlaneCarryType.Cargo;
        // firstly every cargo is labelled as security unchecked
        bool isSecurityChecked = false;
        int weight = 0;
        string cargoId = "";

        public PlaneCarryType CargoOn
        {
            get
            {
                return cargoOn;
            }
            set
            {
                cargoOn = value;
            }
        }

        public bool IsSecurityChecked
        {
            get
            {
                return isSecurityChecked;
            }
            set
            {
                isSecurityChecked = value; 
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public string CargoId
        {
            get
            {
                return cargoId;
            }
            set
            {
                cargoId = value;
            }
        }
        public string Create()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Cargo (planeCarryType, weight, isSecurityChecked, uniqueId) VALUES (@planeCarryType, @weight, @isSecurityChecked, @uniqueId)", m_dbConnection);
            insertSQL.Parameters.AddWithValue("planeCarryType", this.CargoOn);
            insertSQL.Parameters.AddWithValue("weight", this.weight);
            insertSQL.Parameters.AddWithValue("isSecurityChecked", this.IsSecurityChecked);
            insertSQL.Parameters.AddWithValue("uniqueId", this.CargoId);
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
        public void Update(Cargo cargo)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand updateSQL = new SQLiteCommand("Update Cargo SET planeCarryType = @planeCarryType, weight = @weight, isSecurityChecked = @isSecurityChecked where uniqueId=@uniqueId", m_dbConnection);
            updateSQL.Parameters.AddWithValue("planeCarryType", cargo.CargoOn);
            updateSQL.Parameters.AddWithValue("weight", cargo.weight);
            updateSQL.Parameters.AddWithValue("isSecurityChecked", cargo.IsSecurityChecked);
            updateSQL.Parameters.AddWithValue("uniqueId", cargo.CargoId);
            try
            {
                updateSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Cargo Retrieve(string identity)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("select * from Cargo where uniqueId = @identity", m_dbConnection);
            command.Parameters.AddWithValue("identity", identity);
            Cargo newCargo = new Cargo();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
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
                    newCargo.CargoId = identity;
                }
            }
            m_dbConnection.Close();
            return newCargo;
        }
        public void Delete(string identity)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand deleteSQL = new SQLiteCommand("Delete from Cargo where cargoId=@identity", m_dbConnection);
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
