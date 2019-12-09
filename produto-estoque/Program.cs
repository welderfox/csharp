using System;
using System.Globalization;

namespace produto_estoque
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Entre os dados do produto: ");
      Console.Write("Nome: ");
      string nome = Console.ReadLine();

      Console.Write("Preço: ");
      double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Produto p = new Produto(nome, preco);
      Console.Write("Qunatidade no estoque: ");
      p.Quantidade = int.Parse(Console.ReadLine());

      Console.WriteLine($"Dados do produto: " + p);

      Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
      int qte = int.Parse(Console.ReadLine());

      p.AdicionarProdutos(qte);

      Console.WriteLine($"Dados atualizados: {p}");

      Console.Write("Digite o número de produtos a ser removido no estoque: ");
      qte = int.Parse(Console.ReadLine());

      p.RemoverProdutos(qte);

      Console.WriteLine($"Dados atualizados: {p}");
    }
  }
}
