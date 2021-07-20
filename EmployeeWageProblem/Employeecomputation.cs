using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class Employeecomputation
    {
        public void attendance()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == 1)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    }
}
