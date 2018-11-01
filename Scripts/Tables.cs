using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Scripts
{
    /// <summary>
    /// This class here is an static class which will create a base for database table for CRUD operations
    /// </summary>
    class Tables
    {
        static string createTableIfNotCreated = "CREATE TABLE IF NOT EXISTS ";

        /// <summary>
        /// Create Booking table
        /// </summary>
        public static string CreateBookingTable
        {
            get
            {
                return createTableIfNotCreated + @"Booking (
                        id integer Primary Key AUTOINCREMENT,
                        uniqueId varchar(255) UNIQUE NOT NULL,
                        planeId varchar(255),
                        clientId varchar(255),
                        cargoId text,
                        passengerId varchar(255),
                        fromLocation varchar(255),
                        toLocation varchar(255),
                        arrivalTime text,
                        departureTime text,
                        isArchieved integer default 0,
                        cargoManifest text
                )";
            }
        }

        public static string DropBookingTable
        {
            get
            {
                return @"Drop table Booking";
            }
        }

        /// <summary>
        /// Creates Client table
        /// </summary>
        public static string CreateClientTable
        {
            get
            {
                return createTableIfNotCreated + @"Client (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    uniqueId varchar(50) UNIQUE NOT NULL,
                    personId integer,
                    type varchar(20),
                    isOnFlight integer default 1,
                    isReturnCustomer integer default 0,
                    cargoId varchar(255),
                    bookingId nvarchar(255)
                )";
            }
        }

        public static string DropClientTable
        {
            get
            {
                return @"Drop table Client";
            }
        }

        /// <summary>
        /// Creates Plane table
        /// </summary>
        public static string CreatePlaneTable
        {
            get
            {
                return createTableIfNotCreated + @"Plane (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    identity varchar(255) UNIQUE NOT NULL,
                    type varchar(20),
                    maxPassenger integer,
                    maxCargoWeight integer,
                    isRetired integer default 0,
                    isArchieved integer default 0
                )";
            }
        }

        public static string DropPlaneTable
        {
            get
            {
                return @"Drop table Plane";
            }
        }

        /// <summary>
        /// Create Cargo table
        /// </summary>
        public static string CreateCargoTable
        {
            get
            {
                return createTableIfNotCreated + @"Cargo (
                    id integer Primary Key AUTOINCREMENT,
                    planeCarryType varchar(50),
                    weight integer,
                    isSecurityChecked integer default 0,
                    uniqueId varchar(255)
                )";
            }
        }

        public static string DropCargoTable
        {
            get
            {
                return @"Drop table Cargo";
            }
        }
        /// <summary>
        /// Creates Passenger table
        /// </summary>
        public static string CreatePassengerTable
        {
            get
            {
                return createTableIfNotCreated + @"Passenger (
                    id integer Primary Key AUTOINCREMENT,
                    clientId varchar(255),
                    name varchar(255),
                    contact varchar(255)
                )";
            }
        }
        public static string DropPassengerTable
        {
            get
            {
                return @"Drop table Passenger";
            }
        }
        /// <summary>
        /// Creates Person table
        /// </summary>
        public static string CreatePersonTable
        {
            get
            {
                return createTableIfNotCreated + @"Person (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    firstName varchar(255),
                    lastName varchar(255),
                    contactNumber varchar(255),
                    address varchar(255)
                )";
            }
        }
        public static string DropPersonTable
        {
            get
            {
                return @"Drop table Person";
            }
        }
    }
}
