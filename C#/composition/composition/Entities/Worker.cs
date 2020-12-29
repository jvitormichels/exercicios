﻿using System;
using System.Collections.Generic;
using composition.Entities.Enums;

namespace composition.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }


        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year  &&  contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

        public void ShowContracts()
        {
            foreach (HourContract contract in Contracts)
            {
                Console.Write(contract);
                Console.WriteLine("\n");
            }
        }

        public override string ToString()
        {
            return $"Worker's data:\n" +
                $"Name: {Name}\n" +
                $"Level: {Level}\n" +
                $"Base Salary: {BaseSalary}\n" +
                $"Department: {Department}";
        }
    }
}
