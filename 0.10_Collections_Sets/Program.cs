using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashSet = new HashSet<string>()
            {
                "apples","bananas","oranges","lemons","grapes"
            };
            hashSet.Add("bananas");
            hashSet.Add("cherries");
            //hashSet.Remove("apples");
            //hashSet.Clear(); //removes all objects

            var contains = hashSet.Contains("bananas");
            Console.WriteLine(contains);

            var counts = hashSet.Count();
            Console.WriteLine(counts);

            foreach (var h in hashSet)
            {
                Console.WriteLine(h);
            }
            Console.ReadLine();
        }
    }
}
