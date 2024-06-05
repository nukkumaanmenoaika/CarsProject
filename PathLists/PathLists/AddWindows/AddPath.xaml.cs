using PathLists.Classes;
using PathLists.InteractiveWindows;
using PathLists.TablesDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PathLists.AddWindows
{
    /// <summary>
    /// Логика взаимодействия для AddPath.xaml
    /// </summary>
    public partial class AddPath : Window
    {
        private ApplicationContext db;

        public AddPath()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e) // Обработчик событий для кнопки, предназначенный для валидации, сохранения данных и перехода в окно списка путей
        {

            try
            {
                int startmileage = Convert.ToInt32(Startmileage.Text);
                int endmileage = Convert.ToInt32(Endmileage.Text);
                int jobnumber = Convert.ToInt32(JobNumber.Text);
                int idnumber = Convert.ToInt32(IdNumber.Text);
                string departuredate = TextBoxDepartureNumber.Text, returndate = TextBoxReturnNumber.Text.Trim(), dest = Destination.Text.Trim();
                List<int> carsID = prepareCars();
                List<int> driversID = prepareDrivers();
                MessageBox.Show(carsID.Count.ToString());

                if (startmileage < 1 || endmileage < 1 || startmileage > 100000 || endmileage > 100000)
                {
                    Startmileage.ToolTip = CommonVariables.errorField;
                    Startmileage.Background = CommonVariables.errorColor;
                    Endmileage.ToolTip = CommonVariables.errorField;
                    Endmileage.Background = CommonVariables.errorColor;
                }
                else if (departuredate == "")
                {
                    TextBoxDepartureNumber.ToolTip = CommonVariables.errorField;
                    TextBoxDepartureNumber.Background = CommonVariables.errorColor;
                }
                else if (returndate == "")
                {
                    TextBoxReturnNumber.ToolTip = CommonVariables.errorField;
                    TextBoxReturnNumber.Background = CommonVariables.errorColor;
                }
                else if (dest == "")
                {
                    Destination.ToolTip = CommonVariables.errorField;
                    Destination.Background = CommonVariables.errorColor;
                }
                else if (jobnumber < 100 || jobnumber > 30000 || !driversID.Contains(jobnumber))
                {
                    JobNumber.ToolTip = CommonVariables.errorField;
                    JobNumber.Background = CommonVariables.errorColor;
                }
                else if (idnumber < 1000 || idnumber > 30000 || !carsID.Contains(idnumber))
                {
                    IdNumber.ToolTip = CommonVariables.errorField;
                    IdNumber.Background = CommonVariables.errorColor;
                }
                else
                {
                    TextBoxReturnNumber.ToolTip = CommonVariables.fixedField;
                    TextBoxReturnNumber.Background = CommonVariables.fixedColor;
                    TextBoxDepartureNumber.ToolTip = CommonVariables.fixedField;
                    TextBoxDepartureNumber.Background = CommonVariables.fixedColor;
                    Startmileage.ToolTip = CommonVariables.fixedField;
                    Startmileage.Background = CommonVariables.fixedColor;
                    Endmileage.ToolTip = CommonVariables.fixedField;
                    Endmileage.Background = CommonVariables.fixedColor;
                    JobNumber.ToolTip = CommonVariables.fixedField;
                    JobNumber.Background = CommonVariables.fixedColor;
                    IdNumber.ToolTip = CommonVariables.fixedField;
                    IdNumber.Background = CommonVariables.fixedColor;
                    Destination.ToolTip = CommonVariables.fixedField;
                    Destination.Background = CommonVariables.fixedColor;
                    addPath(startmileage, endmileage, jobnumber, idnumber, departuredate, returndate, dest);
                }
            }
            catch { }
        }

        private List<int> prepareCars() // Метод, формирующий массив из идентификаторов автомобилей
        {
            List<Cars> cars = db.Cars.ToList();
            List<int> result = new List<int>();
            foreach(var car in cars) 
            {
                result.Add(car.id);
            }
            return result;
        }
        private List<int> prepareDrivers() // Метод, формирующий массив из идентификаторов водитлей
        {
            List<Drivers> drivers = db.Drivers.ToList();
            List<int> result = new List<int>();
            foreach(var  driver in drivers) 
            {
                result.Add(driver.id);
            }
            return result;
        }

        private void addPath(int startmileage, int endmileage, int jobnumber, int idnumber, string departuredate, string returndate, string dest) // Метод добавления записи в таблицу путей
        {
            NumberPathList path = new NumberPathList(dest, jobnumber, startmileage, endmileage,  returndate, departuredate, idnumber);
            db.NumberPathList.Add(path);
            db.SaveChanges();
            goWindowPathList();
        }
        private void goWindowPathList() // Метод для перехода в окно просмотра путей
        {
            WindowPathsList mainWindow = new WindowPathsList();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
