using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle girin: ");
        string input = Console.ReadLine().ToLower(); // Küçük harfe çevir

        char[] vowels = new char[] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        string vowelChars = "";

        foreach (char c in input)
        {
            if (Array.IndexOf(vowels, c) >= 0)
            {
                vowelChars += c;
            }
        }

        char[] vowelArray = vowelChars.ToCharArray();
        Array.Sort(vowelArray);

        Console.WriteLine("\nCümledeki sıralanmış sesli harfler:");
        foreach (char ch in vowelArray)
        {
            Console.Write(ch + " ");
        }

        Console.WriteLine("\nToplam sesli harf sayısı: " + vowelArray.Length);
    }
}
