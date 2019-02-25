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

namespace _7.WPF_Resources
{
    /// <summary>
    /// Interaction logic for Win_DataTemplate.xaml
    /// </summary>
    public partial class Win_DataTemplate : Window
    {
        public Win_DataTemplate()
        {
            InitializeComponent();
            InitialCarList();
        }

        private void InitialCarList()
        {
            List<Car> list = new List<Car>
            {
                new Car {AutoMaker="Lamborghini",Name="Diablo",Year="1990",TopSpeed="340" },
                new Car {AutoMaker="Lamborghini",Name="Gallardo",Year="2000",TopSpeed="350" },
                new Car {AutoMaker="Lamborghini",Name="Murcielago",Year="1998",TopSpeed="300" },
                new Car {AutoMaker="Lamborghini",Name="Reventon",Year="2010",TopSpeed="280" },
            };

            this.listBoxCars.ItemsSource = list;
        }
    }
}
