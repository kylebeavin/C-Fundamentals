using _0._09_Interfaces_Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Interfaces
{
    class Restaurant : IRateable, IFooable
    {
        public void Foo()
        {
            throw new NotImplementedException();
        }

        public void PrintRestaurantName()
        {
            throw new NotImplementedException();
        }

        public void PrintRestaurantRating()
        {
            throw new NotImplementedException();
        }

        public void PrintRestaurantType()
        {
            throw new NotImplementedException();
        }
    }
}
