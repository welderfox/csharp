using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class Pensionato
  {
    public static void Pricipal()
    {
      AlunoHospede[] Pensionato = new AlunoHospede[10];
      Console.WriteLine("How many rooms will be rented? ");
      int n, room;
      string name, email;
      n = int.Parse(Console.ReadLine());
      if (n > 10 || n < 1)
      {
        Console.WriteLine("Error");
        return;
      }

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"Rent #{i + 1}");
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
        Console.Write("Room: ");
        room = int.Parse(Console.ReadLine());
        if (room > 10 || room < 1)
        {
          Console.WriteLine("Error");
          return;
        }
        Pensionato[room - 1] = new AlunoHospede { Name = name, Email = email, Room = room };
      }
      Console.WriteLine("Busy rooms:");
      foreach (var hospede in Pensionato)
      {
        if (hospede != null)
        {
          Console.WriteLine($"{hospede.Room}: {hospede.Name}, {hospede.Email}");
        }
      }
    }

  }
}