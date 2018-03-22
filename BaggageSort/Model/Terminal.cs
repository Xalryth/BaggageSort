using BaggageSort.Types;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaggageSort.Model
{
    class Terminal
    {
        private Queue<Luggage> luggages;
        private DateTime leaveDate;
        private Enum destination;
        private bool locked;

        public Queue<Luggage> Luggages { get => luggages; set => luggages = value; }
        public DateTime LeaveDate { get => leaveDate; set => leaveDate = value; }
        public Enum Destination { get => destination; set => destination = value; }

        public Terminal(Enum _dest)
        {
            destination = _dest;
            // leavedate?
        }
        // Handle luggage ?
        public void Fly()
        {
            Debug.WriteLine("Plane id flying away");
            locked = true;
        }
        public void SwitchState()
        {
            Debug.WriteLine("User locked the terminal");
            locked = true;
        }

    }
}
