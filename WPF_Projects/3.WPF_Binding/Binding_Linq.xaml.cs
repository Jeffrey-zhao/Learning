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
using System.Xml.Linq;

namespace _3.WPF_Binding
{
    /// <summary>
    /// Interaction logic for Binding_Ado.xaml
    /// </summary>
    public partial class Binding_Linq : Window
    {
        public Binding_Linq()
        {
            InitializeComponent();

        }
        private List<MyStudent> LoadList()
        {
            var list = new List<MyStudent>()
            {
                new MyStudent {Id=0,Name="Tim",Age=29 },
                new MyStudent {Id=1,Name="Tom",Age=28 },
                new MyStudent {Id=2,Name="Jim",Age=19 },
                new MyStudent {Id=3,Name="Lily",Age=20 },
                new MyStudent {Id=4,Name="Lucy",Age=18 },
                new MyStudent {Id=5,Name="Mike",Age=20 },
            };

            return list;
        }

        private DataTable LoadTable()
        {
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id"));
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("Age"));

            var dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Tom";
            dr[2] = 19;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "Jim";
            dr[2] = 20;
            dt.Rows.Add(dr);

            return dt;
        }

        private XDocument LoadXml()
        {
            XDocument xdoc = XDocument.Load(@"./StudentList.xml");
            return xdoc;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // load from list
            //List<MyStudent> list = this.LoadList();
            //this.listViewStudents.ItemsSource = from stu in list where stu.Name.StartsWith("T") select stu;

            // load from datatable
            /*
            DataTable dt = this.LoadTable();
            this.listViewStudents.ItemsSource =
                from row in dt.Rows.Cast<DataRow>()
                where Convert.ToString(row["Name"]).StartsWith("T")
                select new MyStudent
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    Age = int.Parse(row["Age"].ToString()),
                };
            */

            // load from xml
            var xdoc = this.LoadXml();
            this.listViewStudents.ItemsSource =
                from element in xdoc.Descendants("Student")
                where element.Attribute("Name").Value.StartsWith("T")
                select new MyStudent
                {
                    Id = int.Parse(element.Attribute("Id").Value),
                    Name = element.Attribute("Name").Value,
                    Age = int.Parse(element.Attribute("Age").Value),
                };
        }
    }
}
