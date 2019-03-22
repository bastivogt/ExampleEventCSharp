using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEvent
{
    class Program
    {
        static void Main(string[] args)
        {

            CounterExt c = new CounterExt(20);
            //c.CounterStart += new CounterEventHandler(c_CounterStart);
            c.CounterStart += c_CounterStart;
            c.CounterChange += c_CounterChange;
            c.CounterFinish += c_CounterFinish;
            c.Run();

            Console.ReadLine();
        }

        public static void c_CounterStart(Object sender, CounterEventArgs e)
        {
            Console.WriteLine("start | counter = {0}", e.Count);
            //Console.WriteLine(((Counter)sender).Max);
            /*Counter c = sender as Counter;
            Console.WriteLine(c.Max);*/
        }

        public static void c_CounterChange(Object sender, CounterEventArgs e)
        {
            Console.WriteLine("change | counter = {0}", e.Count);
        }

        public static void c_CounterFinish(Object sender, CounterEventArgs e)
        {
            Console.WriteLine("finish | counter = {0}", e.Count);
            Console.WriteLine("----------------------- RESET -----------------------");

            CounterExt c = sender as CounterExt;
            c.CounterFinish -= c_CounterFinish;
            c.Reset(10, 40);
            c.Steps = 2;
            c.Run();
        }
    }
}
