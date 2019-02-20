
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
    using System.Windows.Controls;

    class TimeButton : Button
    {
        public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent("ReportTime", RoutingStrategy.Bubble, typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));

        public event RoutedEventHandler ReportTime
        {
            add { this.AddHandler(ReportTimeEvent,value); }
            remove { this.RemoveHandler(ReportTimeEvent, value); }
        }

        protected override void OnClick()
        {
            base.OnClick();

            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this);
            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }
    }
}
