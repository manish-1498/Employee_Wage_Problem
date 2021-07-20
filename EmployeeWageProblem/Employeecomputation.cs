using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class Employeecomputation
    {
        
        public void dailyemployeewage()
        {
            int wageperhour = 20;
            int fulldayhour = 8;
            int parttimehour = 4;
            int dailywage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            switch (empcheck)
            {
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is present");
                    dailywage = fulldayhour * wageperhour;
                    Console.WriteLine("dailywage is"+dailywage);
                    break;
                case 2:
                    Console.WriteLine("Employee is present and doing part time");
                    dailywage = parttimehour * wageperhour;
                    Console.WriteLine("dailywage is" + dailywage);
                    break;
            }
        }
    }
}
