using PathLists.AuthWindows;
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

namespace PathLists.InteractiveWindows
{
    /// <summary>
    /// Логика взаимодействия для PersonalCabinet.xaml
    /// </summary>
    public partial class PersonalCabinet : Window
    {
        public PersonalCabinet()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для перехода в окно авторизации
        {
            WindowAuth.CurrentID = 0;
            WindowAuth mainWindow = new WindowAuth();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Button_goCars_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для перехода в окно просмотра автомобилей
        {
            WindowCars mainWindow = new WindowCars();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Button_goDrivers_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для перехода в окно просмотра водителей
        {
            WindowDrivers mainWindow = new WindowDrivers();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Button_PathsList_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для перехода в окно просмотра путе
        {
            WindowPathsList mainWindow = new WindowPathsList();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Button_Analysis_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для перехода в окно анализа
        {
            WindowAnalysis mainWindow = new WindowAnalysis();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
