using System;
using System.Collections.Generic;
using System.Globalization;
namespace ExerFix03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list=new List<Employee>();

            Console.Write("How Many Employees Will Be Registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i= 0; i < n; i++)
            {
                Console.WriteLine("Employee #"+(i+1));
                Console.Write("ID: ");
                int id= int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Employee { Id = id, Name = name, Salary = salary });
            }

            Console.WriteLine();
            Console.Write("Enter the Employee ID that will have a salary increase: ");
            int idEmployee = int.Parse(Console.ReadLine());

            Employee eRaise= list.Find(x => x.Id == idEmployee);
            if (eRaise != null)
            {
                Console.Write("Enter the porcentaje: ");
                double pct = double.Parse(Console.ReadLine());
                eRaise.IncreaseSalary(pct);
            }
            else
            {
                Console.WriteLine("This Employee doesn't exists");
            }

            Console.WriteLine();
            Console.WriteLine("Updated List of Employees: ");
            foreach(Employee e in list)
            {
                Console.WriteLine($"{e.Id}, {e.Name}, {e.Salary.ToString("F2",CultureInfo.InvariantCulture)}");
            }

        }
    }
}
