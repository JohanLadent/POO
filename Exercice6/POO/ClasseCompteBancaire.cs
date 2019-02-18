using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class CompteBancaire
    {
        public string _titulaire;
        public double _solde;
        public string _devise;

        public void créditer(double _montant)
        {
            _solde += _montant;

        }
        public void débiter(double _montant)
        {
            _solde += _montant;
        }
    }
}
