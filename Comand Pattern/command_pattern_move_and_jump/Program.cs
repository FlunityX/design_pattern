namespace command_pattern_move_and_jump
{
    public interface IPlayer
    {
        void Execute();
        void Undo();

    }
    // kiểm tra hành động

     class checkactive
    {
        private float tocdo ;
      
        
        public void sangtrai()
        {
            Console.WriteLine("nhân vật sang trái ");
        }
        public void sangphai()
        {
            Console.WriteLine("nhân vật sang phải ");
        }
        public void dungim()
        {
            Console.WriteLine("nhân vật dứng im");
        }
        public void nhay()
        {
            Console.WriteLine("nhân vật nhảy ");
        }

    } 
       class sangtrai : IPlayer
    {
        public checkactive a ;
        public sangtrai(checkactive a)
        {
            this.a = a;
        }
        public void Execute()
        {
            a.sangtrai();
        }
        public void Undo()
        {
            a.dungim();
        }
       
    }
    class sangphai : IPlayer
    {
        public checkactive a;
        public sangphai(checkactive a)
        {
            this.a = a;
        }
        public void Execute()
        {
            a.sangphai();
        }
        public void Undo()
        {
            a.dungim();
        }

    }
    class nhay : IPlayer
    {
        public checkactive a;
        public nhay(checkactive a)
        {
            this.a = a;
        }
        public void Execute()
        {
            a.nhay();
        }
        public void Undo()
        {
            a.dungim();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            checkactive a = new checkactive();
            IPlayer b = new sangtrai(a);
            IPlayer c = new sangphai(a);
            IPlayer d = new nhay(a);
            b.Execute();
            c.Execute();
            d.Execute();
            Console.ReadLine();
         }
    }
}
