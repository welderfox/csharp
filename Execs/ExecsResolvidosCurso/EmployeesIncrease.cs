using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class EmployeesIncrease
  {
    public static void Principal()
    {
      Console.Write("How many employees will be registered? ");
      int qnt = int.Parse(Console.ReadLine());

      List<Employees> Funcionarios = new List<Employees>();

      for (var i = 0; i < qnt; i++)
      {
        Console.WriteLine($"Employee #{i + 1}:");
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Funcionarios.Add(new Employees(id, name, salary));
        Console.WriteLine();
      }

      Console.Write("Enter the employee id that will have salary increase: ");
      int searchId = int.Parse(Console.ReadLine());

      Employees founded = Funcionarios.Find(x => x.Id == searchId);
      if (founded != null)
      {
        Console.Write("Enter the percentage: ");
        double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        founded.Increase(percent);
      }
      else
      {
        Console.WriteLine("This id does not exist!");
      }

      Console.WriteLine();
      Console.WriteLine("Updated list of employees: ");
      foreach (Employees Funcionario in Funcionarios)
      {
        Console.WriteLine(Funcionario);
      }
    }
  }
}