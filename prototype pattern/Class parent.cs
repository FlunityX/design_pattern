using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_pattern
{
    public abstract class Class_parent
    {
        public abstract Class_parent Clone();
    }
    public class Class_clone :Class_parent 
    {
        private int id;

        public Class_clone(int id)
        {
            this.id = id;
        }
        public void Display()
        {
            Console.WriteLine("ID: " + id);
        }
        public override Class_parent Clone()
        {
        return new Class_clone(this.id);
        }
    }
}
