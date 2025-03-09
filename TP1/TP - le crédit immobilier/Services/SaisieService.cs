using System;
using System.Linq;
using TP_Le_Credit_Immobilier.Models;

namespace TP_Le_Credit_Immobilier.Services
{
    public class SaisieService
    {
        public decimal DemanderValeur(string message, decimal min, decimal max = decimal.MaxValue)
        {
            decimal valeur;
            do
            {
                Console.Write(message);
            } while (!decimal.TryParse(Console.ReadLine(), out valeur) || valeur < min || valeur > max);
            return valeur;
        }

        public int DemanderDuree()
        {
            int[] durees = { 7, 10, 15, 20, 25 };
            int duree;
            do
            {
                Console.Write("Durée (7, 10, 15, 20 ou 25 ans) : ");
            } while (!int.TryParse(Console.ReadLine(), out duree) || !durees.Contains(duree));
            return duree;
        }

        public int DemanderChoixTaux()
        {
            int choix;
            do
            {
                Console.Write("Choix du taux (1-Bon, 2-Très bon, 3-Excellent) : ");
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 3);
            return choix;
        }

        public bool DemanderOuiNon(string message)
        {
            string reponse;
            do
            {
                Console.Write($"{message} (o/n) : ");
                reponse = Console.ReadLine().Trim().ToLower();
            } while (reponse != "o" && reponse != "n");

            return reponse == "o";
        }

        public ProfilEmprunteur DemanderProfilEmprunteur()
        {
            return new ProfilEmprunteur(
                estSportif: DemanderOuiNon("Êtes-vous sportif ?"),
                estFumeur: DemanderOuiNon("Êtes-vous fumeur ?"),
                aDesTroublesCardiaques: DemanderOuiNon("Avez-vous des troubles cardiaques ?"),
                estIngenieurInformatique: DemanderOuiNon("Êtes-vous ingénieur en informatique ?"),
                estPiloteDeChasse: DemanderOuiNon("Êtes-vous pilote de chasse ?")
            );
        }

    }
}
