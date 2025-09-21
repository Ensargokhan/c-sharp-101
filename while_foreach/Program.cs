/*
Console.Write("bir sayı girin :");
float sayi = int.Parse(Console.ReadLine());
float sayac = 1;
float toplam = 0;
while (sayac <= sayi)
{
    toplam += sayac;
    sayac++;

}
float ortalama = toplam / sayi;
Console.WriteLine(ortalama);
*/
string[] arabalar = {"ford", "bmw", "fiat", "opel"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}