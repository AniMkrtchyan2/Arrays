using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = { {1,2,3}, {4,5,6}, {7,8,9} };
            Console.WriteLine("given square matrix");
           int i, j;
            for (i=0 ; i <matrix.GetLength(0); i++)
            {
                for (j=0 ; j <matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine);
               
            }
            Upper(matrix);
            Console.ReadKey();
        }
        static void Upper(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);
            int i, j;
           
            Console.WriteLine("Upper triangular matrix: ");

            for (i = 0; i <rowLength; i++)
            {
                for (j = 0; j < colLength; j++)
                {
                    if (i > j)
                    {
                        
                        Console.Write("0" + " ");
                    }
                    else
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }
                    

        }
    }
}
