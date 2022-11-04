using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    //Create two interface and illustrate how to use multiple inheritance in C#
    interface IcalculateAdd
    {
        int Addition(int num1, int num2);
    }
    interface IcalculateSubtract
    {
        int Subtraction(int num1, int num2);
    }
    class Calculation : IcalculateAdd, IcalculateSubtract
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
