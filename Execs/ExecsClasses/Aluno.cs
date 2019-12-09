using System.Globalization;

namespace Execs
{
  class Aluno : Pessoas
  {
    public double nota1;
    public double nota2;
    public double nota3;

    public double notaFinal;

    public string VerificaSituacao()
    {
      notaFinal = nota1 + nota2 + nota3;
      if (notaFinal >= 60)
      {
        return $"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}\nAPROVADO";
      }
      else
      {
        var dif = 60 - notaFinal;
        return $"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}\nREPROVADO\nFALTARAM "
        + $"{dif.ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
      }
    }

    public override string ToString()
    {
      return VerificaSituacao();
    }
  }
}