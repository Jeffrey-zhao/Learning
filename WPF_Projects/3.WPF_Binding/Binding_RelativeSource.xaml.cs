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
    /// Interaction logic for Binding_RelativeSource.xaml
    /// </summary>
    public partial class Binding_RelativeSource : Window
    {
        public Binding_RelativeSource()
        {
            InitializeComponent();
            /*
            RelativeSource rs = new RelativeSource(RelativeSourceMode.FindAncestor);
            rs.AncestorLevel = 2;
            rs.AncestorType = typeof(DockPanel);
            Binding binding = new Binding("Name") { RelativeSource = rs };
            this.textBox1.SetBinding(TextBox.TextProperty, binding);
            */
        }
    }
}
