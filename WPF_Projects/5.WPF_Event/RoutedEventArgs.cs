
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>using System;
namespace _5.WPF_Event
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    class ReportTimeEventArgs : RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent routedEvent, object source) : base(routedEvent, source)
        {

        }

        public DateTime ClickTime { get; set; }
    }
}
