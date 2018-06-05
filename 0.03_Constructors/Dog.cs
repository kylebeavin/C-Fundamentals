using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Constructors
{
    class Dog
    {
        public Dog(string b, string n, int a, bool ic)
        {
            this.Breed = b;
            this.Name = n;
            this.Age = a;
            this.IsCute = ic;
        }

        public string Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsCute { get; set; }
    }
}
