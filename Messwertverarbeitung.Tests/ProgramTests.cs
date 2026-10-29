using Microsoft.VisualStudio.TestTools.UnitTesting;
using Messwertverarbeitung;

namespace Messwertverarbeitung.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Durchschnitt_Werte1Bis5_Ergibt3()
        {
            // Arrange: Erwarteten Durchschnitt festlegen.
            double erwartet = 3.0;

            // Act: Durchschnitt berechnen.
            double ergebnis = MesswertBerechnung.Durchschnitt(1, 2, 3, 4, 5);

            // Assert: Ergebnis mit dem erwarteten Wert vergleichen.
            Assert.AreEqual(erwartet, ergebnis, 1e-10);
        }

        [TestMethod]
        public void SumAll_WerteHebenSichAuf_Ergibt0()
        {
            // Arrange: Gültige Messwerte, deren Summe null ist.
            double m1 = -5, m2 = 5, m3 = 0, m4 = 0, m5 = 0;
            double? erwartet = 0.0;

            // Act: Summe berechnen.
            double? ergebnis = MesswertBerechnung.SumAll(m1, m2, m3, m4, m5);

            // Assert: Bewusst rot, weil HatMesswerte die Messwerte fälschlich als fehlend erkennt.
            Assert.AreEqual(erwartet, ergebnis);
        }

        [DataTestMethod]
        [DataRow(1.0, 2.0, 3.0, 4.0, 5.0, 3.0)]
        [DataRow(-5.0, -3.0, -4.0, 0.0, 0.0, -2.4)]
        [DataRow(0.5, 0.5, 0.0, 0.0, 0.0, 0.2)]
        public void Durchschnitt_VerschiedeneWerte_ErgibtErwartetenWert(
            double m1, double m2, double m3, double m4, double m5, double erwartet)
        {
            // Arrange: Jede DataRow liefert fünf Messwerte und den erwarteten Durchschnitt.

            // Act: Durchschnitt für die jeweilige Datenzeile berechnen.
            double ergebnis = MesswertBerechnung.Durchschnitt(m1, m2, m3, m4, m5);

            // Assert: Das Ergebnis dieser Datenzeile überprüfen.
            Assert.AreEqual(erwartet, ergebnis, 1e-10);
        }
    }
}

