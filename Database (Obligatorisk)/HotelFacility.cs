using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database__Obligatorisk_
{
    public class HotelFacility
    {
        public int HotelFacility_No { get; set; }
        public int Facility_No { get; set; }

        public int Hotel_No { get; set; }

        public override string ToString()
        {
            return $"ID: {HotelFacility_No} - Facility_No: {Facility_No} - Hotel_No: {Hotel_No}";
        }
    }
}
