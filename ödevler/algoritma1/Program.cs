int n;

Console.Write("lütfen bir sayı giriniz:");

while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("hatalı sayı girdiniz");
}

int[] sayilar = new int[n];

for (int i = 0; i < n; i++)
{
    int sayi;
    Console.Write($"{i + 1}. sayıyı giriniz: ");
    while (!int.TryParse(Console.ReadLine(), out sayi) || n <= 0)
    {
        Console.WriteLine("hatalı sayı girdiniz");
    }
    sayilar[i] = sayi;
}

Console.WriteLine("\nÇift sayılar");
foreach (int sayi in sayilar)
{
    if (sayi % 2 == 0)
    {
        Console.WriteLine(sayi);
    }
}