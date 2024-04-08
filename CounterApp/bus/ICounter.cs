using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApp.bus
{
    internal interface ICounter
    {
        void countUp();
        void reset();
    }
}
