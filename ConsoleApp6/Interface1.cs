using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    interface IQuittable// Interface.
    {
        void employeestate();
    }
}

class Employee : IQuittable //Polymorphism to create the Iquittable object.
{
    public void employeestate()//Calling the method.
    {
        Console.WriteLine("The Employee has left");//Output of the method.
        Console.ReadLine();
    }
}
       