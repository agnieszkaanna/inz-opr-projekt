using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RCP
{
    public class SystemRCP
    {
        public SystemRCP()
        {
        }
        internal Form Start()
        {
            MainWindow logowanie = new MainWindow();
            logowanie.Tytul("Logowanie");
            logowanie.Podtytul("");
            //pola i przyciski
            return logowanie;
        }

        
        private abstract class Pracownik {
            int IDpracownika;
            string imie;
            string nazwisko;
            string pesel;
            Pracownik przelozony;
            Pracownik opiekun;
            enum Umowa { PRACAN, PRACAO, PROBA, KONTRAKT, ZLECENIE }
            Umowa typUmowy;
            float etat;
            enum TypHarmonogramu { JEDNAZMIANA, TRZYZMIANY, ELASTYCZNY }
            TypHarmonogramu typHarmPrac;
            int iloscUrlopu;
            int IDkarty;
            ManagerHarmonogramu manager;
            Harmonogram poprzedniHarmonogram;
            Harmonogram aktualnyHarmonogram;
            Harmonogram przyszłyHarmonogram;
            List<Wniosek> listaWyslanychWnioskow;

            public Pracownik() { }
            public void WeryfikacjaLogowania() { }
            public void RejestracjaWejscia() { }
            public void RejestracjaWyjscia() { }
            public void PodglądHarmonogramu() { }
            public void PodejrzyjWniosek() { }
            public void WyślijWniosek() { }
            public void UstawHarmonogram() { }
        }
        private class Zwykly : Pracownik { }
        private abstract class Funkcja : Pracownik { }
        private class Przelozony : Funkcja {
            List<Wniosek> listaWnioskowDoZatwierdzenia;
            public Przelozony() { }
            public void PrzejrzyjWniosek() { }
            public void ZatwierdzWniosek() { }
            public void OdrzucWniosek() { }
        }
        private class Kadrowy : Funkcja {
            public Kadrowy() { }
            public void GenerujRaport() { }
            public void ZmienDniWolne() { }
        }
        private class Personalny : Funkcja {
            List<Wniosek> listaKorekt;
            public Personalny() { }
            public void DodajPracownika() { }
            public void UsunPracownika() { }
            public void ZmienDane() { }
        }

        private abstract class ManagerHarmonogramu { }
        private class PelenEtatJednaZmiana : ManagerHarmonogramu { }
        private class PolEtatJednaZmiana : ManagerHarmonogramu { }
        private class PelenEtatTrzyZmiany : ManagerHarmonogramu { }
        private class ElastycznyCzasPracy : ManagerHarmonogramu { }
        private class Harmonogram { }
        private class PlanDnia { }

        private abstract class Wniosek {
            int IDwniosku;
            Pracownik pracownik;
            Pracownik nadzorujacy;
            DateTime dataWniosku;
            DateTime czasOd;
            DateTime czasDo;
            public Wniosek() { }
        }
        private class WniosekOUrlop : Wniosek { }
        private class WniosekOCzasWolny : Wniosek { }
        private class WniosekONadgodziny : Wniosek { }
        private class KorektaDanych : Wniosek { }
        private class KorektaWejscia : Wniosek { }
        private class KorektaWyjscia : Wniosek { }
    }
}
