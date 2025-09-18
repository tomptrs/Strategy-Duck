using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class RubberDuck:Duck
    {

        public override void quack()
        {
            Console.WriteLine("I cannot quack");
        }
        public override void Fly()
        {
            Console.WriteLine("I cannot fly");
        }
    }
}
