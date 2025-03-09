using TP_Le_Credit_Immobilier.Models;
using TP_Le_Credit_Immobilier.Services.Interfaces;
using System;

namespace TP_Le_Credit_Immobilier.Services
{
    public class CreditService
    {
        private readonly ICalculateurCredit _calculateur;

        public CreditService(ICalculateurCredit calculateur)
        {
            _calculateur = calculateur;
        }

        public void AfficherDetailsCredit(Credit credit)
        {
            Console.WriteLine($"Mensualité : {_calculateur.CalculerMensualite(credit):F2}e");
            Console.WriteLine($"Assurance Mensuelle : {_calculateur.CalculerAssuranceMensuelle(credit):F2}e");
            Console.WriteLine($"Intérêts Totaux : {_calculateur.CalculerInteretsTotaux(credit):F2}e");
            Console.WriteLine($"Coût Total Assurance : {_calculateur.CalculerTotalAssurance(credit):F2}e€");
            Console.WriteLine($"Capital remboursé après 10 ans : {_calculateur.CapitalRembourseAuBoutDeXAnnees(credit, 10):F2}e");
        }
    }
}
