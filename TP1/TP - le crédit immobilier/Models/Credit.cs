namespace TP_Le_Credit_Immobilier.Models
{
    public class Credit
    {
        public readonly decimal Capital;
        public readonly int DureeEnMois;
        public readonly decimal TauxAnnuel;
        public readonly decimal TauxAssurance;

        public Credit(decimal capital, int dureeAnnees, decimal tauxAnnuel, ProfilEmprunteur profil)
        {
            Capital = capital;
            DureeEnMois = dureeAnnees * 12;
            TauxAnnuel = tauxAnnuel / 100m;
            TauxAssurance = profil.CalculerTauxAssurance() / 100m;
        }
    }
}
