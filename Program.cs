

using System;

namespace PaidToEmployee
{
    class Employee
    {
        public string _Name;
        public double _WagePeerHour;
        public double _Owed;

        public void SetName(string name)
        {
            _Name = name;  
        }

        public string GetName()
        {
            return _Name;
        }

        public void SetWage(double wage)  
        {
            _WagePeerHour = wage;
        }

        public void Work(double hours)
        {
            //To do
            //Update unpaid hours
            //Calculate money Owed.
            _Owed = hours * _WagePeerHour;          
        }

        public double Pay()
        {
            //To do
            // return moneyOwed and set unpaid hours and moneyOwed to zero    
            double variable = _Owed;
            _Owed = 0;
            return variable;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            
            Employee Emp1 = new Employee();
            Employee Emp2 = new Employee();

            Emp1.SetName("David");
            Emp1.SetWage(15);
            Emp2.SetName("Susan");
            Emp2.SetWage(30);

            //Before Working
            Console.WriteLine("Employee '{0}' is paid {1} before working...", Emp1.GetName(), Emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} before working...", Emp2.GetName(), Emp2.Pay());
            Console.WriteLine(" ");

            //After working
            Emp1.Work(5);
            Emp2.Work(8);
            Console.WriteLine("Employee '{0}' is paid {1} after working 1...", Emp1.GetName(), Emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} after working...", Emp2.GetName(), Emp2.Pay());
            Console.WriteLine(" ");

            //After working
            Emp1.Work(4);
            Emp2.Work(1);
            Console.WriteLine("Employee '{0}' is paid {1} after working 2...", Emp1.GetName(), Emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} after working...", Emp2.GetName(), Emp2.Pay());
            Console.WriteLine(" ");

            //Prove that the value due is reset to 0.
            Console.WriteLine("Employee '{0}' is paid {1} PRINT AGAIN...", Emp1.GetName(), Emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} PRINT AGAIN...", Emp2.GetName(), Emp2.Pay());
            Console.WriteLine(" ");

            //Prove that the value due is reset to 0.
            Console.WriteLine("Employee '{0}' is paid {1} PRINT AGAIN 2 ...", Emp1.GetName(), Emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} PRINT AGAIN 2...", Emp2.GetName(), Emp2.Pay());
            Console.WriteLine(" ");

            //After working
            Emp1.Work(7);
            Emp2.Work(10);
            Console.WriteLine("Employee '{0}' is paid {1} after working 3...", Emp1.GetName(), Emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} after working 3...", Emp2.GetName(), Emp2.Pay());
            Console.WriteLine(" ");

            //Prove that the value due is reset to 0.
            Console.WriteLine("Employee '{0}' is paid {1} PRINT AGAIN 3...", Emp1.GetName(), Emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} PRINT AGAIN 3...", Emp2.GetName(), Emp2.Pay());
            Console.WriteLine(" ");

            Console.ReadKey();

        }

    }

}




