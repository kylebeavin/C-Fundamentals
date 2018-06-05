using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear winnie = new Bear();
            winnie.HasEatenHoneyToday = true;
            winnie.SalmonEatenToday = 3;
            winnie.Habitat = "hundred acre woods";
            winnie.HasWings = false;

            Kangaroo Joey = new Kangaroo();
            Joey.HasPouch = false;
            Joey.Habitat = "Australia";
            Joey.NumberOfLegs = 2;
            Joey.CanJump = true;
        }
    }
}
