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
    /// Interaction logic for Binding_ItemSources.xaml
    /// </summary>
    public partial class Binding_ItemsSource : Window
    {
        public Binding_ItemsSource()
        {
            InitializeComponent();

            List<MyStudent> stuList = new List<MyStudent>()
            {
                new MyStudent {Id=0,Name="Tim",Age=29 },
                new MyStudent {Id=1,Name="Tom",Age=28 },
                new MyStudent {Id=2,Name="Jim",Age=19 },
                new MyStudent {Id=3,Name="Lily",Age=20 },
                new MyStudent {Id=4,Name="Lucy",Age=18 },
                new MyStudent {Id=5,Name="Mike",Age=20 },
            };

            this.listBoxStudents.ItemsSource = stuList;
            // 若添加了 ItemTemplate 显示模板需要注释改行，因为没有使用系统默认提供的 DataTemplate
            //this.listBoxStudents.DisplayMemberPath = "Name";

            Binding binding = new Binding("SelectedItem.Id") { Source = this.listBoxStudents };
            this.textBoxId.SetBinding(TextBox.TextProperty, binding);
        }
    }

    class MyStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
