using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CounterApp.bus
{
    public class DataCollection
    {

        private static List<Counter> listOfCounters = new List<Counter>();

        public static List<Counter> ListOfCounters
        {
            get { return listOfCounters; }

            set { listOfCounters = value; }
        }

        public static void Add(Counter newCounter)
        {
            ListOfCounters.Add(newCounter);
        }

        public static void Remove(Counter newCounter)
        {
            ListOfCounters.Remove(newCounter);
        }

        public static void RemoveAt(int currentIndex)
        {
            ListOfCounters.RemoveAt(currentIndex);
        }

        public static void InsertAt(int currentIndex, Counter currentCounter)
        {
            listOfCounters.Insert(currentIndex, currentCounter);
        }

        public static void Clear() { }

        public static Counter Search(int key)
        {
            foreach (Counter currentCounter in ListOfCounters)
            {
                if (currentCounter.Serial == key)
                {
                    return currentCounter;
                }
            }

            return null; 
        }


        public static List<Counter> GetCounterList()
        {
            return ListOfCounters;
        }




    }
}
