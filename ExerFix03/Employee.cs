using System;
using System.Collections.Generic;
using System.Text;

namespace ExerFix03
{
    class Employee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double pct)
        {
            pct = (pct / 100)+1;
            Salary = Salary * pct;
        }
    }
}
