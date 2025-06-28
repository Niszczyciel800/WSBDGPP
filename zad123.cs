using System;

class Program
{
    static void Zadanie1()
    {
        Console.WriteLine("Kalkulator dwóch liczb");
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Wybierz operację (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine($"Wynik: {a + b:F2}");
                break;
            case "-":
                Console.WriteLine($"Wynik: {a - b:F2}");
                break;
            case "*":
                Console.WriteLine($"Wynik: {a * b:F2}");
                break;
            case "/":
                if (b == 0)
                    Console.WriteLine("Błąd: dzielenie przez zero!");
                else
                    Console.WriteLine($"Wynik: {a / b:F2}");
                break;
            default:
                Console.WriteLine("Niepoprawna operacja!");
                break;
        }
    }

    static void Zadanie2()
    {
        Console.WriteLine("Konwerter temperatur");
        Console.Write("Wybierz kierunek (C - Celsjusz→Fahrenheit, F - Fahrenheit→Celsjusz): ");
        string kierunek = Console.ReadLine().ToUpper();

        switch (kierunek)
        {
            case "C":
                Console.Write("Podaj temperaturę w °C: ");
                double c = Convert.ToDouble(Console.ReadLine());
                double f = c * 1.8 + 32;
                Console.WriteLine($"{c}°C = {f:F1}°F");
                break;
            case "F":
                Console.Write("Podaj temperaturę w °F: ");
                f = Convert.ToDouble(Console.ReadLine());
                c = (f - 32) / 1.8;
                Console.WriteLine($"{f}°F = {c:F1}°C");
                break;
            default:
                Console.WriteLine("Niepoprawny wybór!");
                break;
        }
    }

    static void Zadanie3()
    {
        Console.WriteLine("Średnia ocen ucznia");
        Console.Write("Podaj liczbę ocen: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double suma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Podaj ocenę #{i} (1-6): ");
            double ocena = Convert.ToDouble(Console.ReadLine());
            
            if (ocena < 1 || ocena > 6)
            {
                Console.WriteLine("Ocena musi być w zakresie 1-6!");
                return;
            }
            suma += ocena;
        }

        double srednia = suma / n;
        string status = srednia >= 3.0 ? "zdał" : "nie zdał";
        Console.WriteLine($"Średnia: {srednia:F2}");
        Console.WriteLine($"Uczeń {status}.");
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMENU GŁÓWNE");
            Console.WriteLine("1. Kalkulator dwóch liczb");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Średnia ocen ucznia");
            Console.WriteLine("0. Wyjście");
            
            Console.Write("Wybierz zadanie (0-3): ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Zadanie1();
                    break;
                case "2":
                    Zadanie2();
                    break;
                case "3":
                    Zadanie3();
                    break;
                case "0":
                    Console.WriteLine("Koniec programu");
                    return;
                default:
                    Console.WriteLine("Niepoprawny wybór!");
                    break;
            }
        }
    }
}
