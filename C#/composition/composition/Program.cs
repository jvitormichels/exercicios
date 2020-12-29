using composition.Entities;
using composition.Entities.Enums;
using System;

namespace composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("\nEnter worker's data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior, MidLevel, Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);

            char repeat;
            do
            {
                Console.Clear();
                Console.WriteLine("Do you want to: \n" +
                    "1. Show worker's data\n" +
                    "2. List the worker's contracts\n" +
                    "3. Add a contract\n" +
                    "4. Remove a contract\n" +
                    "5. Calculate income\n");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine(worker);
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    worker.ShowContracts();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine($"Enter contract's data:");
                    Console.Write("Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Value: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Duration (hours): ");
                    int hours = int.Parse(Console.ReadLine());

                    HourContract contract = new HourContract(date, valuePerHour, hours);
                    worker.AddContract(contract);

                }
                else if (choice == 4)
                {
                    Console.Clear();
                    Console.WriteLine($"Enter contract's data:");
                    Console.Write("Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Value: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Duration (hours): ");
                    int hours = int.Parse(Console.ReadLine());
                    HourContract contract = new HourContract(date, valuePerHour, hours);

                    Console.WriteLine("\nAre you sure you want to remove this contract? (Y/N)");
                    char confirm = char.Parse(Console.ReadLine());
                    if (confirm == 'Y')
                    {
                        worker.RemoveContract(contract);
                        Console.WriteLine("The contract was removed!");
                    }
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    Console.Write("Enter month and year to calculate income (MM/YYYY): ");
                    string monthAndYear = Console.ReadLine();
                    int month = int.Parse(monthAndYear.Substring(0, 2));
                    int year = int.Parse(monthAndYear.Substring(3));

                    Console.WriteLine($"Name: {worker.Name}" +
                        $"\nDepartment: {worker.Department.Name}" +
                        $"\nIncome for {monthAndYear}: R${worker.Income(year, month)}");
                }

                Console.WriteLine("\n\nDo you want to make something more? (Y/N)");
                repeat = char.Parse(Console.ReadLine());

            } while (repeat != 'N'  &&  repeat != 'n');


            /*Console.Write("\nHow many contracts to this worker? ");
            int numberOfContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfContracts; i++)
            {
                Console.Clear();
                Console.WriteLine($"Enter {i}# contract's data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }*/
        }
    }
}
