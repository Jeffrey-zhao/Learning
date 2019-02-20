
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>using System;
namespace _3.WPF_Binding
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public enum Category
    {
        Bomber,
        Fighter
    }

    public enum State
    {
        Available,
        Locked,
        Unknown
    }

    public class Plane
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }
}
