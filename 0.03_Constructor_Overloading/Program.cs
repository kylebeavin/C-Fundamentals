using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Constructor_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Music beatles = new Music();
            Music rolling = new Music("rolling stones");
            Music zeppelin = new Music("Led Zeppelin","stairway");
            Music toby = new Music("toby keith", "greatest", 2000);
        }
    }
}
