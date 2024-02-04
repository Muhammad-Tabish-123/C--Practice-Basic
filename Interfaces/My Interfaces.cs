using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class  InterfaceManager : i1, i2
    {
        internal object i1;

        public int hide2()
        {
            return 2;
        }
        void i1.show()
        {
            Console.WriteLine("i1 show method");
        }

        void i2.show()
        {
            Console.WriteLine("i2 show method");
        }
    }
    
    
}
