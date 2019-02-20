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
    /// Interaction logic for Binding_ObjectDataProvider.xaml
    /// </summary>
    public partial class Binding_ObjectDataProvider : Window
    {
        public Binding_ObjectDataProvider()
        {
            InitializeComponent();
            //SetBinding();
            SetBinding2();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("100");
            odp.MethodParameters.Add("200");
            MessageBox.Show(odp.Data.ToString());
        }

        private void SetBinding()
        {
            ObjectDataProvider odp = new ObjectDataProvider();

            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            Binding bindingToArg1 = new Binding("MethodParameters[0]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bindingToArg2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bindingToResult = new Binding(".") { Source = odp };

            this.textBox1.SetBinding(TextBox.TextProperty, bindingToArg1);
            this.textBox2.SetBinding(TextBox.TextProperty, bindingToArg2);
            this.textBox3.SetBinding(TextBox.TextProperty, bindingToResult);

        }

        private void SetBinding2()
        {
            ObjectDataProvider odp = new ObjectDataProvider();

            odp.ObjectType = typeof(Calculator);
            odp.ConstructorParameters.Add("1");
            odp.ConstructorParameters.Add("2");

            odp.MethodName = "TryAdd";

            Binding bindingToArg1 = new Binding("ConstructorParameters[0]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bindingToArg2 = new Binding("ConstructorParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            Binding bindingToResult = new Binding(".") { Source = odp };

            this.textBox1.SetBinding(TextBox.TextProperty, bindingToArg1);
            this.textBox2.SetBinding(TextBox.TextProperty, bindingToArg2);
            this.textBox3.SetBinding(TextBox.TextProperty, bindingToResult);
        }
    }
}
