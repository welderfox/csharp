using System;
using System.Linq;

namespace Linq
{
  class Program
  {
    static void Main(string[] args)
    {
      // Doing a Data test linq
      // First step, doing a DataSource
      int[] numbers = new int[] { 2, 3, 4, 5 };

      // step 2, define the query
      var result = numbers.Where(n => n % 2 == 0).Select(x => x * 10);

      // third step, execute, the query
      foreach (int x in result)
      {
        Console.WriteLine(x);
      }
    }
  }
}
