using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Instantiated a List<T>
            var names = new List<string> {"Kyle","Tom","Brittany"};

            //Added/Removed Elements
            names.Add("Quincy");
            names.Add("Paul");
            names.Remove("Kyle");

            //Use foreach loop to print to console all names
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");  //displaying two options to interpolate
                Console.WriteLine("Hello {0}", name.ToUpper()); 
                //Console.ReadLine(); //this line is also being looped over press enter to see each name

            } //set breakpoint here to stepover and see the looping

            //Referencing Indices and total Count
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it");

            //Search and sorting lists
            var index = names.IndexOf("Quincy");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
                Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort(); //Sorts strings alphabetically
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
            */
            //Lists of other types
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);
            }
            foreach(var item in fibonacciNumbers)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
