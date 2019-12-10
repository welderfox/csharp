using System.Globalization;

namespace produto_estoque
{
  class Produto
  {
    private string _nome;
    public double Preco { get; private set; }
    public int Quantidade { get; private set; }

    public Produto()
    {
    }

    public Produto(string nome, double preco, int quantidade)
    {
      Nome = nome;
      Preco = preco;
      Quantidade = quantidade;
    }

    public Produto(string nome, double preco)
    {
      Nome = nome;
      Preco = preco;
      Quantidade = 0;
    }

    public string Nome
    {
      get { return _nome; }
      set
      {
        if (value != null && value.Length > 1)
        {
          _nome = value;
        }
      }
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