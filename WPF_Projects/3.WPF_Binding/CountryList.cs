
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>using System;
namespace _3.WPF_Binding
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class City
    {
        public string Name { get; set; }
    }

    class Province
    {
        public string Name { get; set; }
        public List<City> Citys { get; set; }
    }

    class Country
    {
        public string Name { get; set; }
        public List<Province> Provinces { get; set; }
    }
}
