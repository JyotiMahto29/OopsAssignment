using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    class H_BaseClass
    {
        public void Show1()
        {
            Console.WriteLine("This is BaseClass...");
        }
    }
    class H_DerivedClass1 : H_BaseClass
    {
        public void Show2()
        {
            Console.WriteLine("This is DerivedClass 1...");
        }
    }
    class H_DerivedClass2 : H_DerivedClass1
    {
        public void Show3()
        {
            Console.WriteLine("This is DerivedClass 2...");
        }
    }
}
