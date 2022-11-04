using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    //Create Interface for Fruits and implement method in different fruits. Then print name and colour of that fruits.
    interface IFruit1
    {
        void display(string name, string color);
    }
    interface IFruit2
    {
        void display1(string name, string color);
    }
    interface IFruit3
    {
        void display2(string name, string color);
    }
    interface IFruit4
    {
        void display3(string name, string color);
    }
    interface IFruit5
    {
        void display4(string name, string color);
    }
    class Fruit : IFruit1, IFruit2, IFruit3, IFruit4, IFruit5
    {
        public void display(string name, string color)
        {
            Console.WriteLine("--Fruit 1--");
            Console.WriteLine("Name: " + name + Environment.NewLine + " Color: " + color);
        }
        public void display1(string name, string color)
        {
            Console.WriteLine("--Fruit 2--");
            Console.WriteLine("Name: " + name + Environment.NewLine + " Color: " + color);
        }
        public void display2(string name, string color)
        {
            Console.WriteLine("--Fruit 3--");
            Console.WriteLine("Name: " + name + Environment.NewLine + " Color: " + color);
        }
        public void display3(string name, string color)
        {
            Console.WriteLine("--Fruit 4--");
            Console.WriteLine("Name: " + name + Environment.NewLine + " Color: " + color);
        }
        public void display4(string name, string color)
        {
            Console.WriteLine("--Fruit 5--");
            Console.WriteLine("Name: " + name + Environment.NewLine + " Color: " + color);
        }
    }
}
