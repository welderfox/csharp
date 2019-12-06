using System;

namespace classes
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount("Alissu", 1000);
      var account2 = new BankAccount("Lucas", 1000);
      var account3 = new BankAccount("Jailson Mendes", 1000);
      account3.MakeWithdrawal(500, DateTime.Now, "Exames Médicos.");
      account3.MakeWithdrawal(300, DateTime.Now, "Prova de Legislação!");
      account3.MakeWithdrawal(50, DateTime.Now, "Cinema.");
      account3.MakeDeposit(16853, DateTime.Now, "Pl");
      Console.WriteLine(account3.GetAccountHistory());
    }
  }
}
