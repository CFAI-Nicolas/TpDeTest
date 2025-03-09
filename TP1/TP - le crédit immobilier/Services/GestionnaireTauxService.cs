using System.Collections.Generic;

namespace TP_Le_Credit_Immobilier.Services
{
    public class GestionnaireTauxService
    {
        private readonly Dictionary<int, decimal[]> _tauxNominalParDuree = new()
        {
            {7, new[] {0.62m, 0.43m, 0.35m}},
            {10, new[] {0.67m, 0.55m, 0.45m}},
            {15, new[] {0.85m, 0.73m, 0.58m}},
            {20, new[] {1.04m, 0.91m, 0.73m}},
            {25, new[] {1.27m, 1.15m, 0.89m}}
        };

        public decimal ObtenirTauxNominal(int dureeAnnees, int choixTaux) =>
            _tauxNominalParDuree[dureeAnnees][choixTaux - 1];
    }
}
