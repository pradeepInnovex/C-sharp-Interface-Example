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
        Console.ReadLine();
        
        // This is Correct 
        // Go Ahead thank you..................
        
        
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.Paid();
            e1.Paid2();

            IEmployee el = new Employee();
            el.Paid();


            for (int i = 0; i < 10; i++)
            {
                el.Paid();
            }

            if (1 > 10)
            {

                Console.WriteLine("Hello");
            }

    // This is Workimg
        }
    }
}
