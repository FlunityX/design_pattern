namespace singleton.bài_tập_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           quanlylogn us1 = quanlylogn.GetIntance();
            us1.dangnhap("manh ", "122001472");
            Console.ReadLine();
        }
    }
}