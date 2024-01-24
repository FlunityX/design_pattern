using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subclass_Sandbox_Pattern
{
    internal class testpatten
    {
        private void privatemessage()
        {
            Console.WriteLine("phuong thuc private dc goi");
        }
        protected void protectedmessage()
        {
            Console.WriteLine("phuong thuc protected dc goi");
        }
        public virtual void publicmessage()
        {
            Console.WriteLine("phuong thuc public dc goi");
            privatemessage();
            protectedmessage();
        }
    }
}
