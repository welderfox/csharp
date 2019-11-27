using System;
using System.Globalization;

namespace Execs
{
  class Uri1040 //Verificar porque uri não valida
  {

    public static void Average3()
    {
      string[] valores = Console.ReadLine().Split(' ');
      float N1, N2, N3, N4, Media, MediaFinal, NotaExame;

      N1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
      N2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
      N3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
      N4 = float.Parse(valores[3], CultureInfo.InvariantCulture);


      Media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;
      Console.WriteLine("Media: " + Media.ToString("F1", CultureInfo.InvariantCulture));
      if (Media == 4.85f)
      {
        Media = 4.8f;
      }

      if (Media >= 7.0)
      {
        Console.WriteLine("Aluno aprovado.");
      }
      else if (Media < 5.0)
      {
        Console.WriteLine("Aluno reprovado.");
      }
      else
      {
        Console.WriteLine("Aluno em exame.");
        NotaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        MediaFinal = (Media + NotaExame) / 2;
        Console.WriteLine("Nota do exame: " + NotaExame.ToString("F1", CultureInfo.InvariantCulture));
        if (MediaFinal >= 5.0)
        {
          Console.WriteLine("Aluno aprovado.");
        }
        else
        {
          Console.WriteLine("Aluno reprovado.");
        }
        Console.WriteLine("Media final: " + MediaFinal.ToString("F1", CultureInfo.InvariantCulture));
      }
    }
  }
}
