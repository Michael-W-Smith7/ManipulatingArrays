using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper = new Operation();
            int[] arra = new int[6]
            {
                0,2,4,6,8,10
            };
            int[] arrb = new int[5]
            {
                1,3,5,7,9
            };
            int[] arrc = new int[12]
            {
                3,1,4,1,5,9,2,6,5,3,5,9
            };
            
            Console.WriteLine("Counting summing and computing the mean");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Array A count, Sum, and Mean\n");

            var count = Operation.Count(arra);
            var sum = Operation.Sum(arra);
            var mean = Operation.Mean(sum, count);
           
            Console.WriteLine($"Array A has {count} integers inside.");
            Console.WriteLine($"The sum of the array is {sum}");
            Console.WriteLine($"The mean of the array is {mean}");

            count = Operation.Count(arrb);
            sum = Operation.Sum(arrb);
            mean = Operation.Mean(sum, count);

            Console.WriteLine($"\nArray B has {count} integers inside.");
            Console.WriteLine($"The sum of the array is {sum}");
            Console.WriteLine($"The mean of the array is {mean}");

            count = Operation.Count(arrc);
            sum = Operation.Sum(arrc);
            mean = Operation.Mean(sum, count);

            Console.WriteLine($"\nArray C has {count} integers inside.");
            Console.WriteLine($"The sum of the array is {sum}");
            Console.WriteLine($"The mean of the array is {mean}");

            Console.WriteLine("\nReversing arrays");
            Console.WriteLine("---------------------------------------\n");

            Console.WriteLine("Array A in reverse is");
            Operation.Reverse(arra);

            Console.WriteLine("\n\nArray B in reverse is");
            Operation.Reverse(arrb);

            Console.WriteLine("\n\nArray C in reverse is");
            Operation.Reverse(arrc);
            Console.WriteLine("");



            Console.WriteLine("\nRotating arrays");
            Console.WriteLine("---------------------------------------\n");
            int[] arrvar = Operation.Arraychoose(arra, arrb, arrc);
            (int dir, int move) = Operation.Directions();
            move = Math.Abs(move);
            Operation.Rotate(arrvar, dir, move);

            Console.WriteLine("\nSorting pie arrays");
            Console.WriteLine("---------------------------------------\n");
            Operation.Sort(arrc);


            
        }
    }
}
