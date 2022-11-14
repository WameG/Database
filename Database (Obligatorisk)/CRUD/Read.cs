using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database__Obligatorisk_.CRUD
{
    public class Read
    {
        public static List<Facility> ListAllFacilities(SqlConnection connection)
        {
            string queryStringAllFacilities = "SELECT * FROM Facility";

            SqlCommand command = new SqlCommand(queryStringAllFacilities, connection);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("Listing All Facilities:");

            if (!reader.HasRows)
            {
                Console.WriteLine("No facilities in database");
                reader.Close();

                return null;
            }

            List<Facility> Facilities = new List<Facility>();
            while (reader.Read())
            {
                Facility nextFacility = new Facility()
                {
                    Facility_No = reader.GetInt32(0),
                    Name = reader.GetString(1),
                };

                Facilities.Add(nextFacility);

                Console.WriteLine(nextFacility);
            }

            reader.Close();
            Console.WriteLine();

            return Facilities;
        }
        
        public static List<HotelFacility> ListAllHotelFacility(SqlConnection connection)
        {
            string queryStringAllFacilities = "SELECT * FROM Hotel_Facility";

            SqlCommand command = new SqlCommand(queryStringAllFacilities, connection);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("Listing All Hotel & Facility:");

            if (!reader.HasRows)
            {
                Console.WriteLine("No Hotel & Facility in database");
                reader.Close();

                return null;
            }

            List<HotelFacility> HotelFacility = new List<HotelFacility>();
            while (reader.Read())
            {
                HotelFacility nextHotelFacility = new HotelFacility()
                {
                    HotelFacility_No = reader.GetInt32(0),
                    Facility_No = reader.GetInt32(1),
                    Hotel_No = reader.GetInt32(2),
                };

                HotelFacility.Add(nextHotelFacility);

                Console.WriteLine(nextHotelFacility);
            }

            reader.Close();
            Console.WriteLine();

            return HotelFacility;
        }
    }
}
