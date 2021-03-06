﻿using System;
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
    /// Interaction logic for Binding_MultiplyBinding.xaml
    /// </summary>
    public partial class Binding_MultiplyBinding : Window
    {
        public Binding_MultiplyBinding()
        {
            InitializeComponent();
            SetMultiBinding();
        }

        private void SetMultiBinding()
        {
            //准备基础Binding
            Binding bind1 = new Binding("Text") { Source = textBox1 };
            Binding bind2 = new Binding("Text") { Source = textBox2 };
            Binding bind3 = new Binding("Text") { Source = textBox3 };
            Binding bind4 = new Binding("Text") { Source = textBox4 };

            //准备MultiBinding
            MultiBinding mb = new MultiBinding() { Mode = BindingMode.OneWay };
            mb.Bindings.Add(bind1);//注意，MultiBinding对子元素的顺序是很敏感的。
            mb.Bindings.Add(bind2);
            mb.Bindings.Add(bind3);
            mb.Bindings.Add(bind4);
            mb.Converter = new MultiBindingConverter();
            ///将Binding和MultyBinding关联
            this.btnSubmit.SetBinding(Button.IsEnabledProperty, mb);
        }
    }
}
