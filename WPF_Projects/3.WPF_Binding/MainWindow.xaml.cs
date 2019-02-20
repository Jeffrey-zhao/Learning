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

namespace _3.WPF_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student stu;
        public MainWindow()
        {
            InitializeComponent();
            /*
            stu = new Student();

            Binding binding = new Binding();
            binding.Source = stu;
            binding.Path = new PropertyPath("Name");

            BindingOperations.SetBinding(this.textBoxName, TextBox.TextProperty, binding);
            */

            // 三合一操作
            this.textBoxName.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu = new Student() });

            this.textBoxName1.SetBinding(TextBox.TextProperty, new Binding("Value") { Source = this.slider1, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged });
            //this.textBoxName1.SetBinding(TextBox.TextProperty, new Binding("Value") { ElementName = "slider1", Mode = BindingMode.TwoWay });
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            stu.Name += "Name";
        }
    }
}
