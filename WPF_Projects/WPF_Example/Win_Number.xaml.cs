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
using System.Windows.Threading;

namespace WPF_Example
{
    /// <summary>
    /// Interaction logic for Win_Number.xaml
    /// </summary>
    public partial class Win_Number : Window
    {
        public Win_Number()
        {
            InitializeComponent();
        }

        private DispatcherTimer timer = null;
        private int count = 10;
        private void wm_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timer.Stop();
                count = 10;
                timer.Start();
            }else
            {
                Win_Number_TextCtl txt = new Win_Number_TextCtl(this.rootGrid, wm);
                txt.TxtValue = count.ToString();
                txt.HorizontalAlignment = HorizontalAlignment.Center;
                txt.VerticalAlignment = VerticalAlignment.Center;
                this.rootGrid.Children.Add(txt);
                count--;
            }
        }
    }
}
