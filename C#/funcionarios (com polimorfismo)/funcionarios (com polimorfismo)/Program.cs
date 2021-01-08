using System;
using System.Globalization;
using System.Collections.Generic;
using funcionarios__com_polimorfismo_.Entities;

namespace funcionarios__com_polimorfismo_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced? (y/n) ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(outsourcedEmployee);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments:");

            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
