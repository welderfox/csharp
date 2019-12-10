using System;
using System.Globalization;
using System.Collections.Generic;

namespace produto_estoque
{
  class Produto
  {
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
      Nome = nome;
      Preco = preco;
      Quantidade = quantidade;
    }

    public double ValorTotalEmEstoque()
    {
      return Preco * Quantidade;
    }

    public void AdicionarProdutos(int qte)
    {
      Quantidade += qte;
    }

    public void RemoverProdutos(int qte)
    {
      Quantidade -= qte;
    }

    public override string ToString()
    {
      return $"{Nome} , $ {Preco.ToString("F2", CultureInfo.InvariantCulture)} , {Quantidade} unidades, Total: $ " +
      $"{ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}