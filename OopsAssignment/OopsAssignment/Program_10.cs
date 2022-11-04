using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    //Created demo for default and parameterized constructor
    class User
    {
        public int id;
        public string name;
        public string location;
        public User()
        {
            Console.WriteLine("DEFAULT CONSTRUCTOR CALLED...");  // Default Constructor
        }
        public User(int id, string name, string location)
        {
            this.id = id;
            this.name = name;
            this.location = location;
            Console.WriteLine("PARAMETERIZED CONSTRUCTOR CALLED.."); // Parameterized Constructor
        }
        public void showdata()
        {
            Console.WriteLine("User ID: " + id);
            Console.WriteLine("User Name: " + name);
            Console.WriteLine("User Location: " + location);
        }
    }
}
