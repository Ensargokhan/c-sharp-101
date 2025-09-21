using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> primeNumbers = new List<int>();
        List<int> nonPrimeNumbers = new List<int>();
        int count = 0;

        while (count < 20)
        {
            Console.Write($"[{count + 1}/20] Pozitif bir sayı girin: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number <= 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı girin!");
                    continue;
                }

                if (IsPrime(number))
                    primeNumbers.Add(number);
                else
                    nonPrimeNumbers.Add(number);

                count++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sadece sayısal bir değer girin.");
            }
        }

        // Büyükten küçüğe sıralama
        primeNumbers.Sort();
        primeNumbers.Reverse();

        nonPrimeNumbers.Sort();
        nonPrimeNumbers.Reverse();

        // Ekrana yazdırma
        Console.WriteLine("\n--- Asal Sayılar ---");
        PrintListInfo(primeNumbers);

        Console.WriteLine("\n--- Asal Olmayan Sayılar ---");
        PrintListInfo(nonPrimeNumbers);
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
            if (number % i == 0)
                return false;
        return true;
    }

    static void PrintListInfo(List<int> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("Liste boş.");
            return;
        }

        Console.WriteLine("Sayılar: " + string.Join(", ", list));
        Console.WriteLine("Eleman Sayısı: " + list.Count);
        Console.WriteLine("Ortalama: " + list.Average().ToString("0.00"));
    }
}
