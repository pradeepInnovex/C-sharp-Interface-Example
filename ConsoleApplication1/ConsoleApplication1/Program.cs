using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    interface IEmployee
    {

        void Paid();
    }

    interface ITemporaryEmployee
    {
        void Paid2();
    }

    class Employee : IEmployee, ITemporaryEmployee
    {
        public void Paid()
        {
            Console.WriteLine("Payed..");
        }
        
        public void Paid2(){
        
        Console.WriteLine("I2 Payed...");
        
        
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.Paid();
            e1.Paid2();
        }
    }
}
