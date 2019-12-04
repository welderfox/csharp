using System;
using System.Globalization;

namespace Execs
{
  class Uri1049
  {

    public static void Especie()
    {
      string palavra1, palavra2, palavra3;
      palavra1 = Console.ReadLine();
      palavra2 = Console.ReadLine();
      palavra3 = Console.ReadLine();

      if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "carnivoro")
      {
        Console.WriteLine("aguia");
      }
      else if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "onivoro")
      {
        Console.WriteLine("pomba");
      }
      else if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "onivoro")
      {
        Console.WriteLine("homem");
      }
      else if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "herbivoro")
      {
        Console.WriteLine("vaca");
      }
      else if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "hematofago")
      {
        Console.WriteLine("pulga");
      }
      else if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "herbivoro")
      {
        Console.WriteLine("lagarta");
      }
      else if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "hematofago")
      {
        Console.WriteLine("sanguessuga");
      }
      else
      {
        Console.WriteLine("minhoca");
      }
    }
  }
}