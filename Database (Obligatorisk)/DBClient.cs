using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Database__Obligatorisk_.Crud;
using Database__Obligatorisk_.CRUD;

namespace Database__Obligatorisk_
{
    class DBClient
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyHotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Start()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Console.WriteLine();
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("                        CRUD On Facility Table");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine();

                // Creating A Facility

                Facility TestData1 = new Facility()
                {
                    Facility_No = IDGenerator.GetMaxFacilityNo(connection, "Facility", "Facility_No") + 1,
                    Name = "Test",
                };

                Create.insertFacility(connection, TestData1);


                Read.ListAllFacilities(connection);


                // Updating A Facility

                Facility UpdateFacility = new Facility()
                {
                    Facility_No = 5,
                    Name = "Fitness"
                };

                Update.UpdateFacility(connection, UpdateFacility);

                Read.ListAllFacilities(connection);

                // Deleting A Facility

                Delete.DeleteFacility(connection, 5);

                Read.ListAllFacilities(connection);

                Console.WriteLine();
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("                 CRUD On Hotel & Facility Table");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine();

                //HOTEL_FACILITY
                // Create Hotel & Facility

                HotelFacility newHotelFacility = new HotelFacility()
                {
                    HotelFacility_No = IDGenerator.GetMaxFacilityNo(connection, "Hotel_Facility", "HotelFacility_No") + 1,
                    Facility_No = 1,
                    Hotel_No = 2
                };

                Create.addFacilitiesToHotel(connection, newHotelFacility);

                Read.ListAllHotelFacility(connection);

                //Update Hotel & Facility


                HotelFacility updateHotelFacility = new HotelFacility()
                {
                    HotelFacility_No = 2,
                    Facility_No = 1,
                    Hotel_No = 3
                };

                Update.UpdateHotelFacility(connection, updateHotelFacility);

                Read.ListAllHotelFacility(connection);

                // Delete Hotel & Facility

                Delete.DeleteHotelFacility(connection, 2);

                Read.ListAllHotelFacility(connection);
            }
        }

    }
}
