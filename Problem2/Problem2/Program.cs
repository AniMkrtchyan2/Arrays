using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
       public static void Main()
        {
            ArrayList myList = new ArrayList(5);
            myList.Add(1);
            myList.Add(3);
            myList.Add(5);
            myList.Add(7);
            myList.Add(9);
            foreach (int itm in myList)
            {
                Console.WriteLine(itm);
            }
            Console.WriteLine("\nInput number");
            int required_number =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("The ArrayList after Removing elements");
            myList.RemoveAt(required_number);
            foreach (int itm in myList)
            {
                Console.WriteLine(itm);
            }
           
        }
}
}
