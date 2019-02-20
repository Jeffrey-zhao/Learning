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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Student stu;
        public Window1()
        {
            InitializeComponent();

            stu = new Student();
            stu.SetBinding(Student.NameProperty, new Binding("Text") { Source = this.textBox1 });
            textBox2.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Student stu = new Student();
            //stu.SetValue(Student.NameProperty, this.textBox1.Text);
            //this.textBox2.Text = (string)stu.GetValue(Student.NameProperty);


        }
    }
}
