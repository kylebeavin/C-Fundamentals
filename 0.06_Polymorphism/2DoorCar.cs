﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Polymorphism
{
    public class _2DoorCar : Car
    {
        public override void makeAndModel()
        {
            Console.WriteLine("this two door car is a {0},{1}", this.Make, this.Model);
        }
    }
}
