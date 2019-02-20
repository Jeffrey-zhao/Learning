using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Binding_Ado.xaml
    /// </summary>
    public partial class Binding_AdoNet : Window
    {
        public Binding_AdoNet()
        {
            InitializeComponent();

        }
        private DataTable Load()
        {
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id"));
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("Age"));

            var dr = dt.NewRow();
            dr[0]= 1;
            dr[1]="Tom";
            dr[2]=19;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "Jim";
            dr[2] = 20;
            dt.Rows.Add(dr);

            return dt;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = this.Load();

            this.listBoxStudents.DisplayMemberPath = "Name";
            this.listBoxStudents.ItemsSource = dt.DefaultView;

            //this.listViewStudents.ItemsSource = dt.DefaultView;
            //the same to this 1 below

            //this.listViewStudents.DataContext = dt;
            //this.listViewStudents.SetBinding(ListView.ItemsSourceProperty, new Binding());

            //the same to this 2 below
            this.listViewStudents.SetBinding(ListView.ItemsSourceProperty, new Binding("DefaultView") { Source =dt});
        }
    }
}
