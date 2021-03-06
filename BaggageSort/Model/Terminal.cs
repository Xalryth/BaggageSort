﻿using BaggageSort.Types;
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
        public bool FlightAvailable { get => flightAvailable; set => flightAvailable = value; }

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
            if (_luggage.date.Date >= DateTime.Now.Date)
            {

                if (!Locked && luggages.Count() < CargoSize)
                    luggages.Enqueue(_luggage);
                else
                    leftOverLuggage.Enqueue(_luggage);
            }
            else
            {
                leftOverLuggage.Enqueue(_luggage);
            }
        }
        private void FillFlight()
        {
            luggages.Clear();
        }
        private void Fly()
        {
            Debug.WriteLine($"Plane to {Destination.ToString()} is flying away");
            FillFlight();
            locked = true;
            FlightAvailable = false;
        }
        /// <summary>
        /// Used for locking/unlocking the terminal
        /// </summary>
        public void SwitchState()
        {
            locked = !locked;
            Debug.WriteLine($"Terminal locked: {locked}");
        }
        /// <summary>
        /// Task that simulates flight times - when time is up the Task sends the plane away
        /// </summary>
        private async void TimeManager()
        {
            while (true)

                // Check the leave time instead ! TODO
                if (!FlightAvailable)
                {
                    await Task.Delay(TimeSpan.FromMinutes(new Random().Next(2, 5)));
                    CheckLeftOvers();
                    locked = false;
                    FlightAvailable = true;
                }
                else
                {
                    Fly();
                    await Task.Delay(TimeSpan.FromSeconds(30));
                }
        }
        /// <summary>
        /// Controls the leftoverluggages for luggage that needs to be on the next flight.
        /// </summary>
        private void CheckLeftOvers()
        {
            int capa = LeftOverLuggage.Count();
            for (int i = 0; i < capa; i++)
            {
                if (LeftOverLuggage.Peek().date.Date >= DateTime.Now.Date)
                {
                    Luggages.Enqueue(LeftOverLuggage.Dequeue());
                    capa--;
                }
            }
        }
    }
}

