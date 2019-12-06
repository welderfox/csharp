using System;
using System.Collections.Generic;

namespace classes
{
  public class BankAccount
  {
    public BankAccount(string name, decimal initialBalance)
    {
      this.Proprietario = name;
      this.Numero = accountNumberSeed.ToString();
      accountNumberSeed++;

      MakeDeposit(initialBalance, DateTime.Now, "Deposito inicial");
    }
    private List<Transaction> allTransactions = new List<Transaction>();
    private static int accountNumberSeed = 1234567890;
    public string Numero { get; set; }
    public string Proprietario { get; set; }
    public decimal Balanco
    {
      get
      {
        decimal balanco = 0;
        foreach (var item in allTransactions)
        {
          balanco += item.Amount;
        }
        return balanco;
      }
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Sua conta deve ser positiva!");
      }
      var deposit = new Transaction(amount, date, note);
      allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Conta, mesmo após o saque deve permanecer positiva!");
      }
      if (Balanco - amount < 0)
      {
        throw new InvalidOperationException("Saldo insuficiente!");
      }
      var withdrawal = new Transaction(-amount, date, note);
      allTransactions.Add(withdrawal);
    }
    public string GetAccountHistory()
    {
      var report = new System.Text.StringBuilder();
      report.AppendLine("Date\tAmount\tNote");
      foreach (var item in allTransactions)
      {
        report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
      }
      return report.ToString();
    }

    //Transaction teste; injecão de dependencia
  }
}