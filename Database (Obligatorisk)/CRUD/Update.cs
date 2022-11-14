using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database__Obligatorisk_.CRUD
{
    public class Update
    {
        public static int UpdateFacility(SqlConnection connection, Facility facility)
        {
            Console.WriteLine("_______________________");
            Console.WriteLine("| Updating A Facility |");
            Console.WriteLine("_______________________");
            Console.WriteLine();

            string updateCommandString = $"UPDATE Facility SET Name='{facility.Name}' WHERE Facility_No = {facility.Facility_No}";

            SqlCommand command = new SqlCommand(updateCommandString, connection);
            Console.WriteLine($"Updating the Facility with the ID of {facility.Facility_No} to Name: {facility.Name}");
            Console.WriteLine();
            int numberOfRowsAffected = command.ExecuteNonQuery();

            return numberOfRowsAffected;
        }
        public static int UpdateHotelFacility(SqlConnection connection, HotelFacility hotelFacility)
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("| Updating A Hotel & Facility |");
            Console.WriteLine("________________________________");
            Console.WriteLine();

            string updateCommandString = $"UPDATE Hotel_Facility SET Facility_No='{hotelFacility.Facility_No}', Hotel_No='{hotelFacility.Hotel_No}' WHERE HotelFacility_No = {hotelFacility.HotelFacility_No}";

            SqlCommand command = new SqlCommand(updateCommandString, connection);
            Console.WriteLine($"Updating the Hotel & Facility with the ID of {hotelFacility.HotelFacility_No} to Facility_No: {hotelFacility.Facility_No} & Hotel_No: {hotelFacility.Hotel_No}");
            Console.WriteLine();
            int numberOfRowsAffected = command.ExecuteNonQuery();

            return numberOfRowsAffected;
        }
    }
}
