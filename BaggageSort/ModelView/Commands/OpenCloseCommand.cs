﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BaggageSort.ModelView.Commands
{
    public class OpenCloseCommand : ICommand
    {
        public ViewModel viewModel;

        public void OpenClose(ViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.viewModel.OpenClose();
        }
    }
}
