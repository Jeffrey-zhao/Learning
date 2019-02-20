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

namespace _4.WPF_Property
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();

            this.rect.SetBinding(Canvas.LeftProperty, new Binding("Value") { Source = slider1 });
            this.rect.SetBinding(Canvas.TopProperty, new Binding("Value") { ElementName = "slider2" });
        }
    }
}
