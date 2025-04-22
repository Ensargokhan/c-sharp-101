int sayi1 = 2, sayi2 = 3;

int sonuc = Topla(sayi1,sayi2);
Console.WriteLine(sonuc);
Metods ornek = new Metods();
ornek.PrintScreen(Convert.ToString(sonuc));

int Topla(int sayi1, int sayi2)
{
    return (sayi1 + sayi2);
}

class Metods
{
    public void PrintScreen(string veri)
    {
        Console.WriteLine(veri);
    }
}