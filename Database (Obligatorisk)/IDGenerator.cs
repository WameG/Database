using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database__Obligatorisk_


{
    public class IDGenerator
    {
        public static int GetMaxFacilityNo(SqlConnection connection, string database, string idName)
        {

            string queryStringMaxFacilityNo = $"SELECT  MAX({idName})  FROM {database}";

            SqlCommand command = new SqlCommand(queryStringMaxFacilityNo, connection);
            SqlDataReader reader = command.ExecuteReader();

            int MaxFacilityNo = 0;

            if (reader.Read())
            {
                MaxFacilityNo = reader.GetInt32(0);
            }

            reader.Close();

            return MaxFacilityNo;
        }
    }
}
