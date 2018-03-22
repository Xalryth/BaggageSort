using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSort.Types;
using BaggageSort.ModelView.Commands;

namespace BaggageSort.ModelView
{
    public class ViewModel : ViewModelBase
    {
        public SortCommand sortCommand { get; set; }
        public FlyCommand flyCommand { get; set; }
        public OpenCloseCommand openCloseCommand { get; set; }
        public FillFlightCommand fillFlightCommand { get; set; }
        public GenerateLuggageCommand generateLuggageCommand { get; set; }

        public void SortLuggage()
        {
            //Need implementation
        }

        public void Fly()
        {
            //Need implementation
        }

        public void OpenClose()
        {
            //Need implementation
        }

        public void FillFlight()
        {
            //Need implementation
        }

        public Luggage GenerateLuggage()
        {
            return new Luggage();
        }
    }
}
