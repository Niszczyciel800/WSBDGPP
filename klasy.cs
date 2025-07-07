using System;
using System.Collections.Generic;

public class Atrakcja
{
    public string Nazwa { get; set; }
    public int Dzien { get; set; }
    public string Godzina { get; set; }
    
    public Atrakcja(string nazwa, int dzien, string godzina)
    {
        Nazwa = nazwa;
        Dzien = dzien;
        Godzina = godzina;
    }
    
    public void PokazInfo()
    {
        Console.WriteLine($"  -> {Nazwa} (Dzień {Dzien}, {Godzina})");
    }
}

public class Miejsce
{
    public string Nazwa { get; set; }
    public string Kraj { get; set; }
    public List<Atrakcja> Atrakcje { get; set; }
    
    public Miejsce(string nazwa, string kraj)
    {
        Nazwa = nazwa;
        Kraj = kraj;
        Atrakcje = new List<Atrakcja>();
    }
    
    public void DodajAtrakcje(Atrakcja atrakcja)
    {
        Atrakcje.Add(atrakcja);
    }
    
    public void PokazInfo()
    {
        Console.WriteLine($"\n** Miejsce: {Nazwa}, {Kraj} **");
        foreach (var atr in Atrakcje)
        {
            atr.PokazInfo();
        }
    }
}

public class Wycieczka
{
    public string Nazwa { get; set; }
    public string DataStart { get; set; }
    public string DataKoniec { get; set; }
    public List<Miejsce> Miejsca { get; set; }
    
    public Wycieczka(string nazwa, string dataStart, string dataKoniec)
    {
        Nazwa = nazwa;
        DataStart = dataStart;
        DataKoniec = dataKoniec;
        Miejsca = new List<Miejsce>();
    }
    
    public void DodajMiejsce(Miejsce miejsce)
    {
        Miejsca.Add(miejsce);
    }
    
    public void PokazPlan()
    {
        Console.WriteLine($"\n===== PLAN WYCIECZKI: {Nazwa} =====");
        Console.WriteLine($"Termin: {DataStart} - {DataKoniec}");
        Console.WriteLine("\nTrasa:");
        foreach (var miejsce in Miejsca)
        {
            miejsce.PokazInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        // Robimy atrakcje
        Atrakcja atr1 = new Atrakcja("Spacer po rynku", 1, "14:00");
        Atrakcja atr2 = new Atrakcja("Wejście na Giewont", 2, "9:30");
        Atrakcja atr3 = new Atrakcja("Zwiedzanie muzeum", 3, "11:00");
        
        // Robimy miejsca
        Miejsce krakow = new Miejsce("Kraków", "Polska");
        krakow.DodajAtrakcje(atr1);
        krakow.DodajAtrakcje(atr3);
        
        Miejsce tatry = new Miejsce("Tatry", "Polska");
        tatry.DodajAtrakcje(atr2);
        
        // Planujemy wycieczkę
        Wycieczka mojaWycieczka = new Wycieczka("Góralska przygoda", "2025-07-01", "2025-07-07");
        mojaWycieczka.DodajMiejsce(krakow);
        mojaWycieczka.DodajMiejsce(tatry);
        
        // Pokazujemy plan
        mojaWycieczka.PokazPlan();
    }
}
