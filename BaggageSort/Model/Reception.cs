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
        private static uint dateStep = 0;
        Random rnd = new Random();

        private static Queue<Luggage> newLuggage = new Queue<Luggage>();

        public Reception() { }
        
        public Random Rnd { get => rnd; set => rnd = value; }
        public uint Count { get => count; set => count = value; }
        public static uint DateStep { get => dateStep; set => dateStep = value; }

        public void GenerateLuggage() {
            Count++;
            newLuggage.Enqueue(new Luggage(Count));
        }
    }
}
