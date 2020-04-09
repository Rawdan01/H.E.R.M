using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.E.R.M
{
     
    class Fournisseur : Personne
    {
        public string nom_societe;
        public Fournisseur(int Id, string Nom_complet, string nom_societe)
            : base(Id, Nom_complet)
        {
            this.nom_societe = nom_societe;
        }

    }
}
