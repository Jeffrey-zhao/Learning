
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>using System;
namespace _4.WPF_Property
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Data;

    public class Student : DependencyObject
    {
        // CLR 属性包装
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        // 依赖属性
        // Using a DependencyProperty as the backing store for NameProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(Student),new PropertyMetadata());

        // SetBinding 包装
        public BindingExpressionBase SetBinding(DependencyProperty dp,BindingBase binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }
    }
}
