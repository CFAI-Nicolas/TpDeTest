using TP_Le_Credit_Immobilier.Models;
using TP_Le_Credit_Immobilier.Services;
using TP_Le_Credit_Immobilier.Services.Interfaces;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("💰 Simulation Crédit Immobilier 💰");

        var saisieService = new SaisieService();
        var gestionnaireTaux = new GestionnaireTauxService();
        var calculateur = new CalculateurCredit();
        var creditService = new CreditService(calculateur);

        decimal capital = saisieService.DemanderValeur("Capital emprunté (€) : ", 50000);
        int duree = saisieService.DemanderDuree();
        int choixTaux = saisieService.DemanderChoixTaux();
        decimal tauxAnnuel = gestionnaireTaux.ObtenirTauxNominal(duree, choixTaux);

        ProfilEmprunteur profil = saisieService.DemanderProfilEmprunteur();

        var credit = new Credit(capital, duree, tauxAnnuel, profil);
        creditService.AfficherDetailsCredit(credit);
    }
}
