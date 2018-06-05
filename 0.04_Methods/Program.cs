using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemies gandor = new Enemies(45, "gandor", 100, 5);
            gandor.SayName();
            Console.WriteLine(gandor.returnHealth());

        }
    }
}
