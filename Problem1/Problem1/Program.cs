using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Array = new double[] { 1.5, 3.5, 4.55 };
            int[] Array2 = new int[3];
            foreach (var d in Array)
                Console.WriteLine(d);
            Console.WriteLine("------------------------");
            Array2 = Array.Select(d => (int)d).ToArray();
            foreach(var i in Array2 )
                Console.WriteLine(i);
        }
    }
}
