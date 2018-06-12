using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09Interfaces_DI_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            electronics phone = new electronics(new Phone());
            phone.Start();
            electronics computer = new electronics(new Computer());
            computer.Start();

        }
    }
}
