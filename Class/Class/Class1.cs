using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Method1
    {
        // Void method that divides number by 2 (cutting it in half)
        public void Half(ref int number)
        {
            number /= 2;
        }
        public void Half(ref double number)
        {
            number /= 2;
        }
    }
}
