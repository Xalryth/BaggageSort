using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSort.Types;
using BaggageSort.ModelView.Commands;
using BaggageSort.Model;
using System.Collections.ObjectModel;

namespace BaggageSort.ModelView
{
    public class ViewModel : ViewModelBase
    {
        private ObservableCollection<Sorter> sorterCollection = new ObservableCollection<Sorter>();

        public SwitchStateCommand switchStateCommand { get; set; }
        public ObservableCollection<Sorter> SorterCollection { get => sorterCollection; set => sorterCollection = value; }

        public ViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                sorterCollection.Add(new Sorter());
            }

            //Sorter.TerminalList.Add(new Terminal(Destination.Bornholm));
            //Sorter.TerminalList.Add(new Terminal(Destination.NewYork));
            //Sorter.TerminalList.Add(new Terminal(Destination.Dubai));
            sorterCollection[0].TerminalList.Add(new Terminal(Destination.Bornholm));
            sorterCollection[0].TerminalList.Add(new Terminal(Destination.NewYork));
            sorterCollection[0].TerminalList.Add(new Terminal(Destination.Dubai));

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
