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

namespace _6.WPF_Command
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Window1_Code : Window
    {
        public Window1_Code()
        {
            InitializeComponent();
            InitilaCommand();
        }
        //声明并定义命令
        private RoutedCommand clearCommand = new RoutedCommand("Clear", typeof(Window1_Code));
        private void InitilaCommand()
        {
            //把命令赋值给命令源，并指定快捷键
            this.button1.Command = this.clearCommand;
            this.clearCommand.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));
            //指定命令目标
            this.button1.CommandTarget = this.textboxA;
            //创建命令关联
            CommandBinding cb = new CommandBinding();
            cb.Command = this.clearCommand;
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Execute);
            //把命令关联安置在外围控件上
            this.stackPanel.CommandBindings.Add(cb);
        }
        
        private void cb_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            this.textboxA.Clear();
            e.Handled = true;
        }

        private void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.textboxA.Text))
            {
                e.CanExecute = false;
            }else
            {
                e.CanExecute = true;
            }
            e.Handled = true;
        }
    }
}
