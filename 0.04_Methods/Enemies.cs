using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Methods
{
    class Enemies
    {
        public Enemies(int a, string n, double h, int ap)
        {
            this.Age = a;
            this.Name = n;
            this.Health = h;
            this.AttackPower = ap;
        }
        //Properties
        public int Age { get; set; }
        public string Name { get; set; }
        public double Health { get; set; }
        public int AttackPower { get; set; }
        //Methods
        public void SayName()
        {
            Console.WriteLine("{0}", this.Name.ToUpper());
            Console.WriteLine("Hear me roar!");
        }
        public double returnHealth()
        {
            return this.Health;
        }

    }
}
