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
             int [] array= new int[5] {1,2,3,4,5};
            foreach(int itm in array)
                { Console.WriteLine(itm);}
            Console.WriteLine("Removing the element at index 3\n");
            int removAt=3;
           int [] newArray= RemoveArray(array,removAt);
            foreach (int currentValue in newArray) 
                {Console.WriteLine(currentValue);}
        Console.ReadKey();
            }

       public static int [] RemoveArray(int[] array, int removAt)
    {
        int difference = 0, currentValue=0;
        //get new Array length
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]==removAt)
            {
                difference += 1;
            }
        }
        //create new array
        int[] newArray = new int[array.Length-difference];
        for (int i = 0; i < array.Length; i++ )
        {
            if (array[i] != removAt)
            {
                newArray[currentValue] = array[i];
                currentValue += 1;
            }
        }

        return newArray;
    }
    }
        
}


