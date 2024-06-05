using PathLists.AuthWindows;
using PathLists.Classes;
using PathLists.TablesDB;
using PathLists.InteractiveWindows;
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
    /// Логика взаимодействия для AddDriver.xaml
    /// </summary>
    public partial class AddDriver : Window
    {
        private ApplicationContext db;
        private string[] categories = new string[] { "В", "С", "Д", "Е" };
        public AddDriver()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e) // Обработчик событий для кнопки, предназначенный для валидации, сохранения данных и перехода в окно просмотра водителей
        { 
            string login = TextBoxLogin.Text.Trim(),
                name = TextBoxName.Text.Trim(),
                surname = TextBoxSurname.Text.Trim(),
                patronymic = TextBoxPatronymic.Text.Trim(),
                pass_1 = passbox_1.Password.Trim(),
                pass_2 = passbox_2.Password.Trim();
            string drivelicense = TextBoxDriveLicense.Text.Trim();
            if (name.Length < 5)
            {
                TextBoxName.ToolTip = CommonVariables.errorField;
                TextBoxName.Background = CommonVariables.errorColor;
            }
            else if (surname.Length < 5)
            {
                TextBoxSurname.ToolTip = CommonVariables.errorField;
                TextBoxSurname.Background = CommonVariables.errorColor;
            }
            else if (patronymic.Length < 5)
            {
                TextBoxPatronymic.ToolTip = CommonVariables.errorField;
                TextBoxPatronymic.Background = CommonVariables.errorColor;
            }
            else if (!categories.Contains(drivelicense))
            {
                TextBoxDriveLicense.ToolTip = CommonVariables.errorField;
                TextBoxDriveLicense.Background = CommonVariables.errorColor;
            }
            else if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = CommonVariables.errorField;
                TextBoxLogin.Background = CommonVariables.errorColor;
            }
            else if (pass_1.Length < 5)
            {
                passbox_1.ToolTip = CommonVariables.errorField;
                passbox_1.Background = CommonVariables.errorColor;
            }
            else if (pass_2.Length < 5)
            {
                passbox_2.ToolTip = CommonVariables.errorField;
                passbox_2.Background = CommonVariables.errorColor;
            }
            else if (pass_1 != pass_2)
            {
                passbox_2.ToolTip = CommonVariables.errorField;
                passbox_2.Background = CommonVariables.errorColor;
            }
            else
            {
                TextBoxLogin.ToolTip = CommonVariables.fixedField;
                TextBoxLogin.Background = CommonVariables.fixedColor;
                TextBoxName.ToolTip = CommonVariables.fixedField;
                TextBoxName.Background = CommonVariables.fixedColor;
                TextBoxSurname.ToolTip = CommonVariables.fixedField;
                TextBoxSurname.Background = CommonVariables.fixedColor;
                TextBoxPatronymic.ToolTip = CommonVariables.fixedField;
                TextBoxPatronymic.Background = CommonVariables.fixedColor;
                TextBoxDriveLicense.ToolTip = CommonVariables.fixedField;
                TextBoxDriveLicense.Background = CommonVariables.fixedColor;
                passbox_1.ToolTip = CommonVariables.fixedField;
                passbox_1.Background = CommonVariables.fixedColor;
                passbox_2.ToolTip = CommonVariables.fixedField;
                passbox_2.Background = CommonVariables.fixedColor;
                Saving(name, surname, patronymic, drivelicense, login, pass_1);
            }
        }
        private void Saving(string name, string surname, string patronymic, string drivelicense, string login, string password) // Метод сохранения данных в базу данных
        {
            Drivers user = new Drivers(name, surname, patronymic, drivelicense, login, password);
            db.Drivers.Add(user);
            db.SaveChanges();
            NavigateGoAuth();
        }
        
        private void NavigateGoAuth() // Метод для перехода в окно просмотра водителей
        {
            WindowDrivers mainWindow = new WindowDrivers();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

    }
}
