def zadanie1():
    print("Kalkulator dwóch liczb")
    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))
    op = input("Wybierz operację (+, -, *, /): ")

    if op == '+':
        wynik = a + b
    elif op == '-':
        wynik = a - b
    elif op == '*':
        wynik = a * b
    elif op == '/':
        if b == 0:
            print("Błąd: dzielenie przez zero!")
            return
        wynik = a / b
    else:
        print("Niepoprawna operacja!")
        return

    print(f"Wynik: {wynik:.2f}")

def zadanie2():
    print("Konwerter temperatur")
    kierunek = input("Wybierz kierunek (C - Celsjusz→Fahrenheit, F - Fahrenheit→Celsjusz): ").upper()

    if kierunek == 'C':
        c = float(input("Podaj temperaturę w °C: "))
        f = c * 1.8 + 32
        print(f"{c}°C = {f:.1f}°F")
    elif kierunek == 'F':
        f = float(input("Podaj temperaturę w °F: "))
        c = (f - 32) / 1.8
        print(f"{f}°F = {c:.1f}°C")
    else:
        print("Niepoprawny wybór!")

def zadanie3():
    print("Średnia ocen ucznia")
    n = int(input("Podaj liczbę ocen: "))
    suma = 0

    for i in range(1, n + 1):
        ocena = float(input(f"Podaj ocenę #{i} (1-6): "))
        if ocena < 1 or ocena > 6:
            print("Ocena musi być w zakresie 1-6!")
            return
        suma += ocena

    srednia = suma / n
    status = "zdał" if srednia >= 3.0 else "nie zdał"
    print(f"Średnia: {srednia:.2f}")
    print(f"Uczeń {status}.")

# Menu główne
while True:
    print("\nMENU GŁÓWNE")
    print("1. Kalkulator dwóch liczb")
    print("2. Konwerter temperatur")
    print("3. Średnia ocen ucznia")
    print("0. Wyjście")
    
    wybor = input("Wybierz zadanie (0-3): ")
    
    if wybor == '1':
        zadanie1()
    elif wybor == '2':
        zadanie2()
    elif wybor == '3':
        zadanie3()
    elif wybor == '0':
        print("Koniec programu")
        break
    else:
        print("Niepoprawny wybór!")
