using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASH_TABLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hash Tables *************************************************************
            //A table that stores unique key to values as key/value pair entries
            //Fast at insertion and deletion
            //More ideal for larger data sets

            //Index Calculator: index = key.GetHashCode() % <table>.Count()
            //Multiple keys might have the same index

            //These keys are stored as a LinkedList at that index (collision)
            //less collision = better efficiency
            //Time complexity - O(1) best case / O(N) worst case
            //**************************************************************************

            //C# Hashtable is NON-GENERIC, so it cannot take type arguments (not type-safe)
            Hashtable table = new Hashtable(10);

            //Insertion
            table.Add("100", "Spongebob");
            table.Add("123", "Sandy");
            table.Add("321", "Patrick");
            table.Add("555", "Squidward");
            table.Add("777", "Gary");

            //Deletion
            //table.Remove(777);

            //Accessing a key pair value with the key
            //Console.WriteLine(table["100"]);

            //printing the hashtable with foreach loop
            foreach (String key in table.Keys)
            {
                Console.WriteLine(key.GetHashCode() % table.Count + "\t" + key + "\t" + table[key]);
            }

            Console.ReadKey();  
        }
    }
}
