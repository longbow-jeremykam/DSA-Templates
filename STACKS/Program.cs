using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stacks *******************************************
            //LIFO (LAST-IN FIRST-OUT) data structure
            //Ex: A stack of books (object)
            //**************************************************

            Stack<String> stack = new Stack<string>();

            //push() to add to the top
            stack.Push("Minecraft");
            stack.Push("Skyrim");
            stack.Push("DOOM");
            stack.Push("Borderlands");
            stack.Push("FFVII");

            //pop() to remove from the top,
            //it also returns the element value which can be assigned to a variable
            //stack.Pop();

            //peek() to return the topmost element without removing it
            //Console.WriteLine(stack.Peek());

            

            //printing the stack through foreach loop
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }

            //Contains() to determine whether stack contains element
            //Console.WriteLine(stack.Contains("COD"));

            //Reproduce the out of memory exception
            //for (int i = 0; i < 1000000000; i++)
            //{
            //    stack.Push("Fallout76");
            //}


            //USES OF STACKS
            /*
             * 1. Undo/redo features in text editors
             * 2. Go back and forth through browser history
             * 3. Task scheduling
             * 4. Backtracking algorithms (e.g., maze, file directories)
             * 5. Calling functions (call stack)
             * 6. DPS (Depth-first search)
             */

            Console.ReadKey();
        }
    }
}
