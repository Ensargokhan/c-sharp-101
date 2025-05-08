int n;

Console.Write("lütfen bir sayı giriniz: ");
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("hatalı sayı girdiniz: ");
}

string[] words = new string[n];

for (int i = 0; i < n; i++)
{
    string word;
    Console.Write($"{i + 1}. kelimeyi giriniz: ");
    word = Console.ReadLine();
    words[i] = word;
}
for (int i = words.Length - 1; i >= 0; i--)
{
    Console.WriteLine(words[i]);
}
