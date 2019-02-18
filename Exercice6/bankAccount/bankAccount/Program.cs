using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création de l'objet avec le constructeur new
            Bank_account bank = new Bank_account("Johan", "euros", 2000);
            // On va hydrater l'objet dans les parenthèses
            Console.WriteLine("Bonjour monsieur " + bank.holder + ", le solde de votre compte est : " + bank.balance + " " + bank.currency);
            bank.credit(1000);
            Console.WriteLine("Le nouveau solde de votre compte est : " + bank.balance + " " + bank.currency);
            Console.ReadKey();
        }
    }
}
