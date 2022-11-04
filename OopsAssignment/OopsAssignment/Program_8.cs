using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    //Create two interface and illustrate how to use multiple inheritance in C#
    class Baseclass
    {
        public void show1()
        {
            Console.WriteLine("This is BaseClass...");
        }
    }
    class Derivedclass : Baseclass
    {
        public void show2()
        {
            Console.WriteLine("This is DerivedClass...");
        }
    }
    class Childclass : Derivedclass
    {
        public void show3()
        {
            Console.WriteLine("This is ChildClass...");
        }
    }
}
