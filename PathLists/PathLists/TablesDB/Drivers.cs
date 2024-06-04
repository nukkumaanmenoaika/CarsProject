using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLists.TablesDB
{
    internal class Drivers
    {
        public int id {  get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
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
        private int role;
        public int Role
        {
            get { return role; }
            set { role = value; }
        }

        public Drivers() { }

        public Drivers( string name, string surname, string patronymic, string driveLicense, string login, string password)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            driver_license = driveLicense;
            Login = login;
            Password = password;
            Role = 1;
        }
    }
}
