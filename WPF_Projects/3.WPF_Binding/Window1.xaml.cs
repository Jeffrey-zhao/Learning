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
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            List<string> stringList = new List<string>() { "Tim", "Jom", "Blog" };
            //this.textBox1.SetBinding(TextBox.TextProperty, new Binding("[1]") { Source = stringList });
            this.textBox1.SetBinding(TextBox.TextProperty, new Binding("/") { Source = stringList });
            this.textBox2.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = stringList, Mode = BindingMode.OneWay });
            this.textBox3.SetBinding(TextBox.TextProperty, new Binding("/[2]") { Source = stringList, Mode = BindingMode.OneWay });
        }
    }
}
