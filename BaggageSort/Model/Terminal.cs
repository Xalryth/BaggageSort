using BaggageSort.Types;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaggageSort.Model
{
    public class Terminal
    {
        private Queue<Luggage> luggages;
        private Queue<Luggage> leftOverLuggage;
        private DateTime leaveDate;
        private Enum destination;
        private bool locked;
        private int cargoSize = 200;

        public Queue<Luggage> Luggages { get => luggages; private set => luggages = value; }
        public DateTime LeaveDate { get => leaveDate; set => leaveDate = value; }
        public Enum Destination { get => destination; private set => destination = value; }
        public Queue<Luggage> LeftOverLuggage { get => leftOverLuggage; private set => leftOverLuggage = value; }
        public int CargoSize { get => cargoSize; private set => cargoSize = value; }

        public Terminal(Enum _dest)
        {
            destination = _dest;
            LeaveDate = Reception.DateStep; // messy messy code
        }
        /// <summary>
        /// Handles luggage from sorting
        /// </summary>
        /// <param name="_luggage"></param>
        public void HandleLuggage(Luggage _luggage)
        {
            if (!locked && luggages.Count() < CargoSize)
                luggages.Enqueue(_luggage);
            else
                leftOverLuggage.Enqueue(_luggage);
        }
        public void FillFlight()
        {
            luggages.Clear();
        }
        public void Fly()
        {
            Debug.WriteLine($"Plane to {Destination.ToString()} is flying away");
            locked = true;
        }
        public void SwitchState()
        {
            Debug.WriteLine("User locked the terminal");
            locked = true;
        }

    }
}
