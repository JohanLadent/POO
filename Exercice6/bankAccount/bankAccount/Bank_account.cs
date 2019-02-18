using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    public class Bank_account
    {
        public string holder;
        public string currency;
        public double balance;
        /// <summary>
        /// Le construceur nous permet d'hydrater l'objet lors de sa création
        /// </summary>
        /// <param name="_holder">Nom du propiétaire du compte</param>
        /// <param name="_currency">Devise du compte</param>
        /// <param name="_balance">Solde actuel du compte</param>

        public Bank_account(string _holder, string _currency, double _balance)
        {
            holder = _holder;
            currency = _currency;
            balance = _balance;
        }
        /// <summary>
        /// Cette méthode permet de créditer le compte bancaire
        /// </summary>
        /// <param name="amount">Montant en euros ç créditer sur le compte</param>
        public void credit(double amount)
        {
            // this evite les confusions lors du choix des var
            this.balance = this.balance + amount;
        }
        public void debit(double amount)
        {
            // this evite les confusions lors du choix des var
            this.balance = this.balance - amount;
        }


    }
}
