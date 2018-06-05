using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Inheritance
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public int NumberOfLegs { get; set; }
        public int weight { get; set; }
        public bool HasWings { get; set; }
    }
}
