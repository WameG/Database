using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database__Obligatorisk_.Crud
{
    public class Create
    {
        public static int insertFacility(SqlConnection connection, Facility facility)
        {
            Console.WriteLine("_______________________");
            Console.WriteLine("| Creating A Facility |");
            Console.WriteLine("_______________________");
            Console.WriteLine();

            string insertCommandString = $"INSERT INTO Facility VALUES({facility.Facility_No}, '{facility.Name}')";

            SqlCommand command = new SqlCommand(insertCommandString, connection);

            Console.WriteLine($"A Facility has been created with the following ID: {facility.Facility_No} - Name: {facility.Name}");
            Console.WriteLine();

            int numberOfRowsAffected = command.ExecuteNonQuery();

            return numberOfRowsAffected;
        }

        public static int addFacilitiesToHotel(SqlConnection connection, HotelFacility hotelFacility)
        {
            Console.WriteLine("___________________________");
            Console.WriteLine("| Adding A Hotel & Facility |");
            Console.WriteLine("___________________________");
            Console.WriteLine();

            string insertCommandString = $"INSERT INTO Hotel_Facility VALUES({hotelFacility.HotelFacility_No}, {hotelFacility.Facility_No}, '{hotelFacility.Hotel_No}')";

            SqlCommand command = new SqlCommand(insertCommandString, connection);

            Console.WriteLine($"A new Hotel & Facility with the ID of {hotelFacility.HotelFacility_No} has been added");
            Console.WriteLine();

            int numberOfRowsAffected = command.ExecuteNonQuery();

            return numberOfRowsAffected;
        }
    }
}
