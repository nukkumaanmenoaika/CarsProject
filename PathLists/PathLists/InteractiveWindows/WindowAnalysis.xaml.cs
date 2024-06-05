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
using PathLists.Classes;
using PathLists.TablesDB;
using System.Diagnostics.Eventing.Reader;

namespace PathLists.InteractiveWindows
{
    /// <summary>
    /// Логика взаимодействия для WindowAnalysis.xaml
    /// </summary>
    public partial class WindowAnalysis : Window
    {
        private ApplicationContext db;

        public WindowAnalysis()
        {
            InitializeComponent();
            db = new ApplicationContext();
            DGrid.ItemsSource = prepareData();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) // Обработчик события для кнопки, предназначенный для перехода в личный кабинет
        {
            PersonalCabinet mainWindow = new PersonalCabinet();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }


        private List<AnalysisPaths>  prepareData() // Метод, который структурирует отображаемые данные в компновке DataGrid
        {
            List<Cars> cars = db.Cars.ToList(); 
            List<NumberPathList> paths = db.NumberPathList.ToList();    
            List<int> carsID = new List<int>();
            List<AnalysisPaths> result = new List<AnalysisPaths>();
            foreach (Cars car in cars)
            {
                carsID.Add(car.id);
            }
            foreach (NumberPathList path in paths)
            {
                if (carsID.Contains(path.id_number))
                {
                    result.Add(new AnalysisPaths(db.Cars.Where(b => b.id == path.id_number).FirstOrDefault().License_number, $"{path.end_mileage - path.start_mileage}"));
                }
            }
            return result;
        }
    }
}
