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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Example
{
    /// <summary>
    /// Interaction logic for Win_Number_TextCtl.xaml
    /// </summary>
    public partial class Win_Number_TextCtl : UserControl
    {
        private Grid grid = null;
        private Window wm = null;

        private double left = 0;
        private double top = 0;

        private string txtValue = string.Empty;
        public string TxtValue
        {
            get { return txtValue; }
            set
            {
                txtValue = value;
                this.tb.Text = txtValue;
            }
        }

        private Storyboard sb = null;
        public Win_Number_TextCtl(Grid _grid,Window _wm)
        {
            InitializeComponent();

            grid = _grid;
            wm = _wm;
            left = wm.Left;
            top = wm.Top;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            sb = new Storyboard();
            //scaleX
            DoubleAnimation dax = new DoubleAnimation();
            dax.Duration = TimeSpan.FromSeconds(0.6);
            dax.From = 20;
            dax.To = 1;
            Storyboard.SetTarget(dax, this);
            Storyboard.SetTargetProperty(dax, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)"));

            //scaley
            DoubleAnimation day = new DoubleAnimation();
            day.Duration = TimeSpan.FromSeconds(0.6);
            day.From = 20;
            day.To = 1;
            Storyboard.SetTarget(day, this);
            Storyboard.SetTargetProperty(day, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)"));

            //Opacity变换动画
            DoubleAnimation dao = new DoubleAnimation();
            dao.Duration = TimeSpan.FromSeconds(0.6);
            dao.From = 0;
            dao.To = 1;
            Storyboard.SetTarget(dao, this);
            Storyboard.SetTargetProperty(dao, new PropertyPath("(Opacity)"));
            sb.Children.Add(dax);
            sb.Children.Add(day);
            sb.Children.Add(dao);

            //抖动效果
            DoubleAnimation daLeft1 = new DoubleAnimation();
            daLeft1.BeginTime = TimeSpan.FromSeconds(0.6);
            daLeft1.Duration = TimeSpan.FromSeconds(0.2);
            daLeft1.From = wm.Left;
            daLeft1.To = wm.Left - 10;
            daLeft1.EasingFunction = new BounceEase() { Bounces = 10, EasingMode = EasingMode.EaseInOut };
            Storyboard.SetTarget(daLeft1, wm);
            Storyboard.SetTargetProperty(daLeft1, new PropertyPath("(Left)"));

            DoubleAnimation daLeft2 = new DoubleAnimation();
            daLeft2.BeginTime = TimeSpan.FromSeconds(0.7);
            daLeft2.Duration = TimeSpan.FromSeconds(0.2);
            daLeft2.From = wm.Left;
            daLeft2.To = wm.Left + 10;
            daLeft2.EasingFunction = new BounceEase() { Bounces = 10, EasingMode = EasingMode.EaseInOut };
            Storyboard.SetTarget(daLeft2, wm);
            Storyboard.SetTargetProperty(daLeft2, new PropertyPath("(Left)"));

            DoubleAnimation daTop1 = new DoubleAnimation();
            daTop1.BeginTime = TimeSpan.FromSeconds(0.6);
            daTop1.Duration = TimeSpan.FromSeconds(0.2);
            daTop1.From = wm.Top;
            daTop1.To = wm.Top + 10; ;
            daTop1.EasingFunction = new BounceEase() { Bounces = 10, EasingMode = EasingMode.EaseInOut };
            Storyboard.SetTarget(daTop1, wm);
            Storyboard.SetTargetProperty(daTop1, new PropertyPath("(Top)"));

            DoubleAnimation daTop2 = new DoubleAnimation();
            daTop2.BeginTime = TimeSpan.FromSeconds(0.7);
            daTop2.Duration = TimeSpan.FromSeconds(0.2);
            daTop2.From = wm.Top;
            daTop2.To = wm.Top - 10;
            daTop2.EasingFunction = new BounceEase() { Bounces = 10, EasingMode = EasingMode.EaseInOut };
            Storyboard.SetTarget(daTop2, wm);
            Storyboard.SetTargetProperty(daTop2, new PropertyPath("(Top)"));

            sb.Children.Add(daLeft1);
            sb.Children.Add(daLeft2);
            sb.Children.Add(daTop1);
            sb.Children.Add(daTop2);

            sb.Completed += new EventHandler(sb_Completed);
            sb.Begin(this, true);
        }

        private void sb_Completed(object sender, EventArgs e)
        {
            //解除绑定 
            sb.Remove(this);
            sb.Children.Clear();
            grid.Children.Clear();
            //窗体恢复初始位置
            wm.Left = left;
            wm.Top = top;
        }
    }
}
