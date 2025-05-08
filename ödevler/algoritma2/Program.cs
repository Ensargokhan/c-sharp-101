int n, m;

Console.Write("1. sayıyı giriniz: ");
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("hatalı sayı girdiniz");
}

Console.Write("2. sayıyı giriniz: ");
while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
{
    Console.WriteLine("hatalı sayı girdiniz");
}

int[] sayilar = new int[n];

for (int i = 0; i < n; i++)
{
    int sayi;
    Console.Write($"{i + 1}. sayıyı giriniz:");
    while (!int.TryParse(Console.ReadLine(), out sayi) || sayi <= 0)
    {
        Console.WriteLine("hatalı sayı girdiniz");
    }
    sayilar[i] = sayi;
}

foreach (int sayi in sayilar)
{
    if (sayi % m == 0)
    {
        Console.WriteLine(sayi);
    }
}