using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    public class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
