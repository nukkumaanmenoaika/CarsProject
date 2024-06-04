using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLists.TablesDB
{
    internal class AnalysisPaths
    {
        public int id { get; set; }
        private string license_number;
        public string License_number
        {
            get { return license_number; }
            set { license_number = value; }
        }
        
       private string mileage;

        public string Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
        public AnalysisPaths() { }
        public AnalysisPaths(string license_number, string mileage)
        {
            License_number = license_number;
            Mileage = mileage;
        }
    }
}
