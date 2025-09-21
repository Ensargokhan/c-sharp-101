string sayi = "999";
int outSayi;
bool sonuc = int.TryParse(sayi, out outSayi);
if (sonuc)
{
    Console.WriteLine("başarılı");
    Console.WriteLine(sonuc);
}
else
{
    Console.WriteLine("başarısız");
}

Metodlar instance = new Metodlar();
instance.Topla(2, 3, out int toplam);
Console.WriteLine(toplam);

int deneme = 999;
instance.PrintScreen(deneme);

class Metodlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void PrintScreen(string veri)
    {
        Console.WriteLine(veri);
    }
    public void PrintScreen(int veri)
    {
        Console.WriteLine(veri);
    }
}