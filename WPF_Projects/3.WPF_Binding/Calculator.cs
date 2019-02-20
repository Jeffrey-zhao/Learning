
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>using System;
namespace _3.WPF_Binding
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Calculator
    {
        public string Arg1 { get; set; }
        public string Arg2 { get; set; }
        public Calculator()
        {

        }
        public Calculator(string arg1,string arg2)
        {
            this.Arg1 = arg1;
            this.Arg2 = arg2;
        }
        public string Add(string arg1, string arg2)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            if (double.TryParse(arg1, out x) && double.TryParse(arg2, out y))
            {
                z = x + y;
                return z.ToString();
            }
            return "Iput Error";
        }

        public string TryAdd()
        {
            double x = 0;
            double y = 0;
            double z = 0;
            if (double.TryParse(Arg1, out x) && double.TryParse(Arg2, out y))
            {
                z = x + y;
                return z.ToString();
            }
            return "Iput Error";
        }
        //其它方法省略
    }
}
