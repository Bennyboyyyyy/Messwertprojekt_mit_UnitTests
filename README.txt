MESSWERTPROJEKT – Projektmappe
==============================

Enthalten:
  Messwertverarbeitung/          Konsolenprogramm (Live-Demo)
  Messwertverarbeitung.Tests/    MSTest-Unit-Tests

Voraussetzung: .NET 8 SDK (https://dotnet.microsoft.com/download)

Starten (Live-Demo):
  dotnet run --project Messwertverarbeitung

Tests ausführen:
  dotnet test

Hinweis:
  Der Test "SumAll_WerteHebenSichAuf_Summe0" schlägt
  BEWUSST fehl – er zeigt den gefundenen Bug mit der Prüfung
  "summe == 0" (Folie "Der Grenzwerttest, der einen Bug findet").
