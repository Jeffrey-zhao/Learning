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

namespace _3.WPF_Binding
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<Country> countryList = new List<Country>
        {
            new Country {Name="China",Provinces=new List<Province>
            {
                new Province { Name="Hubei", Citys=new List<City>
                    {
                        new City {Name="Wuhan" },
                        new City{Name="Xiantao" }
                    }},
                new Province { Name="Shanghai", Citys=new List<City>
                    {
                        new City {Name="Minhang" },
                        new City{Name="Huangpu" }
                    }}
              }},
            new Country {Name="America",Provinces=new List<Province>
            {
                new Province { Name="A", Citys=new List<City>
                    {
                        new City {Name="A-1" },
                        new City{Name="A-2" }
                    }},
                new Province { Name="B", Citys=new List<City>
                    {
                        new City {Name="B-1" },
                        new City{Name="B-2" }
                    }}
              }}
        };
        public Window2()
        {
            InitializeComponent();
            // '/' means default value :[0]
            this.textBox1.SetBinding(TextBox.TextProperty, new Binding("[1].Name") { Source = countryList });
            this.textBox2.SetBinding(TextBox.TextProperty, new Binding("[1].Provinces/Name") { Source = countryList, Mode = BindingMode.OneWay });
            //this.textBox1.SetBinding(TextBox.TextProperty, new Binding("[1].Name") { Source = countryList });
            //this.textBox2.SetBinding(TextBox.TextProperty, new Binding("/Provinces/Name") { Source = countryList, Mode = BindingMode.OneWay });
            this.textBox3.SetBinding(TextBox.TextProperty, new Binding("/Provinces/Citys[1].Name") { Source = countryList, Mode = BindingMode.OneWay });
        }
    }
}
