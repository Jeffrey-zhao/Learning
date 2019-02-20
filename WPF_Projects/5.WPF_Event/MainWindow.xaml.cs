using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _5.WPF_Event
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReportTimeHandler(object sender,ReportTimeEventArgs e)
        {
            FrameworkElement ele = sender as FrameworkElement;
            string timeStr = e.ClickTime.ToLongTimeString();
            string content = $"{timeStr} arrives {ele.Name}";
            this.listbox.Items.Add(content);

            if (ele == this.grid3)
            {
                e.Handled = true;
            }
        }
    }
}
