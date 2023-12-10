
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhanvatgame
{
    // tạo 1 singleton về nhân vật có các hành động như jump , run , die , attack , walk , idle 
    public class nhanvatgame
    {
        private static nhanvatgame _instance;
        private nhanvatgame()
        {

        }
        public static nhanvatgame GetInstance()
        {
            if (_instance == null)
            {
                _instance = new nhanvatgame();
            }
            return _instance;
        }
        public void hanhdong (int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("jump");
                break;
                case 2:
                    Console.WriteLine("run");
                    break;
                case 3:
                    Console.WriteLine("die");
                    break;
                case 4:
                    Console.WriteLine("attack");
                    break;
                case 5:
                    Console.WriteLine("walk");
                    break;
                case 6:
                    Console.WriteLine("idle");
                    break;
            }
        }

        internal class Program
        {

            static void Main(string[] args)
            {
                nhanvatgame nv1 =nhanvatgame.GetInstance();
                nv1.hanhdong(1);
                nv1.hanhdong(2);
                nv1.hanhdong(3);
                nv1.hanhdong(4);
                nv1.hanhdong(5);
                nv1.hanhdong(6);
                Console.ReadLine();
            }
        }
    }
}

