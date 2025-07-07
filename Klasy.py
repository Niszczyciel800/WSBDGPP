# Klasa dla pojedynczej atrakcji
class Atrakcja:
    def __init__(self, nazwa, dzien, godzina):
        self.nazwa = nazwa  # np. "Zwiedzanie zamku"
        self.dzien = dzien  # dzień podróży (1, 2, 3...)
        self.godzina = godzina  # np. "10:00"
    
    def pokaz_info(self):
        print(f"  -> {self.nazwa} (Dzień {self.dzien}, {self.godzina})")

# Klasa dla miejsca docelowego
class Miejsce:
    def __init__(self, nazwa, kraj):
        self.nazwa = nazwa  # np. "Kraków"
        self.kraj = kraj    # np. "Polska"
        self.atrakcje = []  # lista atrakcji w tym miejscu
    
    def dodaj_atrakcje(self, atrakcja):
        self.atrakcje.append(atrakcja)
    
    def pokaz_info(self):
        print(f"\n** Miejsce: {self.nazwa}, {self.kraj} **")
        for atr in self.atrakcje:
            atr.pokaz_info()

# Klasa dla całej podróży
class Wycieczka:
    def __init__(self, nazwa, data_start, data_koniec):
        self.nazwa = nazwa          # np. "Wakacje w górach"
        self.data_start = data_start # np. "2025-07-01"
        self.data_koniec = data_koniec
        self.miejsca = []           # lista miejsc do odwiedzenia
    
    def dodaj_miejsce(self, miejsce):
        self.miejsca.append(miejsce)
    
    def pokaz_plan(self):
        print(f"\n===== PLAN WYCIECZKI: {self.nazwa} =====")
        print(f"Termin: {self.data_start} - {self.data_koniec}")
        print("\nTrasa:")
        for miejsce in self.miejsca:
            miejsce.pokaz_info()

# --- Testujemy program ---
if __name__ == "__main__":
    # Tworzymy atrakcje
    atr1 = Atrakcja("Spacer po rynku", 1, "14:00")
    atr2 = Atrakcja("Wejście na Giewont", 2, "9:30")
    atr3 = Atrakcja("Zwiedzanie muzeum", 3, "11:00")
    
    # Tworzymy miejsca z atrakcjami
    krakow = Miejsce("Kraków", "Polska")
    krakow.dodaj_atrakcje(atr1)
    krakow.dodaj_atrakcje(atr3)
    
    tatry = Miejsce("Tatry", "Polska")
    tatry.dodaj_atrakcje(atr2)
    
    # Tworzymy wycieczkę
    moje_wakacje = Wycieczka("Góralska przygoda", "2025-07-01", "2025-07-07")
    moje_wakacje.dodaj_miejsce(krakow)
    moje_wakacje.dodaj_miejsce(tatry)
    
    # Pokazujemy cały plan
    moje_wakacje.pokaz_plan()
