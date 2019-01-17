using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<string>();

            dogs.Add("Bulldog");
            dogs.Add("Collie");
            dogs.Add("Retriever");

            //foreach to move through the list, it is for loop each item on the list
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog + " ");
            //}

            //Console.WriteLine(dogs[0]);

            //Let create n array of integers

            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };

            foreach (int i in a1)
            {
                Console.WriteLine("The value of i is {0}", i);
            }

            Console.ReadLine();
        }
    }
}
