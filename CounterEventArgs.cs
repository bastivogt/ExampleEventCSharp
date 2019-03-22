using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEvent
{

    public class CounterEventArgs : EventArgs
    {
        private int _Count;

        public int Count
        {
            get
            {
                return this._Count;
            }
        }

        public CounterEventArgs(int count)
        {
            this._Count = count;
        }
    }
}
