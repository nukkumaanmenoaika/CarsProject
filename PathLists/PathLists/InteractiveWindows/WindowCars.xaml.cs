using PathLists.AddWindows;
using PathLists.AuthWindows;
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

namespace PathLists.InteractiveWindows
{
    /// <summary>
    /// Логика взаимодействия для WindowCars.xaml
    /// </summary>
    public partial class WindowCars : Window
    {
        private ApplicationContext db;

        public WindowCars()
        {
            InitializeComponent();
            db = new ApplicationContext();
            DGrid.ItemsSource = db.Cars.ToList();
            if (WindowAuth.CurrentRole == 1) // Определение функционала приложения в зависимости от должности пользователя
            {
                Delete.Visibility = Visibility.Hidden;
                Add.Visibility = Visibility.Hidden;
            }
            if (WindowAuth.CurrentRole == 2)
            {
                Delete.Visibility = Visibility.Hidden;
                Add.Visibility = Visibility.Hidden;
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для перехода в личный кабинет
        {
            PersonalCabinet mainWindow = new PersonalCabinet();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для перехода в окно добавления автомобилей
        {
            AddCars mainWindow = new AddCars();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для удаления автомобилей  
        {
            if (DGrid.SelectedIndex != -1)
            {
                Cars a = DGrid.SelectedItem as Cars;
                db = new ApplicationContext();
                var order = db.Cars.Where(c => c.id == a.id).FirstOrDefault();
                db.Cars.Remove(order);
                db.SaveChanges();
                WindowCars mainWindow = new WindowCars();
                Visibility = Visibility.Hidden;
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Водитель не выбран", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
