using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Duck
    {
        public void quack()
        {
            Console.WriteLine("quack");
        }

        public void Swim()
        {
            Console.WriteLine("swim");
        }

        public void Display()
        {
            Console.WriteLine("show duck");
        }

        public void Fly()
        {
            Console.WriteLine("I am flying");
        }
    }
}
