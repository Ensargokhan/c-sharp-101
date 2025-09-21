using System;

namespace hazir_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "merhabalar";
            string degisken2 = "Dersimiz c#";

            //lenght
            Console.WriteLine(degisken.Length);

            // toUpper toLower 
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //concat
            Console.WriteLine(string.Concat(degisken, "deneme"));

            //compare, compareTo
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken, degisken2, false));// true --> büyük küçük harf duyarsız false --> duyarlı

            //contains
            Console.WriteLine(degisken.Contains(degisken2));

            //indexOf
            Console.WriteLine(degisken.IndexOf("ba"));

            //insert
            Console.WriteLine(degisken.Insert(0, "test"));
        }
    }
}