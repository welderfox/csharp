public abstract class Funcionario
{
  public string Nome;
  public decimal Salario;

  public abstract void Reajustar();
}

public class Programador : Funcionario
{
  public override void Reajustar()
  {
    Salario += 6000;
  }
}

public class Designer : Funcionario
{
  public override void Reajustar()
  {
    Salario += 500;
  }
}

public class Poligonos
{

  public virtual double Area(double x, double y)
  {
    return x * y;
  }
}

public class Triangulo : Poligonos
{
  public override double Area(double b, double h)
  {
    return (b * h) / 2;
  }
}
