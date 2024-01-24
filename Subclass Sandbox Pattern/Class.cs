using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subclass_Sandbox_Pattern
{
    internal class ts:testpatten
    {
        public override void publicmessage()
        {
            base.publicmessage();
            Console.WriteLine("day la phuong thuc cua lop con");
        }
    }
}
