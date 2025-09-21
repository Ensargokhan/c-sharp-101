/*
Console.WriteLine("bir sayı girin: ");
int sayac = int.Parse(Console.ReadLine());
for (int i = 1; i <= sayac; i++)
{
    if(i % 2 == 1)
    {
        Console.WriteLine(i); // Doğru kullanım: Sayıyı ekrana yazdırır
    }
}*/

int tek = 0;
int cift = 0;

for (int i = 0; i <= 1000; i++)
{
    if(i % 2 == 0)
        cift += i;
    else
        tek += i;    
}
Console.WriteLine("Çift:" + cift);
Console.WriteLine("Tek:" + tek);