
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>using System;
namespace _1.WPF_HelloWorld
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TypeConverter(typeof(StringToHumanTypeConverter))]
    public class Human
    {
        public string Name { get; set; }
        public Human Child { get; set; }
    }
}
