using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace PathLists.Classes
{
    internal class DriversContainer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string patronymic;
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        private string driver_License;

        

        public string driver_license
        {
            get { return driver_License; }
            set { driver_License = value; }
        }

        public DriversContainer() { }
        public DriversContainer(string name, string surname, string patronymic, string driver_license)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            this.driver_license = driver_license;
        }
    }
}
