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

        public uint DateStep { get => dateStep; set => dateStep = value; }
        public Random Rnd { get => rnd; set => rnd = value; }
        public uint Count { get => count; set => count = value; }

        public Luggage GenerateLuggage() {
            Count++;
            return new Luggage(Count, new DateTime(DateStep).AddDays(Rnd.Next(0, 3)), (Destination)Rnd.Next(0, Enum.GetNames(typeof(Destination)).Length - 1));
        }
    }
}
