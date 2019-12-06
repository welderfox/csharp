using System;
using System.Collections.Generic;

namespace list
{
  class Program
  {
    static void Main(string[] args)
    {
      var fibonacciNumbers = new List<int> { 1, 2 };

      //   while (fibonacciNumbers.Count <= 20)
      //   {
      //   }
      for (var i = 0; fibonacciNumbers.Count <= 20; i++)
      {
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
        fibonacciNumbers.Add(previous + previous2);
        Console.WriteLine(fibonacciNumbers[i]);
      }

      //   foreach (var item in fibonacciNumbers)
      //   {
      //     Console.WriteLine(item);
      //   }
    }

    static void WorkingWithStrings()
    {
      var names = new List<string> { "Alissu", "Ana", "Felipe" };
      names.Add("Alef");
      names.Add("Erilson");
      names.Remove("Ana");
      names.Sort();
      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }

      var index = names.IndexOf("Felipe");
      if (index == -1)
      {
        Console.WriteLine($"Quando o indexOf não acha o valor na lista ele retorna {index}");
      }
      else
      {
        Console.WriteLine($"O nome {names[index]} está no indice {index}");
      }
      index = names.IndexOf("Not Found");
      if (index == -1)
      {
        Console.WriteLine($"Quando o indexOf não acha o valor na lista ele retorna {index}");
      }
      else
      {
        Console.WriteLine($"O nome {names[index]} está no indice {index}");
      }
    }
  }
}
