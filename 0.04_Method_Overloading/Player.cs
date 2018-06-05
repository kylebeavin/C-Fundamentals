using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Method_Overloading
{
    class Player
    {
        public Player(string n, int a)
        {
            this.Name = n;
            this.attack = a;
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Attack()
    {
        Console.WriteLine("Player attacked for five points");
    }
        public void Attack(int customDmg)
        {
            Console.WriteLine("Player attacked for four points");
        }
    }
}
