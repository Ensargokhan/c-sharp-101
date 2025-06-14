/*
string[] renkler = new string[5];
string[] hayvanlar = {"kedi", "köpek", "kuş", "kaplumbağa"};

int[] dizi;
dizi = new int[5];

renkler[0] = "mavi";
dizi[3] = 10;

Console.WriteLine(hayvanlar[2]);
*/
Console.Write("dizinin eleman sayısını giriniz:");
int diziLength = int.Parse(Console.ReadLine());
int[] sayiArray = new int[diziLength];

for (int i = 0; i < diziLength; i++)
{
    Console.Write("lütfen {0}. sayıyı giriniz:", i+1);
    sayiArray[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (var sayi in sayiArray)
{
    toplam += sayi;
}
Console.WriteLine("ortlama:" + toplam / diziLength);