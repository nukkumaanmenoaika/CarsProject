using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLists.TablesDB
{
    internal class Cars
    {
        public int id {  get; set; }
        private string license_number;
        public string License_number
        {
            get { return license_number; }
            set { license_number = value; }
        }
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public Cars() { }
        public Cars(string license_number, string brand, string year)
        {
            License_number = license_number;
            Brand = brand;
            Year = year;
        }
    }
}
