namespace Execs
{
  class Product
  {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Product(string name, double price)
    {
      Nome = name;
      Preco = price;
    }
    public double ValorTotalEmEstoque()
    {
      return Preco * Quantidade;
    }

  }
}