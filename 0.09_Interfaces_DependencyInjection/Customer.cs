using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Interfaces_DependencyInjection
{
    class Customer
    {
        private readonly IMessage _message;

        public Customer(IMessage message)
        {
            _message = message;
        }

        public void SendMessageToSpecificCustomerType()
        {
            _message.SendMessage();
        }

    }
}
