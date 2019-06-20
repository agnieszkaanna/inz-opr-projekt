using System;
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
            return new MainWindow();
        }

        
        private abstract class Pracownik { }
        private class Zwykly : Pracownik { }
        private abstract class Funkcja : Pracownik { }
        private class Przelozony : Funkcja { }
        private class Kadrowy : Funkcja { }
        private class Personalny : Funkcja { }

        private abstract class ManagerHarmonogramu { }
        private class PelenEtatJednaZmiana : ManagerHarmonogramu { }
        private class PolEtatJednaZmiana : ManagerHarmonogramu { }
        private class PelenEtatTrzyZmiany : ManagerHarmonogramu { }
        private class ElastycznyCzasPracy : ManagerHarmonogramu { }
        private class Harmonogram { }
        private class PlanDnia { }

        private abstract class Wniosek { }
        private class WniosekOUrlop : Wniosek { }
        private class WniosekOCzasWolny : Wniosek { }
        private class WniosekONadgodziny : Wniosek { }
        private class KorektaDanych : Wniosek { }
        private class KorektaWejscia : Wniosek { }
        private class KorektaWyjscia : Wniosek { }
    }
}
