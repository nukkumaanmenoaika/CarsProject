using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLists.TablesDB
{
    internal class NumberPathList
    {
        public int id {  get; set; }

        private int Id_number;
        public int id_number
        {
            get { return Id_number; }
            set { Id_number = value; }
        }
        private string destination;
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        private int Job_number;
        public int job_Number
        {
            get { return Job_number; }
            set { Job_number = value; }
        }
        private int Start_mileage;
        public int start_mileage
        {
            get { return Start_mileage; }
            set { Start_mileage = value; }
        }
        private int End_mileage;
        public int end_mileage
        {
            get { return End_mileage; }
            set { End_mileage = value; }
        }
        private string Date_return;
        public string date_return
        {
            get { return Date_return; }
            set { Date_return = value; }
        }
        private string Date_departure;

        
        public string date_departure
        {
            get { return Date_departure; }
            set { Date_departure = value; }
        }

        public NumberPathList() { }
        public NumberPathList(string destination, int jobNumber, int startmileage, int endmileage, string dateReturn, string dateDeparture, int idnumber)
        {
            Destination = destination;
            job_Number = jobNumber;
            start_mileage = startmileage;
            end_mileage = endmileage;
            date_return = dateReturn;
            date_departure = dateDeparture;
            id_number = idnumber;
        }


    }
}
