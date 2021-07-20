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
            int workingdayspermonth = 20;
            int wagespermonth = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            switch (empcheck)
            {
                case 0:
                    Console.WriteLine("Employee is present");
                    dailywage = fulldayhour * wageperhour;
                    wagespermonth = dailywage * workingdayspermonth;
                    Console.WriteLine("dailywage is"+dailywage);
                    Console.WriteLine("wages per month is" + wagespermonth);
                    break;
                case 1:
                    Console.WriteLine("Employee is present and doing part time");
                    dailywage = parttimehour * wageperhour;
                    wagespermonth = dailywage * workingdayspermonth;
                    Console.WriteLine("dailywage is" + dailywage);
                    Console.WriteLine("wages per month is" + wagespermonth);
                    break;
            }
        }
    }
}
