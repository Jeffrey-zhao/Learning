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
    /// Interaction logic for Win_CodeToImplementXaml.xaml
    /// </summary>
    public partial class Win_CodeToImplementXaml : Window
    {
        public Win_CodeToImplementXaml()
        {
            InitializeComponent();
            InitialLayout();
        }

        private void InitialLayout()
        {
            Grid grid = new Grid() { ShowGridLines = true };
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());

            Button btn = new Button() { Content = "OK" };
            Grid.SetColumn(btn, 1);
            Grid.SetRow(btn, 1);

            grid.Children.Add(btn);

            this.Content = grid;
        }
    }
}
