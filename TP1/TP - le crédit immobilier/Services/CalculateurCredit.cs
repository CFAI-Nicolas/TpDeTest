using System;
using TP_Le_Credit_Immobilier.Models;
using TP_Le_Credit_Immobilier.Services.Interfaces;

namespace TP_Le_Credit_Immobilier.Services
{
    public class CalculateurCredit : ICalculateurCredit
    {
        public decimal CalculerMensualite(Credit credit)
        {
            decimal tauxMensuel = credit.TauxAnnuel / 12;
            return Math.Round(credit.Capital * tauxMensuel /
                   (1 - (decimal)Math.Pow(1 + (double)tauxMensuel, -credit.DureeEnMois)), 2);
        }

        public decimal CalculerAssuranceMensuelle(Credit credit) =>
            Math.Round(credit.Capital * credit.TauxAssurance / 12, 2);

        public decimal CalculerInteretsTotaux(Credit credit) =>
            Math.Round((CalculerMensualite(credit) * credit.DureeEnMois) - credit.Capital, 2);

        public decimal CalculerTotalAssurance(Credit credit) =>
            Math.Round(credit.Capital * credit.TauxAssurance / 12 * credit.DureeEnMois, 2);


        public decimal CapitalRembourseAuBoutDeXAnnees(Credit credit, int annees)
        {
            decimal tauxMensuel = credit.TauxAnnuel / 12;
            decimal mensualite = CalculerMensualite(credit);
            decimal capitalRestant = credit.Capital;

            for (int i = 0; i < annees * 12; i++)
            {
                decimal interets = Math.Round(capitalRestant * tauxMensuel, 2);
                decimal amortissement = Math.Round(mensualite - interets, 2);
                capitalRestant -= amortissement;
            }

            return Math.Round(credit.Capital - capitalRestant, 2);
        }

    }
}
