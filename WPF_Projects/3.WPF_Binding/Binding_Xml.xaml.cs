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
using System.Xml;

namespace _3.WPF_Binding
{
    /// <summary>
    /// Interaction logic for Binding_Xml.xaml
    /// </summary>
    public partial class Binding_Xml : Window
    {
        public Binding_Xml()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@".\RawData.xml");

            XmlDataProvider xdp = new XmlDataProvider();
            xdp.Document = doc;

            xdp.XPath = @"/StudentList/Student";
            this.listViewStudents.DataContext = xdp;
            this.listViewStudents.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
