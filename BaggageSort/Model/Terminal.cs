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
        private bool locked, flightAvailable;
        private int cargoSize = 200;
        private Task manager;

        public Queue<Luggage> Luggages { get => luggages; private set => luggages = value; }
        public DateTime LeaveDate { get => leaveDate; set => leaveDate = value; }
        public Enum Destination { get => destination; private set => destination = value; }
        public Queue<Luggage> LeftOverLuggage { get => leftOverLuggage; private set => leftOverLuggage = value; }
        public int CargoSize { get => cargoSize; private set => cargoSize = value; }
        public bool Locked { get => locked; set => locked = value; }

        public Terminal(Enum _dest)
        {
            destination = _dest;
            LeaveDate = new DateTime(Reception.DateStep); // messy messy code
            manager = new Task(TimeManager);
            manager.Start();
        }
        /// <summary>
        /// Handles luggage from sorting
        /// </summary>
        /// <param name="_luggage"></param>
        public void HandleLuggage(Luggage _luggage)
        {
            if (!Locked && luggages.Count() < CargoSize)
                luggages.Enqueue(_luggage);
            else
                leftOverLuggage.Enqueue(_luggage);
        }
        private void FillFlight()
        {
            luggages.Clear();
        }
        private void Fly()
        {
            Debug.WriteLine($"Plane to {Destination.ToString()} is flying away");
<<<<<<< HEAD
            Locked = true;
        }
        public void SwitchState()
        {
            Debug.WriteLine("User locked the terminal");
            Locked = true;
=======
            FillFlight();
            locked = true;
            flightAvailable = false;
        }
        public void SwitchState()
        {
            locked = !locked;
            Debug.WriteLine($"User locked: {locked}");
        }
        private async void TimeManager()
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromMinutes(new Random().Next(2,5)));
                if (!flightAvailable)
                {
                    locked = false;
                    flightAvailable = true;
                }
                else
                {
                    Fly();
                    await Task.Delay(TimeSpan.FromSeconds(30));
                }
            }
>>>>>>> bd6625e312a5dce69443b2915f57556e963855b5
        }
    }
}
