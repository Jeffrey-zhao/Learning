
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>using System;
namespace _1.WPF_HelloWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;


    public class MyButton : Button
    {
        public Type UserWindowType { get; set; }

        protected override void OnClick()
        {
            base.OnClick();
            Window win = Activator.CreateInstance(this.UserWindowType) as Window;
            if (win != null)
            {
                win.ShowDialog();
            }
        }
    }
}
