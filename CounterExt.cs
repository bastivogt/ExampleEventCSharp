using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEvent
{
    class CounterExt : Counter
    {
        public CounterExt() : base()
        {

        }

        public CounterExt(int max) : base(max)
        {

        }

        public CounterExt(int count, int max, int steps) : base(count, max, steps)
        {

        }
    }
}
