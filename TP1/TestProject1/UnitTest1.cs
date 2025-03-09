using System;
using TP_Le_Credit_Immobilier.Services.Interfaces;
using TP_Le_Credit_Immobilier.Models;
using TP_Le_Credit_Immobilier.Services;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly ICalculateurCredit _calculateur = new CalculateurCredit();

        [Fact]
        public void Question1()
        {
            var profil = new ProfilEmprunteur(false, true, true, true, false);
            var credit = new Credit(175000m, 25, 1.27m, profil);

            decimal mensualite = _calculateur.CalculerMensualite(credit);

            Assert.InRange(mensualite, 650m, 750m);
        }

        [Fact]
        public void Question2()
        {
            var profil = new ProfilEmprunteur(false, true, true, true, false);
            var credit = new Credit(175000m, 25, 1.27m, profil);
            decimal assurance = _calculateur.CalculerAssuranceMensuelle(credit);

            Assert.Equal(102.08m, assurance);
        }

        [Fact]
        public void Question3()
        {
            var profil = new ProfilEmprunteur(false, true, true, true, false);
            var credit = new Credit(175000m, 25, 1.27m, profil);
            decimal interetsTotaux = _calculateur.CalculerInteretsTotaux(credit);

            Assert.InRange(interetsTotaux, 28000m, 35000m);
        }

        [Fact]
        public void Question4()
        {
            var profil = new ProfilEmprunteur(false, true, true, true, false);
            var credit = new Credit(175000m, 25, 1.27m, profil);
            decimal assuranceTotale = _calculateur.CalculerTotalAssurance(credit);

            Assert.Equal(30625m, assuranceTotale);
        }

        [Fact]
        public void Question5()
        {
            var profil = new ProfilEmprunteur(false, true, true, true, false);
            var credit = new Credit(175000m, 25, 1.27m, profil);
            decimal capitalRembourse = _calculateur.CapitalRembourseAuBoutDeXAnnees(credit, 10);

            Assert.InRange(capitalRembourse, 55000m, 65000m);
        }

        [Fact]
        public void Question6()
        {
            var profil = new ProfilEmprunteur(true, false, false, false, true);
            var credit = new Credit(200000m, 15, 0.73m, profil);
            decimal mensualite = _calculateur.CalculerMensualite(credit);

            Assert.InRange(mensualite, 1150m, 1250m);
        }

        [Fact]
        public void Question7()
        {
            var profil = new ProfilEmprunteur(true, false, false, false, true);
            var credit = new Credit(200000m, 15, 0.73m, profil);
            decimal assurance = _calculateur.CalculerAssuranceMensuelle(credit);

            Assert.Equal(66.67m, assurance);
        }

        [Fact]
        public void Question8()
        {
            var profil = new ProfilEmprunteur(true, false, false, false, true);
            var credit = new Credit(200000m, 15, 0.73m, profil);
            decimal interetsTotaux = _calculateur.CalculerInteretsTotaux(credit);

            Assert.InRange(interetsTotaux, 11000m, 13000m);
        }

        [Fact]
        public void Question9()
        {
            var profil = new ProfilEmprunteur(true, false, false, false, true);
            var credit = new Credit(200000m, 15, 0.73m, profil);
            decimal assuranceTotale = _calculateur.CalculerTotalAssurance(credit);

            Assert.Equal(12000m, assuranceTotale);
        }

        [Fact]
        public void Question10()
        {
            var profil = new ProfilEmprunteur(true, false, false, false, true);
            var credit = new Credit(200000m, 15, 0.73m, profil);
            decimal capitalRembourse = _calculateur.CapitalRembourseAuBoutDeXAnnees(credit, 10);

            Assert.InRange(capitalRembourse, 125000m, 135000m);
        }
    }
}