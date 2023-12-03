using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.bài_tập_1
{
    internal class quanlylogn
    {
        private static quanlylogn instance;
        
        private user us1;
        private quanlylogn()
        {
        }
        public static quanlylogn GetIntance()
        {
           {
                if (instance == null)
                {
                    instance = new quanlylogn();
                }
                 return instance; 
            }
        }
        public void dangnhap(string username ,string password)
        {
              Console.WriteLine(username);
            Console.WriteLine(password);
        }
    }
}
