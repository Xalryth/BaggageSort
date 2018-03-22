using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSort.Types;
using BaggageSort.ModelView.Commands;
using BaggageSort.Model;

namespace BaggageSort.ModelView
{
    public class ViewModel : ViewModelBase
    {
        public SwitchStateCommand switchStateCommand { get; set; }

        public ViewModel()
        {
            switchStateCommand = new SwitchStateCommand();
        }

        public void SwitchState(Terminal terminalToChange)
        {
            if (terminalToChange.Locked)
                terminalToChange.Locked = false;
            else
                terminalToChange.Locked = true;
            OnPropertyChanged();
        }
    }
}
