using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    class Operation
    {
        public static int Count(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
            }
            return count;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;
            
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
        public static double Mean(int sum, int count)
        {
            double mean = sum / count;
            

            return mean;
        }
        public static void Reverse(int[] array)
        {
            for (int i = array.Length -1; i>=0; i--)
            {
                Console.Write("{0}, ",array[i]);
                
            }
        }

        internal static void Sort(int[] array)
        {
            
                int i, j, temp;
                int N = array.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            for (i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ", array[i]);
                
            }
            Console.WriteLine();
        }

        internal static void Rotate(int[] array, int dir, int move)
        {

            
            int temp, i;
            int[] arraycopy = new int[array.Length];

            
            

                for (i = 0; i < array.Length; i++)
            {
                if (dir == 1)
                {
                    //left
                    if (move > array.Length)
                    {
                        move %= array.Length;
                    }

                    if (i + move < array.Length)
                    {
                        temp = array[i];
                        arraycopy[i] = array[i + move];
                        array[i + move] = temp;
                    }
                    if (i + move >= array.Length)
                    {
                        temp = array[i];
                        arraycopy[i] = array[(i - array.Length) + move];
                        array[(i - array.Length) + move] = temp;
                    }
                }
                if (dir == 2)
                {

                    //right

                    if (move > array.Length)
                    {
                        move %= array.Length;
                    }
                    if (i - move >= 0)
                    {
                        temp = array[i];
                        arraycopy[i] = array[i - move];
                        array[i - move] = temp;
                    }
                    if (i - move < 0)
                    {
                        temp = array[i];
                        arraycopy[i] = array[(i + array.Length) - move];
                        array[(i + array.Length) - move] = temp;
                    }
                }

            }
            for (i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ", arraycopy[i]);

            }
        }

        internal static int[] Arraychoose(int[] arra, int[] arrb, int[] arrc)
        {
            int i = 0;
            while (i!=1)
            {
                Console.WriteLine("Please choose which array you would like to use.");
                Console.WriteLine("Type A for Array A");
                Console.WriteLine("Type B for Array B");
                Console.WriteLine("Type C for Array C");
                Console.Write("I would like Array: ");
                string checkme = Console.ReadLine();
                
                if (checkme == "A" || checkme == "a")
                {
                    return arra;
                    
                }
                else if (checkme == "B" || checkme == "B")
                {
                    return arrb;
                    
                }
                else if (checkme == "C" || checkme == "c")
                {
                    return arra;
                    
                }
                else if (checkme != "A")
                {
                    Console.WriteLine("\nThats not quite right try again.\n");
                }

            }
            Console.WriteLine("Somethings not right lets just use Array C Who doesnt like pi anyway.");
            return arrc;
        }

        public static (int, int) Directions()
        {
            int dir=0, move, i=0;
           

            while (i != 1)
            {
                Console.WriteLine("Would you like to move the array to the left or to the right?");
                Console.Write("Move it to the: ");
                string checkme = Console.ReadLine();
                if (checkme == "right" || checkme == "Right" || checkme == "r" || checkme == "R")
                {
                    dir = 2;
                    i++;
                }
                else if (checkme == "left" || checkme == "Left" || checkme == "l" || checkme == "L")
                {
                    dir = 1;
                    i++;
                }
                else if (checkme != "left" || checkme != "Left" || checkme != "l" || checkme != "L"
                    || checkme != "right" || checkme != "Right" || checkme != "r" || checkme != "R")
                {
                    Console.WriteLine("\nI didnt understand that. please check your spelling\n");
                }
            }
                Console.WriteLine("\n How many spaces would you like to move it?");
                Console.Write("Move it over: ");

                while (!int.TryParse(Console.ReadLine(), out move))
                {
                    Console.WriteLine("\nI dont think that was a number. try again");
                    Console.Write("Move it over: ");

                }
                return (dir, move);
        }
    }
}
