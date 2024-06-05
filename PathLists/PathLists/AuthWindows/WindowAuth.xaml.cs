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
using PathLists.TablesDB;
using PathLists.InteractiveWindows;
using PathLists.Classes;
namespace PathLists.AuthWindows
{
    /// <summary>
    /// Логика взаимодействия для WindowAuth.xaml
    /// </summary>
    public partial class WindowAuth : Window
    {
        private static int currentID;
        public static int CurrentID // Переменная, которая хранит в себе настоящий идентификатор пользователя, который успешно прошел авторизацию
        {
            get { return currentID; }
            set { currentID = value; }
        }
        private static int currentRole;
        public static int CurrentRole // Переменная, которая хранит в себе должность пользователя, который успешно прошел авторизацию
        {
            get { return currentRole; }
            set { currentRole = value; }
        }

        public WindowAuth()
        {
            InitializeComponent();
        }

        private void Button_GoReg_Click(object sender, RoutedEventArgs e) {  // Обработчик события для кнопки, который предназначен для перехода в окно регистрации
            WindowReg mainWindow = new WindowReg();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, который предназначен для валидации входных данных

        {
            string login = TextBoxLogin.Text.Trim(), pass_1 = passbox_1.Password.Trim();
            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = CommonVariables.errorField;
                TextBoxLogin.Background = CommonVariables.errorColor;
            }
            else if (pass_1.Length < 5)
            {
                passbox_1.ToolTip = CommonVariables.errorField;
                passbox_1.Background = CommonVariables.errorColor;
            }
            else
            {
                TextBoxLogin.ToolTip = CommonVariables.fixedField;
                TextBoxLogin.Background = CommonVariables.fixedColor;
                passbox_1.ToolTip = CommonVariables.fixedField;
                passbox_1.Background = CommonVariables.fixedColor;
                checkAccess(login, pass_1);
            }
        }

        private void checkAccess(string login, string password)  // Метод, который проверяет существует ли данный пользователь в базе данных и выдает доступ
        {                                                        // Помимо этого присваивает соотвествущее значение CurrentID и CurrentRole
            Drivers authUser = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                authUser = db.Drivers.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
            }
            if (authUser != null)
            {
                CurrentID = authUser.id;
                CurrentRole = authUser.Role;
                PersonalCabinet mainWindow = new PersonalCabinet();
                Visibility = Visibility.Hidden;
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
                passbox_1.Background = CommonVariables.errorColor;
                TextBoxLogin.Background = CommonVariables.errorColor;
            }
        }

    }
}
