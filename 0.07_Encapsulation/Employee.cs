using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Encapsulation
{
    class Employee
    {
        private int _employeeId;

        public int EmployeeId
        {
            get { return _employeeId; }
           
            set
            {
                if(value <=0)
                {
                    throw new Exception("dude it cant be less than 1");
                }
                _employeeId = value;
            }
        }

        private int _yearsExperience;

        public int YearsExperience
        {
            get
            { return _yearsExperience; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("dude it cant be less than 1");
                }
                _yearsExperience = value;
            }
        }

    }
}
