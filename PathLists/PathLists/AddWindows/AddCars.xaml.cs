using PathLists.AuthWindows;
using PathLists.Classes;
using PathLists.InteractiveWindows;
using PathLists.TablesDB;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для AddCars.xaml
    /// </summary>
    public partial class AddCars : Window
    {
        private ApplicationContext db;

        public AddCars()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e) // Обработчик событий для кнопки, предназначенный для валидации, сохранения данных и перехода в окно просмотра автомобилей
        {
            string[] license = TextBoxLicenseNumber.Text.Split(' ');
            string brand = TextBoxBrand.Text.Trim(), year = TextBoxYear.Text.Trim();
            if (license.Length != 4)
            {
                TextBoxLicenseNumber.ToolTip = CommonVariables.errorField;
                TextBoxLicenseNumber.Background = CommonVariables.errorColor;
            }
            else if (brand.Length < 5)
            {
                TextBoxBrand.ToolTip = CommonVariables.errorField;
                TextBoxBrand.Background = CommonVariables.errorColor;
            }
            else if (year.Length > 2005 & year.Length < 1980)
            {
                TextBoxYear.ToolTip = CommonVariables.errorField;
                TextBoxYear.Background = CommonVariables.errorColor;
            }
            else
            {
                TextBoxLicenseNumber.ToolTip = CommonVariables.fixedField;
                TextBoxLicenseNumber.Background = CommonVariables.fixedColor;
                TextBoxBrand.ToolTip = CommonVariables.fixedField;
                TextBoxBrand.Background = CommonVariables.fixedColor;
                TextBoxYear.ToolTip = CommonVariables.fixedField;
                TextBoxYear.Background = CommonVariables.fixedColor;
                addCar(String.Join("", license), brand, year);
            }
        }

        private void addCar(string license, string brand, string year) // Метод добавления автомобилей в базу данных
        {
            Cars car = new Cars(license, brand, year);
            db.Cars.Add(car);
            db.SaveChanges();

            goWindowCar();
        }
        private void goWindowCar()
        {
            WindowCars mainWindow = new WindowCars();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
