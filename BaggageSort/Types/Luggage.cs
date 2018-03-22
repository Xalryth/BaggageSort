using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaggageSort.Types
{
    public struct Luggage
    {
        public UInt32 id;
        public DateTime date;
        public Destination destination;

        public Luggage(uint id, DateTime date, Destination destination)
        {
            this.id = id;
            this.date = date;
            this.destination = destination;
        }


        public override string ToString()
        {
            return $"[{id}]: {destination.ToString()}, {date.ToString("dd-MM-yy")}";
        }
    }
}
