using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Interfaces_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer goodInstance = new Customer(new GoodCustomer());
            goodInstance.SendMessageToSpecificCustomerType();
            Customer badInstance = new Customer(new BadCustomer());
            badInstance.SendMessageToSpecificCustomerType();

        }
    }
}
