using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    public class basicFactory {
        public IAnimal CreateAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Cat":
                    return new Cat();
                case "Chicken":
                    return new Chicken();
                default:
                    throw new ArgumentException("Invalid animal type.");
            }
        }
    }
    public class randomFatory
    {
        private static Random random = new Random();

        public static IAnimal CreateRandomAnimal()
        {
            int randomNumber = random.Next(0, 3);

            switch (randomNumber)
            {
                case 0:
                    return new Dog();
                case 1:
                    return new Cat();
                case 2:
                    return new Chicken();
                default:
                    throw new ArgumentException("Invalid animal type.");
            }
        }
    }
}
