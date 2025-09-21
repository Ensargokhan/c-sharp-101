using System.Collections.Generic;

// List<T> class
//T --> object türündedir. liste içerisinde ki elemanların tipini belirtir.

List<int> numbList = new List<int>();
// eleman ekleme
numbList.Add(23);
numbList.Add(10);
numbList.Add(4);
numbList.Add(5);
numbList.Add(92);
numbList.Add(34);

List<string> colorList = new List<string>();

colorList.Add("kırmızı");
colorList.Add("mavi");
colorList.Add("turuncu");
colorList.Add("sarı");
colorList.Add("yeşil");

//count
Console.WriteLine(colorList.Count);
Console.WriteLine(numbList.Count);

//foreach ile ekrana yazdırma
/*foreach (var sayi in numbList)
{
    Console.WriteLine(sayi);
}*/

numbList.ForEach(sayi => Console.WriteLine(sayi)); // tek satırda. bunu kullanmak daha mantıklı geldi.

// eleman çıkartma

numbList.Remove(4);
colorList.Remove("yeşil");

numbList.ForEach(sayi => Console.WriteLine(sayi));
colorList.ForEach(renk => Console.WriteLine(renk));

// indexe göre eleman çıkartma 
numbList.RemoveAt(0);
colorList.RemoveAt(0);

numbList.ForEach(sayi => Console.WriteLine(sayi));
colorList.ForEach(renk => Console.WriteLine(renk));

// liste içerisinde arama
if (numbList.Contains(10))
{
    Console.WriteLine("var");
}

// eleman ile indexe erişme 
Console.WriteLine(colorList.BinarySearch("sarı"));

// diziyi liste çevirme
string[] hayvanlar = { "kedi", "köpek", "kuş" };

List<string> hayvanlarListesi = new List<string>(hayvanlar);
hayvanlarListesi.ForEach(hayvan => Console.WriteLine(hayvan));

// liste temizleme
hayvanlarListesi.Clear();
