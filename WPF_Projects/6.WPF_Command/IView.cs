
// <copyright company="Microsoft"> 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>using System;
namespace _6.WPF_Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    public interface IView
    {
        bool IsChanged { get; set; }

        void SetBinding();
        void Refresh();
        void Clear();
        void Save();
    }

    public class ClearCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            IView view = parameter as IView;
            if (view != null)
            {
                view.Clear();
            }
        }
    }

    public class MyCommandSource : UserControl, ICommandSource
    {
        public ICommand Command
        {
            get;set;
        }

        public object CommandParameter
        {
            get; set;
        }

        public IInputElement CommandTarget
        {
            get; set;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            if (this.CommandTarget != null)
            {
                this.Command.Execute(this.CommandTarget);
            }
        }
    }


}
