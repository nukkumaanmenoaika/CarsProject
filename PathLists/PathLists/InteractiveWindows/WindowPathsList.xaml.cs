using PathLists.AddWindows;
using PathLists.TablesDB;
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
    /// Логика взаимодействия для WindowPathsList.xaml
    /// </summary>
    public partial class WindowPathsList : Window
    {
        private ApplicationContext db;

        public WindowPathsList()
        {
            InitializeComponent();
            db = new ApplicationContext();
            DGrid.ItemsSource = db.NumberPathList.ToList();
            
            if (WindowAuth.CurrentRole == 1) // Определение функционала приложения в зависимости от должности пользователя
            {
                Add.Visibility = Visibility.Hidden;
                Delete.Visibility = Visibility.Hidden;
            }
            if (WindowAuth.CurrentRole == 3)
            {
                Add.Visibility = Visibility.Hidden;
                Delete.Visibility = Visibility.Hidden;
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

        private void btnAdd_Click(object sender, RoutedEventArgs e) // // Обработчик события для кнопки, предназначенный для перехода в окно добавления записи
        {
            AddPath mainWindow = new AddPath();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для удаления записей
        {
            if (DGrid.SelectedIndex != -1)
            {
                NumberPathList a = DGrid.SelectedItem as NumberPathList;
                db = new ApplicationContext();
                var order = db.NumberPathList.Where(c => c.id == a.id).FirstOrDefault();
                db.NumberPathList.Remove(order);
                db.SaveChanges();
                WindowPathsList mainWindow = new WindowPathsList();
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
