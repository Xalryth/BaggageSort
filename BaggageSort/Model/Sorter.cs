using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSort.Types;

namespace BaggageSort.Model
{
    public class Sorter
    {
        private Queue<Luggage> luggageQueue = new Queue<Luggage>();
        private static List<Terminal> terminalList = new List<Terminal>();

        //public Queue<Luggage> LuggageQueue
        //{
        //    get { return luggageQueue; }
        //    set { luggageQueue = value; }
        //}

        //public static List<Terminal> TerminalList
        //{
        //    get { return terminalList; }
        //    set { terminalList = value; }
        //}

        public Queue<Luggage> LuggageQueue { get => luggageQueue; set => luggageQueue = value; }
        public List<Terminal> TerminalList { get => terminalList; set => terminalList = value; }

        public Sorter()
        {

        }

        public Sorter(Queue<Luggage> luggageQueue, List<Terminal> terminalList)
        {
            LuggageQueue = luggageQueue;
            TerminalList = terminalList;
        }

        public void SortLuggage()
        {
            for (int i = 0; i < LuggageQueue.Count; i++)
            {
                for (int j = 0; j < TerminalList.Count; j++)
                {
                    if (LuggageQueue.Peek().destination == (Destination)TerminalList[j].Destination)
                    {
                        TerminalList[i].Luggages.Enqueue(LuggageQueue.Dequeue());
                        break;
                    }
                }
            }
        }
    }
}
