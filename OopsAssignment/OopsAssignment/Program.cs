using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //1. MethodOverriding
                Shape square = new Square();
                Console.WriteLine("Area Of Square is : " + square.Area());
                Shape circle = new Circle();
                Console.WriteLine("Area Of Circle is : " + circle.Area());
                Shape rectangle = new Rectangle();
                Console.WriteLine("Area Of Rectangle is: " + rectangle.Area());

                //2. Static Polymorphism
                Program_2 program_2 = new Program_2();
                //Call print to print firstname and lastname
                program_2.Print("JYOTI", "MAHTO");
                //Call print to print city
                program_2.Print("Vadodara");
                //Call print to print mobilenumber and emailId
                program_2.Print(012345678, "jyoti@gmail.com");

                //3.
                Program3 myVehicle = new Program3(); // Create a Vehicle object
                myVehicle.VehicleDetails("Car", "Red", 4, 50);  // Call the abstract method

                //4.
                Fruit fruit = new Fruit();
                fruit.display("Apple", "Red");
                fruit.display1("Mango", "Yellow");
                fruit.display2("Papaya", "Orange");
                fruit.display3("Grapes", "Green");
                fruit.display4("Guava", "Green");

                //5. 
                Calculation calc = new Calculation();
                Console.WriteLine("Addition= " + calc.Addition(5, 9));
                Console.WriteLine("Subtraction= " + calc.Subtraction(10, 15));

                //6. 
                Bank bank = new Bank();
                bank.AccountNumber = 12345678;
                bank.Name = "Bank";
                bank.GetBalance();
                bank.Deposit();
                //bank.WithdrawAmount();

                //7.
                Peacock peacock = new Peacock();
                peacock.show1();
                peacock.show2();

                //8.
                Console.WriteLine("__MULTILEVEL INHERITANCE__");
                Childclass obj = new Childclass();
                obj.show1();
                obj.show2();
                obj.show3();

                //9.
                Console.WriteLine("--HierarchicalInheritance--");
                H_DerivedClass1 h_DerivedClass1 = new H_DerivedClass1();
                h_DerivedClass1.Show1();
                h_DerivedClass1.Show2();

                //10.
                User user = new User();
                user.id = 1;
                user.name = "Jyoti";
                user.location = "Vadodara";
                user.showdata();
                User user1 = new User(2, "Vaibhav", "Surat");
                user1.showdata();

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                //throw;
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
