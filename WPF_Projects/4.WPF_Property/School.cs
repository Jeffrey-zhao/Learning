
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
using System;

namespace _4.WPF_Property
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    public class School : DependencyObject
    {
        public static int GetGrade(DependencyObject obj)
        {
            return (int)obj.GetValue(GradeProperty);
        }

        public static void SetGrade(DependencyObject obj, int value)
        {
            obj.SetValue(GradeProperty, value);
        }

        // Using a DependencyProperty as the backing store for GradeProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GradeProperty =
            DependencyProperty.RegisterAttached("Grade", typeof(int), typeof(School), new UIPropertyMetadata(0));
    }

    public class Human : DependencyObject
    {

    }
}
