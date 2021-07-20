using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class Employeecomputation
    {
        public void dailyemployeewage()
        {
            int Fulltime = 1;
            int wageperhour = 20;
            int fulldayhour = 8;
            int dailywage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == Fulltime)
            {
                dailywage = fulldayhour * wageperhour;
                Console.WriteLine("Emloyees fulltime daily wage is" + dailywage);
            }
            else
                Console.WriteLine("Employee works on parttime");
        }
    }
}
