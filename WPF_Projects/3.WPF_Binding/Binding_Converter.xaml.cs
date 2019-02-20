using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Binding_Converter.xaml
    /// </summary>
    public partial class Binding_Converter : Window
    {
        public Binding_Converter()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, RoutedEventArgs e)
        {
            List<Plane> infos = new List<Plane>() {
            new Plane(){ Category= Category.Bomber,Name="B-1", State= State.Unknown},
            new Plane(){ Category= Category.Bomber,Name="B-2", State= State.Unknown},
            new Plane(){ Category= Category.Fighter,Name="F-22", State= State.Locked},
            new Plane(){ Category= Category.Fighter,Name="Su-47", State= State.Unknown},
            new Plane(){ Category= Category.Bomber,Name="B-52", State= State.Available},
            new Plane(){ Category= Category.Fighter,Name="J-10", State= State.Unknown},
            };
            this.listBoxPlan.ItemsSource = infos;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Plane item in listBoxPlan.Items)
            {
                sb.AppendLine(string.Format("Category={0},State={1},Name={2}", item.Category, item.State, item.Name));
            }
            File.WriteAllText(@".\PlaneList.txt", sb.ToString());
        }
    }
}
