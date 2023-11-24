using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    public class Chicken : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("cuc tac");
        }
    }
}
