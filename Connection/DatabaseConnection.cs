using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using AirlineReservationSystem.Scripts;
using System.Windows.Forms;

namespace AirlineReservationSystem.Connection
{
    static class DatabaseConnection
    {
        static SQLiteConnection m_dbConnection;
        public static void CreateDatabase()
        {
            // Creates a new database of given name
            SQLiteConnection.CreateFile("ARSDatabase.sqlite");
        }
        

        /// <summary>
        /// Creates tables
        /// </summary>
        public static void CreateTables()
        {
            m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(Tables.CreateBookingTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.CreateCargoTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.CreateClientTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.CreatePassengerTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.CreatePersonTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.CreatePlaneTable, m_dbConnection);
                command.ExecuteNonQuery();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            m_dbConnection.Close();
        }

        /// <summary>
        /// Drop Tables
        /// </summary>
        public static void DropTables()
        {
            m_dbConnection = new SQLiteConnection("Data Source=ARSDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(Tables.DropBookingTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.DropCargoTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.DropClientTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.DropPassengerTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.DropPersonTable, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(Tables.DropPlaneTable, m_dbConnection);
                command.ExecuteNonQuery();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.InnerException.ToString());
            }
            m_dbConnection.Close();
        }

    }
}
