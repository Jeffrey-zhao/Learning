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

namespace _6.WPF_Command
{
    /// <summary>
    /// Interaction logic for Window1_xaml.xaml
    /// </summary>
    public partial class Window1_xaml : Window
    {
        public Window1_xaml()
        {
            InitializeComponent();
        }

        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.nameTextbox.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            e.Handled = true;
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string name = this.nameTextbox.Text;
            if (e.Parameter.ToString() == "Teacher")
            {
                this.listBoxNewItems.Items.Add($"New Teacher : {name} ,学而不厌，诲人不倦。");
            }
            if (e.Parameter.ToString() == "Student")
            {
                this.listBoxNewItems.Items.Add($"New Student : {name} ,好好学习，天天向上。");
            }
        }
    }
}
