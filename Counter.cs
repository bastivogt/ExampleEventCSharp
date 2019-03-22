using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEvent
{



    public class Counter
    {




        public event CounterEventHandler CounterStart;
        public event CounterEventHandler CounterChange;
        public event CounterEventHandler CounterFinish;

        public virtual int Max { get; set; } = 10;
        public virtual int Count { get; set; } = 0;
        public virtual int Steps { get; set; } = 1;

        public Counter() : this(0, 10, 1)
        {

        }


        public Counter(int max) : this(0, max, 1)
        {
            
        }

        public Counter(int count, int max, int steps)
        {
            this.Count = count;
            this.Max = max;
            this.Steps = steps;
        }


        // Eventmethoden bereitstellen virtual wegen Vererbung
        protected virtual void OnCounterStart(CounterEventArgs e)
        {
            if(this.CounterStart != null)
            {
                this.CounterStart(this, e);
            }
        }


        protected virtual void OnCounterChange(CounterEventArgs e)
        {
            if(this.CounterChange != null)
            {
                this.CounterChange(this, e);
            }
        }


        protected virtual void OnCounterFinisch(CounterEventArgs e)
        {
            if(this.CounterFinish != null)
            {
                this.CounterFinish(this, e);
            }
        }

        public virtual void Run()
        {
            // CounterStart
            this.OnCounterStart(new CounterEventArgs(this.Count));
            
            for(; this.Count < this.Max; this.Count += this.Steps)
            {
                // CounterChange
                this.OnCounterChange(new CounterEventArgs(this.Count));
                
            }
            // CounterFinisch
            this.OnCounterFinisch(new CounterEventArgs(this.Count));
            
        }

        public virtual void Reset(int count, int max)
        {
            this.Count = count;
            this.Max = max;
        }
    }


}
