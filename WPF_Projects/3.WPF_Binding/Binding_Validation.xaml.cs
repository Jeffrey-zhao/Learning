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
    /// Interaction logic for Binding_Validation.xaml
    /// </summary>
    public partial class Binding_Validation : Window
    {
        public Binding_Validation()
        {
            InitializeComponent();

            Binding binding = new Binding("Value") { Source = this.slider1 };
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

            RangeValidationRules rvr = new RangeValidationRules();
            rvr.ValidatesOnTargetUpdated = true;
            binding.ValidationRules.Add(rvr);
            binding.NotifyOnValidationError = true;

            this.textBox1.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(this.ValidationError));

            this.textBox1.SetBinding(TextBox.TextProperty, binding);
        }

        private void ValidationError(object sender, RoutedEventArgs e)
        {
            if (Validation.GetErrors(this.textBox1).Count > 0)
            {
                this.textBox1.ToolTip = Validation.GetErrors(this.textBox1)[0].ErrorContent.ToString();
            }
        }
    }
}
