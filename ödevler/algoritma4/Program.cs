Console.Write("bir cümle giriniz: ");

string sentence = Console.ReadLine();
string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int wordsCount = words.Length;

int letterCount = 0;
foreach (char c in sentence)
{
    if (char.IsLetter(c))
    {
        letterCount++;
    }
}

Console.WriteLine("toplam kelime sayısı: " + wordsCount);
Console.WriteLine("toplam harf sayısı: " + letterCount);
