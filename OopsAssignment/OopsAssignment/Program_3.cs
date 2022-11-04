using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    
        //Print different vehicle details using Abstraction
        abstract class VehicleInfo
        {
            // Abstract method (does not have a body)
            public abstract void VehicleDetails(string type, string color, int noofwheel, double milage);

        }
        // Derived class 
        class Program3 : VehicleInfo
        {
            public override void VehicleDetails(string type, string color, int noofwheel, double milage)
            {
                // The body of VehicleDetails() is provided here
                Console.WriteLine("Type : " + type);
                Console.WriteLine("Color : " + color);
                Console.WriteLine("Wheels : " + noofwheel);
                Console.WriteLine("Milage : " + milage);

            }
        }
}
