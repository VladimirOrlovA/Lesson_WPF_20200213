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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson_WPF_20200213
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Car
        {
            public string brand { get; set; }
            public string model { get; set; }
            public string year { get; set; }
            public string carImage { get; set; }

            public Car(string brand, string model, string year, string carImage)
            {
                this.brand = brand;
                this.model = model;
                this.year = year;
                this.carImage = carImage;
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            List<Car> cars = new List<Car>
            {
                new Car("Subaru","Outback","1999", "https://avatars.mds.yandex.net/get-zen_doc/44972/pub_5d2ad376998ed600acf9ac9c_5d2ad39ec49f2900aef416ab/scale_1200"),
                new Car("Mitsubishi","Pajero","1996", "https://avatars.mds.yandex.net/get-zen_doc/44972/pub_5d2ad376998ed600acf9ac9c_5d2ad39ec49f2900aef416ab/scale_1200"),
            };

            LvCars.ItemsSource = cars;

        }

        private void PriceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           LbSliderValue.Content = ((Slider)sender).Value;

            PbMainVal.Value = ((Slider)sender).Value;
        }
    }
}
