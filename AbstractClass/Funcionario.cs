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
    Salario += 1000;
  }
}

public class Designer : Funcionario
{
  public override void Reajustar()
  {
    Salario += 500;
  }
}