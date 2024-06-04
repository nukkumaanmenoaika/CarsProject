using MaterialDesignThemes.Wpf;
using PathLists.AddWindows;
using PathLists.AuthWindows;
using PathLists.Classes;
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
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace PathLists.InteractiveWindows
{
    /// <summary>
    /// Логика взаимодействия для WindowDrivers.xaml
    /// </summary>
    public partial class WindowDrivers : Window
    {
        private ApplicationContext db;
        public WindowDrivers()
        {
            InitializeComponent();
            db = new ApplicationContext();
            DGrid.ItemsSource = db.Drivers.ToList();

            if (WindowAuth.CurrentRole == 1)
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
            if (DGrid.SelectedItem != null)
            {
                CommonVariables.driver = DGrid.SelectedItem as Drivers;
                EditDriver mainWindow = new EditDriver();
                Visibility = Visibility.Hidden;
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Выберите водителя");
            }
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PersonalCabinet mainWindow = new PersonalCabinet();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (DGrid.SelectedIndex != -1)
            {
                Drivers a = DGrid.SelectedItem as Drivers;
                db = new ApplicationContext();
                var order = db.Drivers.Where(c => c.id == a.id).FirstOrDefault();
                db.Drivers.Remove(order);
                db.SaveChanges();
                WindowDrivers mainWindow = new WindowDrivers();
                Visibility = Visibility.Hidden;
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Водитель не выбран", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddDriver mainWindow = new AddDriver();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
