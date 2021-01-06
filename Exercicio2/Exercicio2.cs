using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio2
{
   class Exercicio2
   {
      static void Main(string[] args)
      {
         //Listas
         List<Employee> employee = new List<Employee>();
         Console.Write("How many employees will be registered? ");
         int n = int.Parse(Console.ReadLine());

         for (int i = 1; i <= n; i++)
         {
            Console.WriteLine($"Emplyoee #{i}:");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.Add(new Employee(id, name, salary));
            Console.WriteLine();
         }

         Console.Write("Enter the employee id that will have salary increase : ");
         int searchId = int.Parse(Console.ReadLine());
         Employee emp = employee.Find(x => x.Id == searchId);
         if (emp != null)
         {
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.IncreaseSalary(percentage);
         }
         else
         {
            Console.WriteLine("This id does not exist!");
         }

         Console.WriteLine();
         Console.WriteLine("Updated list of employees:");
         foreach (Employee obj in employee)
         {
            Console.WriteLine(obj);
         }
      }
   }
}