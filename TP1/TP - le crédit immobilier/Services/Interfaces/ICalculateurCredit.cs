using TP_Le_Credit_Immobilier.Models;

namespace TP_Le_Credit_Immobilier.Services.Interfaces
{
    public interface ICalculateurCredit
    {
        decimal CalculerMensualite(Credit credit);
        decimal CalculerAssuranceMensuelle(Credit credit);
        decimal CalculerInteretsTotaux(Credit credit);
        decimal CalculerTotalAssurance(Credit credit);
        decimal CapitalRembourseAuBoutDeXAnnees(Credit credit, int annees);
    }
}
