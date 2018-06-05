using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            _2DoorCar sport = new _2DoorCar();
            sport.Make = "mustang";
            sport.Model = "ford";
            sport.makeAndModel();
            _4DoorCar SUV = new _4DoorCar();
            SUV.Make = "cherokee";
            SUV.Model = "jeep";
            SUV.makeAndModel();
        //here we set up an array of objects
        Car[] cars = new Car[3];

        //the first one will use the default fields and default method
        cars[0] = new Car();
        cars[0].Make = "jalopy";
        cars[0].Model = "junker";

            //just changing the carModel field in the next 2
            cars[1] = new _2DoorCar();
            cars[1].Make = "ford";
            cars[1].Model = "focus";

            cars[2] = new _4DoorCar();
            cars[2].Make = "ford";
            cars[2].Model = "taurus";

            foreach(Car car in cars)
            {
                car.makeAndModel();
            }
            Console.ReadLine();
        }
    }
}
