using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSort.Model;

namespace BaggageSort.Types
{
    public struct Luggage
    {
        public UInt32 id;
        public DateTime date;
        public Destination destination;

        public Luggage(uint id)
        {
            Random rnd = new Random();

            this.id = id;
            this.date = new DateTime(Reception.DateStep).AddDays(rnd.Next(0, 3));
            destination = (Destination)rnd.Next(0, Enum.GetNames(typeof(Destination)).Length - 1);
        }


        public override string ToString()
        {
            return $"[{id}]: {destination.ToString()}, {date.ToString("dd-MM-yy")}";
        }
    }
}
