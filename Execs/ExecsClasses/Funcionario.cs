namespace Execs
{
  class Funcionario : Pessoas
  {

    public double SalarioBruto { get; set; }
    public double Imposto { get; set; }

    public double SalarioLiquido()
    {
      return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
      SalarioBruto = SalarioLiquido() + (SalarioBruto * porcentagem / 100);
    }
  }
}
