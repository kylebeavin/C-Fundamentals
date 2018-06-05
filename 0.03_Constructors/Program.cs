using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog lassie = new Dog("border collie", "lassie", 40, false);
            //Dog snowflake = new Dog("pitbull", "snowflake", 3, true);

            Console.WriteLine("what kind of dog do you want?");
            string breed = Console.ReadLine();

            Console.WriteLine("what will the dog's name be?");
            string name = Console.ReadLine();

            Console.WriteLine("how old do you want it to be?");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("do you want it to be cute?true or false?");
            bool isCute = Convert.ToBoolean(Console.ReadLine());

            Dog dogOrder = new Dog(breed, name, age, isCute);
            Console.WriteLine("{0},{1},{2},{3}",breed,name,age,isCute);
        }
    }
}
