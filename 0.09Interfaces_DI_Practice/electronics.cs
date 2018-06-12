using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09Interfaces_DI_Practice
{
    class electronics
    {

        private readonly IStartable _startable;

        public electronics(IStartable startable)
        {
            _startable = startable;
        }

        public void Start()
        {
            _startable.Start2();
        }
    }
}
