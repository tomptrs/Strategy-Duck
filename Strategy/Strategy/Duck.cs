using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class Duck
    {
        public virtual void quack()
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

        public virtual void Fly()
        {
            Console.WriteLine("I am flying");
        }
    }
}
