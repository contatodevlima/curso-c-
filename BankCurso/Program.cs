using System;
using BankCurso.Entities;

namespace BankCurso
{
    class Program
    {
        static void Main(string[] args)
        {

            Account ac = new Account(100, "Rodrigo", 2000);
            SavingAccount sa = new SavingAccount(200, "Joao", 2000, 2.0);

            Console.WriteLine($"{ac.Balance}, {ac.Holder}");
            Console.WriteLine(" ");

            ac.WithDraw(100);
            sa.WithDraw(100);
            Console.WriteLine(ac.Balance + " " + ac.Holder);
            Console.WriteLine();
            Console.WriteLine($"{sa.Balance}, {sa.Holder}");
            Console.WriteLine();

        }
    }
}
