using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    public class CasePropriete
    {
        public string Nom { get; private set; }
        public Couleurs Couleur {  get; private set; }
        public int Prix { get; private set; }
        public bool EstHypothequee { get; private set; }
        public Joueur? Proprietaire { get; private set; }

        public CasePropriete(string nom, Couleurs couleur, int prix)
        {
            Nom = nom;
            Couleur = couleur;
            Prix = prix;
        }



        public void Acheter(Joueur acheteur)
        {
            if (acheteur.Solde >= this.Prix)
            {
                acheteur.Payer(this.Prix);
                this.Proprietaire = acheteur;
                acheteur.AjouterPropriete(this);

            }
        }
    }
}
