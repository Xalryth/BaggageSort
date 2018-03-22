using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSort.Types;

namespace BaggageSort.Model
{
    public class Reception
    {
        uint count = 0;
        uint dateStep = 0;
        Random rnd = new Random();

        public Reception() { }

        public Luggage GenerateLuggage() {
            count++;
            dateStep++;
            return new Luggage(count, new DateTime(0).AddMinutes(dateStep), (Destination)rnd.Next(0, Enum.GetNames(typeof(Destination)).Length - 1));
        }
    }
}
