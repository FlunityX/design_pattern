using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    internal class nhamaykem
    {
        // Createsanphamkem là 1  factory method
        public Isanphamkem Createsanphamkem(string loaikem)
        {
            switch (loaikem.ToLower()) {
                case "kem dau":
                    return new kemdau();
                case "kem vani":
                    return new kemvani();
                case "kem dua hau":
                    return new kemduahau();
                default:
                    return null;

            }
        }
    }
}
