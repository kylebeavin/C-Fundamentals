using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Attack();
            player.Attack(1);
            Console.ReadLine();
        }
    }
}
