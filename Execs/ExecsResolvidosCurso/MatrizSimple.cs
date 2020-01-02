using System;

namespace Execs
{
  class MatrizSimples
  {
    public static void Principal()
    {
      string[] vet = Console.ReadLine().Split(' ');

      int linha = int.Parse(vet[0]);
      int coluna = int.Parse(vet[1]);

      int[,] A = new int[linha, coluna];

      for (int i = 0; i < linha; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        for (int j = 0; j < coluna; j++)
        {
          A[i, j] = int.Parse(valores[j]);
        }
      }

      for (int i = 0; i < linha; i++)
      {
        for (int j = 0; j < coluna; j++)
        {
          Console.Write(A[i, j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}