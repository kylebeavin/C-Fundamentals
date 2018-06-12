using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new Dictionary<string, string>();
            movies.Add("2000", "Gladiator");
            movies.Add("2001", "A Beautiful Mind");
            movies.Add("2002", "Chicago");
            movies.Add("2003", "Lord of the Rings");
            movies.Add("2004", "Million Dollar Baby");
            movies.Add("2005", "Crash");
            foreach (KeyValuePair<string,string>m in movies)
            {
                Console.WriteLine(m.Key + " " + m.Value);
            }
            Console.ReadLine();
        }
    }
}
