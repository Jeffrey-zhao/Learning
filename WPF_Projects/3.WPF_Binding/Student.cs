
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>using System;
namespace _3.WPF_Binding
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if (null != this.PropertyChanged)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
    }
}
