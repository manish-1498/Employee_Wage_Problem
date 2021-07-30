using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmployeeWageBuilder
    {
        public string company;
        public int wageperhour;
        public int workingdayspermonth;
        public int totalworkinghoursinamonth;
        public int emphours = 0;
        public int wagespermonth = 0;
        public int totalworkingdays = 0;
        public int employeehrinmonth = 0;

        public EmployeeWageBuilder(string companyname, int wageperhour, int workingdayspermonth, int totalworkinghoursinamonth)
        {
            this.company = companyname;
            this.wageperhour = wageperhour;
            this.workingdayspermonth = workingdayspermonth;
            this.totalworkinghoursinamonth = totalworkinghoursinamonth;
        }
        public void Employeewage()
        {
            while (employeehrinmonth<totalworkinghoursinamonth && totalworkingdays < workingdayspermonth)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 2);
                switch (empcheck)
                {
                    case 0:
                        emphours = 8;
                        break;
                    case 1:
                        emphours = 8;
                        break;
                }
                employeehrinmonth = employeehrinmonth + emphours;
            }
            wagespermonth = wageperhour * employeehrinmonth;
            Console.WriteLine("Total Employeewage of " + company + " is "+ wagespermonth);
        }
    }
}






