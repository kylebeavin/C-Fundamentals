﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Interfaces_DependencyInjection
{
    class BadCustomer : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("you are a bad customer");
        }
    }
}
