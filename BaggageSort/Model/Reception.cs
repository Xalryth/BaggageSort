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
        static uint count = 0;
        private static uint dateStep = 0;
        Random rnd = new Random();

        public Reception() { }
        
        public Random Rnd { get => rnd; set => rnd = value; }
        public static uint Count { get => count; set => count = value; }
        public static uint DateStep { get => dateStep; set => dateStep = value; }

        public Luggage GenerateLuggage() {
            Count++;
            return new Luggage(Count, new DateTime(DateStep).AddDays(Rnd.Next(0, 3)), (Destination)Rnd.Next(0, Enum.GetNames(typeof(Destination)).Length - 1));
        }
    }
}
