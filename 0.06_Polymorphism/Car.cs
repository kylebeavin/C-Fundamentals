using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Polymorphism
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    public virtual void makeAndModel()
    {
        Console.WriteLine("this car is a {0},{1}", this.Make, this.Model);
    }
    } 
}
