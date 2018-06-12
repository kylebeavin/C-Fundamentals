using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09Interfaces_DI_Practice
{
    class Computer : IStartable
    {
        public void Start2()
        {
            Console.WriteLine("your computer started");
        }
    }
}
