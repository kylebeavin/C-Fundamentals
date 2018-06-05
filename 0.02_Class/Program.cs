using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objects set properties
            Car car1 = new Car();
            car1.Make = "ford";
            car1.Model = "f150";
            car1.Year = 2006;
            car1.VINNum = 1234567890;
            
            //Object2 setting properties with application
            Car car1demo = new Car();
            Console.WriteLine("What is your car's Make?");
            car1demo.Make = Console.ReadLine();

            Console.WriteLine("What is the model");
            car1demo.Model = Console.ReadLine();

            Console.WriteLine("what year is it");
            string year = Console.ReadLine();
            car1demo.Year = Int32.Parse(year);

            Console.WriteLine("whats the vin");
            car1demo.VINNum = Int32.Parse(Console.ReadLine());

        }
    }
}