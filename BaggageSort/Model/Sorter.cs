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

        public Queue<Luggage> LuggageQueue
        {
            get { return luggageQueue; }
            set { luggageQueue = value; }
        }

        public static List<Terminal> TerminalList
        {
            get { return terminalList; }
            set { terminalList = value; }
        }
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
            for (int i = 0; i < luggageQueue.Count; i++)
            {
                for (int j = 0; j < terminalList.Count; j++)
                {
                    if (luggageQueue.Peek().destination == (Destination)terminalList[j].Destination)
                    {
                        terminalList[i].Luggages.Enqueue(luggageQueue.Dequeue());
                        break;
                    }
                }
            }
        }
    }
}
