using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RECURSION
{
    internal class Program
    {
        /*
         ********************* ITERATION VS RECURSION ***************************
         * Implementation  Uses Loops   |   Calls itself                        *
         * State           Index-Based  |   Parameter-Based                     *
         * Progression     Moves towards condition   |  Moves towards base case *
         * Termination     Index satisfies condition |  Base case satisfied     *
         * Size            More code, less memory    |  Less code, more memory  *
         * Speed           Faster       |   Can be faster, but usually slower   *
         ************************************************************************
         */

        static void Main(string[] args)
        {
            //Recursion **********************************
            //Applying a result of a process to a process
            //A recursive method calls itself
            //Recursion ⇋ Iteration
            //Common uses: advanced sorting algorithms | navigating trees

            //Easier to code & debug
            //But can be slower and consume more memory
            //********************************************

            //walk(1000000);
            //Console.WriteLine(factorial(7));

            Console.WriteLine(power(0, 8));

            Console.ReadKey();
        }

        private static int power(int baseN, int exponent)
        {
            if (baseN == 0)
            {
                return 0;
            }else if (exponent < 1)
            {
                return 1;
            }

            return baseN * power(baseN, exponent - 1);
        }

        //private static int factorial(int n)
        //{
        //    if(n < 1) //base case
        //    {
        //        return 1; 
        //    }

        //    return n * factorial(n - 1); //recursive case
        //}

        //ITERATIVE
        //private static void walk(int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.WriteLine("You take a step");
        //    }
        //}
        
        //RECURSIVE
        //private static void walk(int steps)
        //{
        //    if (steps < 1)
        //    {
        //        return;
        //    }

        //    Console.WriteLine("You take a step");
        //    walk(steps - 1); //call the method in itself
        //}
    }
}
