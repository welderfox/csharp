using System;

namespace Polimorfismo
{
  public class Forma
  {
    public int x { get; private set; }
    public int y { get; private set; }
    public int height { get; set; }
    public int width { get; set; }

    public virtual void desenho()
    {
      Console.WriteLine("Faça um desenho usando a classe base!");
    }
  }

  public class Retangulo : Forma
  {
    public override void desenho()
    {
      Console.WriteLine("Desenhando um retangulo!");
      base.desenho();
    }
  }

  public class Circulo : Forma
  {
    public override void desenho()
    {
      Console.WriteLine("Desenhando um Circulo!");
      base.desenho();
    }
  }

  public class Triangulo : Forma
  {
    public override void desenho()
    {
      Console.WriteLine("Desenhando um triangulo!");
      base.desenho();
    }
  }
}