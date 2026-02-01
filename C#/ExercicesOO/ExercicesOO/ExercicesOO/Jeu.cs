using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    public class Jeu
    {

        #region Variables
        private List<Joueur> _joueurs;
        private List<CasePropriete> _plateau;


        public Joueur[] Joueurs
        {
            get { return _joueurs.ToArray(); }

        }
        public CasePropriete[] Plateau
        {
            get { return _plateau.ToArray(); }

        }

        #endregion

        #region Constructeur
        public Jeu(CasePropriete[] casesInitiales)
        {
            _plateau = new List<CasePropriete>(casesInitiales);
            _joueurs = new List<Joueur>();
        }
        #endregion

        #region Méthodes


        public void AjouterJoueur(string nom, Pions pion)
        {

            {
                if (this[pion] != null)
                {
                    throw new InvalidOperationException($"Le pion {pion} est déjà pris");
                }
                    Joueur joueur = new Joueur(nom, pion);
                    _joueurs.Add(joueur);
            }

        } 
        #endregion

        #region Indexeurs

        public CasePropriete this[int numero]
        {

            get
            {
                if (numero < Plateau.Count() && numero >= 0)
                {

                    return Plateau[numero];
                }
                else
                {
                    throw new IndexOutOfRangeException("! Numéro de case invalide");
                }
            }
        }


        public Joueur this[Pions pion]
        {
            get
            {
                {
                    //Return j, si j.Pion == Pion à un moment (ici première occurence), sinon return une valeur par défaut
                    return _joueurs.FirstOrDefault(j => j.Pion == pion);

                }
            }

        }
        #endregion



    }
}
