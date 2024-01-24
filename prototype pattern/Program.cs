namespace prototype_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Class_clone sp = new Class_clone(2);
            Class_clone Clone = (Class_clone)sp.Clone();
            sp.Display();
        }
    }
}
