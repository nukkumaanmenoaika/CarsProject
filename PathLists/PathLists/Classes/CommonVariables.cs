using PathLists.TablesDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PathLists.Classes
{
    internal class CommonVariables
    {
        public static SolidColorBrush errorColor = Brushes.LightPink;
        public static SolidColorBrush fixedColor = Brushes.Transparent;
        public static string errorField = "Это поле введено не корректно!";
        public static string fixedField = " ";
        public static Drivers driver;
    }
}
