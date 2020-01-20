using System;
using System.Globalization;
using System.Collections.Generic;

namespace Execs
{
  class Program
  {
    public static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());

      double[,] matriz = new double[n, n];

      for (int i = 0; i < n; i++)
      {
        string[] valores = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++)
        {
          matriz[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);
        }
      }
      int indexRow = int.Parse(Console.ReadLine());

      int indexColumn = int.Parse(Console.ReadLine());

      //Soma dos positivos, e exponenciacao ao quadrado dos negativos.
      double soma = 0.0;
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (matriz[i, j] >= 0)
          {
            soma += matriz[i, j];
          }
          else
          {
            matriz[i, j] *= matriz[i, j];
          }
        }
      }

      //Mostrar linha determinada.
      double[] vetLinhaDeterinada = new double[n];
      for (int i = 0; i < n; i++)
      {
        vetLinhaDeterinada[i] = matriz[indexRow, i];
      }

      //Coluna desejada.
      double[] vetColunaDeterinada = new double[n];
      for (int i = 0; i < n; i++)
      {
        vetLinhaDeterinada[i] = matriz[i, indexColumn];
      }

      //Diagonal principal.
      double[] diagonal = new double[n];
      for (int i = 0; i < n; i++)
      {
        diagonal[i] = matriz[i, i];
      }

      Console.WriteLine($"SOMA DOS POSITIVOS: {soma.ToString("F1", CultureInfo.InvariantCulture)}");

      Console.Write("LINHA ESCOLHIDA: ");
      foreach (var item in vetLinhaDeterinada)
      {
        Console.Write(item.ToString("F1", CultureInfo.InvariantCulture));
      }
      Console.WriteLine();

      Console.Write("COLUNA ESCOLHIDA: ");
      foreach (var item in vetColunaDeterinada)
      {
        Console.Write(item.ToString("F1", CultureInfo.InvariantCulture));
      }
      Console.WriteLine();

      Console.Write("DIAGONAL PRINCIPAL: ");
      foreach (var item in diagonal)
      {
        Console.Write(item.ToString("F1", CultureInfo.InvariantCulture));
      }
      Console.WriteLine();

      Console.Write("MATRIZ ALTERADA: ");
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++)
        {
          Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
        Console.WriteLine();
      }
    }
  }
}