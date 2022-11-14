using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database__Obligatorisk_.CRUD
{
    public class Delete
    {
        public static int DeleteFacility(SqlConnection connection, int facility_no)
        {
            Console.WriteLine("_______________________");
            Console.WriteLine("| Deleting A Facility |");
            Console.WriteLine("_______________________");
            Console.WriteLine();

            string deleteCommandString = $"DELETE FROM Facility  WHERE Facility_No = {facility_no}";

            SqlCommand command = new SqlCommand(deleteCommandString, connection);
            
            Console.WriteLine($"The facility with the ID of {facility_no} has been deleted");
            Console.WriteLine();
            
            int numberOfRowsAffected = command.ExecuteNonQuery();

            return numberOfRowsAffected;
        }

        public static int DeleteHotelFacility(SqlConnection connection, int hotelFacility_no)
        {
            Console.WriteLine("_______________________________");
            Console.WriteLine("| Deleting A Hotel & Facility |");
            Console.WriteLine("_______________________________");
            Console.WriteLine();

            string deleteCommandString = $"DELETE FROM Hotel_Facility  WHERE HotelFacility_No = {hotelFacility_no}";

            SqlCommand command = new SqlCommand(deleteCommandString, connection);

            Console.WriteLine($"The Hotel & Facility with the ID of {hotelFacility_no} has been deleted");
            Console.WriteLine();

            int numberOfRowsAffected = command.ExecuteNonQuery();

            return numberOfRowsAffected;
        }
    }
}
