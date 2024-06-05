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
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PathLists.AddWindows
{
    /// <summary>
    /// Логика взаимодействия для EditDriver.xaml
    /// </summary>
    public partial class EditDriver : Window
    {
        private ApplicationContext db;
        private string[] categories = new string[] { "В", "С", "Д", "Е" };
        public EditDriver()
        {
            InitializeComponent();
            db = new ApplicationContext();
            Name.Text += CommonVariables.driver.Name; // Инициализация начальный данных
            Surname.Text += CommonVariables.driver.Surname;
            Patronymic.Text += CommonVariables.driver.Patronymic;
            Category.Text += CommonVariables.driver.driver_license;
        }

       

        private void Button_Add_Click(object sender, RoutedEventArgs e) // Обработчик событий для кнопки, предназначенный для валидации, сохранения данных и перехода в окно водителей
        {
            string name = NameAdd.Text.Trim(),
                surname = SurnameAdd.Text.Trim(),
                patronymic = PatronymicAdd.Text.Trim();
            string drivelicense = CategoryAdd.Text.Trim();
            Drivers authUser = db.Drivers.Where(b => b.id == CommonVariables.driver.id).FirstOrDefault();
            if (name != "")
            {
                authUser.Name = name;
            }
            else if (surname != "")
            {
                authUser.Surname = surname;
            }
            else if (patronymic != "")
            {
                authUser.Patronymic = patronymic;
            }
            else if (categories.Contains(drivelicense) && drivelicense != "")
            {
                authUser.driver_license = drivelicense; 
            }
            else
            {

            }

            db.SaveChanges();
            WindowDrivers mainWindow = new WindowDrivers();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
