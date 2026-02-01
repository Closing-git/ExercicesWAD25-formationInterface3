using Exercice1;

namespace ExercicesOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test Dé
            //De.ValeurMin = 8;



            //Joueur joueur1 = new Joueur("Nina", Pions.Brouette);


            //Random RNG = new Random();
            //Couleurs[] couleurs = Enum.GetValues<Couleurs>();

            //CasePropriete case1 = new CasePropriete("Gare St Lazare", Enum.GetValues<Couleurs>()[RNG.Next(couleurs.Length)], 500);


            //#region Test Achat
            //case1.Acheter(joueur1);

            //Console.WriteLine($"{joueur1.Nom} a {joueur1.Solde} crédits et possède {joueur1.Proprietes.Length} propriété. ");
            //foreach (CasePropriete caseP in joueur1.Proprietes)
            //{
            //    Console.WriteLine($"- {caseP.Nom} de couleur {caseP.Couleur}");
            //} 
            //#endregion



            //Console.WriteLine($"C'est à {joueur1.Nom} de jouer, tu es en position : {joueur1.Position}, appuie sur Q pour quitter.");
            //do
            //{

            //    Console.Clear();

            //    if (joueur1.Avancer())
            //    {
            //        Console.WriteLine($"Tu as lancé les dés et fais un double, tu es maintenant en position : tu es en position : {joueur1.Position}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Tu as lancé les dés, tu es maintenant en position : tu es en position : {joueur1.Position}");
            //    }

            //    Console.WriteLine($"C'est à {joueur1.Nom} de jouer, tu es en position : {joueur1.Position}, appuie sur Q pour quitter.");
            //}
            //while (
            //       Console.ReadKey().Key != ConsoleKey.Q);


            #endregion

            #region Démo Jeu

            CasePropriete[] plateau = new CasePropriete[]
            {
                new CasePropriete("départ", Couleurs.Neutre, 0),
                new CasePropriete("Avenue Louise", Couleurs.Bleu, 400),

            };

            Jeu monopoly = new Jeu(plateau);

            try
            {
                monopoly.AjouterJoueur("Monique", Pions.Cuirasse);
                Console.WriteLine("Monique ajoutée au jeu");

                //Test de l'erreur (doublon pion)
                monopoly.AjouterJoueur("Fred", Pions.Cuirasse);
                Console.WriteLine("Fred ajouté au jeu");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            #endregion
        }
    }


}
