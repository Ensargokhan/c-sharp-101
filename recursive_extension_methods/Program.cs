using System.Transactions;

class Program
{
    static void Main()
    {
        Islemler instance = new();
        Console.WriteLine(instance.Expo(3, 4));

        string isim = "ensar gökhan";
        bool sonuc = isim.CheckSpace();
        Console.WriteLine(sonuc);

        if (sonuc)
        {
            Console.WriteLine(isim.RemoveWhiteSpaces());
        }

        Console.WriteLine(isim.MakeUpperCase());
        Console.WriteLine(isim.MakeLowerCase());
    }
}

// recursive fonksiyon örneği
public class Islemler
{
    public int Expo(int sayi, int pow)
    {
        if (pow < 2)
            return sayi;
        return Expo(sayi, pow - 1) * sayi;
    }
}

public static class Extension
{
    public static bool CheckSpace(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
}