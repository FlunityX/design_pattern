namespace factory_method
{
    public interface IAnimal
    {
        public void Sound();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            basicFactory chonloai = new basicFactory();
            IAnimal cat = chonloai.CreateAnimal("Cat");
            cat.Sound(); 
            IAnimal chicken = chonloai.CreateAnimal("Chicken");
            chicken.Sound(); 
            randomFatory animalFactory = new randomFatory();
            IAnimal loai2 = randomFatory.CreateRandomAnimal();
            loai2.Sound();
            Console.ReadLine();

        }
    }
}
