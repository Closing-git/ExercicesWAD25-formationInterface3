using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    public class Joueur
    {
        public string Nom { get; set; }
        public Pions Pion { get; set; }
        public int Position { get; private set; }
        public int Solde { get; private set; }

        private List<CasePropriete> _proprietes;

        public CasePropriete[] Proprietes
        {
            get
            {
                return _proprietes.ToArray();
            }
        }


        public Joueur(string Nom, Pions Pion)
        {
            this.Nom = Nom;
            this.Pion = Pion;
            this.Solde = 1500;
            this._proprietes = new List<CasePropriete>();
        }


        public void EtrePaye(int montant)
        {
            if (montant > 0)
            {
                this.Solde += montant;
            }
        }

        public void Payer(int montant)
        {
            if (montant > 0)
            {
                if (this.Solde >= montant)
                {
                    this.Solde -= montant;
                }
            }
        }

        public void AjouterPropriete(CasePropriete propriete)
        {
            if (propriete.Proprietaire == this && !_proprietes.Contains(propriete))
            {
                this._proprietes.Add(propriete);
            }
        }



        public bool Avancer()
        {
            uint[] result = De.Lancer(2);
            for (int i = 0; i < 2; i++)
            {
                Position += (int)result[i];
                Console.WriteLine($"Dés {i + 1} : {result[i]}");
            }



            return (result[0] == result[1]);


        }
    }
}
