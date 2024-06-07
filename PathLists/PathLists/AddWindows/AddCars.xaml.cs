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
            try
            {
                string[] license = TextBoxLicenseNumber.Text.Split(' ');
                string brand = TextBoxBrand.Text.Trim();
                bool nonumisDigit = false;
                bool nonumisDigitlast = false;
                string year = TextBoxYear.Text.Trim();
                if (license.Length == 4)
                {
                    foreach (char a in license[1])
                    {
                        if (!Char.IsDigit(a)) nonumisDigit = true;
                    }
                    foreach (char b in license[3])
                    {
                        if (!Char.IsDigit(b)) nonumisDigitlast = true;
                    }
                }
                else
                {
                    TextBoxLicenseNumber.ToolTip = CommonVariables.errorField;
                    TextBoxLicenseNumber.Background = CommonVariables.errorColor;
                }
                if (license.Length != 4 || license[0].Length != 1 || license[1].Length != 3 || license[2].Length != 2 || license[3].Length != 2 || nonumisDigit || nonumisDigitlast)
                {
                    TextBoxLicenseNumber.ToolTip = CommonVariables.errorField;
                    TextBoxLicenseNumber.Background = CommonVariables.errorColor;
                }
                else if (brand.Length < 5)
                {
                    TextBoxBrand.ToolTip = CommonVariables.errorField;
                    TextBoxBrand.Background = CommonVariables.errorColor;
                }
                else if (Convert.ToInt32(year) > 2005 || Convert.ToInt32(year) < 1980)
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
            catch
            {
                MessageBox.Show("Неверный формат данныых");
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
