using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilder DMART = new EmployeeWageBuilder("DMART", 50, 40, 100);
            EmployeeWageBuilder INFOSYS = new EmployeeWageBuilder("INFOSYS", 70, 40, 120);
            DMART.Employeewage();
            INFOSYS.Employeewage();
        }
    }
}
