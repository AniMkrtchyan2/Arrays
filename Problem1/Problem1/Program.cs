using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            double[] doubleArray = new double[] { 1.3, 3.5, 4.55 };
            int lenght=doubleArray.GetLength(0);
            Console.WriteLine("Input double elements Array");
            foreach(double itm in doubleArray)
                {
                Console.Write("{0}"," "+itm);
                }
            Console.Write(Environment.NewLine+ "Return int elements Array"+Environment.NewLine);
          int [] intArray=changingArray(doubleArray, lenght);
            foreach(int itm in intArray)
                {
                Console.Write("{0}"," "+itm);
                }
            Console.ReadKey();

        }
        static int [] changingArray(double[] doubleArray, int length)
            {
           int[] intArray = new int[length];
            for (int i=0; i<length; ++i)
            {
            intArray[i] =Convert.ToInt32(doubleArray[i]);
            }
            return intArray;
            }
    }

   }

