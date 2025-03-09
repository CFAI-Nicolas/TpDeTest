namespace TP_Le_Credit_Immobilier.Models
{
    public class ProfilEmprunteur
    {
        public readonly bool EstSportif;
        public readonly bool EstFumeur;
        public readonly bool ADesTroublesCardiaques;
        public readonly bool EstIngenieurInformatique;
        public readonly bool EstPiloteDeChasse;

        private const decimal TauxBase = 0.30m;

        public ProfilEmprunteur(
            bool estSportif,
            bool estFumeur,
            bool aDesTroublesCardiaques,
            bool estIngenieurInformatique,
            bool estPiloteDeChasse)
        {
            EstSportif = estSportif;
            EstFumeur = estFumeur;
            ADesTroublesCardiaques = aDesTroublesCardiaques;
            EstIngenieurInformatique = estIngenieurInformatique;
            EstPiloteDeChasse = estPiloteDeChasse;
        }

        public decimal CalculerTauxAssurance()
        {
            decimal taux = TauxBase;
            if (EstSportif) taux -= 0.05m;
            if (EstFumeur) taux += 0.15m;
            if (ADesTroublesCardiaques) taux += 0.30m;
            if (EstIngenieurInformatique) taux -= 0.05m;
            if (EstPiloteDeChasse) taux += 0.15m;
            return taux;
        }
    }
}
