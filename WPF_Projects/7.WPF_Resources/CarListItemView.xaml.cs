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

namespace _7.WPF_Resources
{
    /// <summary>
    /// Interaction logic for CarListBoxItemView.xaml
    /// </summary>
    public partial class CarListItemView : UserControl
    {
        public CarListItemView()
        {
            InitializeComponent();
        }

        private Car car;
        public Car Car {
            get{ return car; }
            set {
                car = value;
                this.textblockName.Text = car.Name;
                this.textblockYear.Text = car.Year;
                string uriStr = $@"Resources/Logos/{car.AutoMaker}.jpg";
                this.imageLogo.Source = new BitmapImage(new Uri(uriStr, UriKind.Relative));
            }
        }
    }
}
