using System.Globalization;

namespace Execs
{
  class ContaBancaria
  {
    public int Numero { get; private set; }
    public string Proprietario { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numero, string proprietario)
    {
      Numero = numero;
      Proprietario = proprietario;
      Saldo = 0;
    }

    public ContaBancaria(int numero, string proprietario, double DepositoIncial) : this(numero, proprietario)
    {
      Deposito(DepositoIncial);
    }

    public void Saque(double qnttSaque)
    {
      Saldo -= qnttSaque + 5;
    }

    public void Deposito(double qnttDeposito)
    {
      Saldo += qnttDeposito;
    }

    public override string ToString()
    {
      return $"Conta {Numero}, Titular: {Proprietario}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}