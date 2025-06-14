// See https://aka.ms/new-console-template for more information
try // hata alması muhtemel kodu yazdığımız blok 
{
    Console.WriteLine("bir sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("sayı:" + sayi);  
}
catch(Exception ex) // hatayı yakalayıp kullanıcıya mesaj gönderebileceğimiz blok
{
    Console.WriteLine("hata:" + ex.Message.ToString());
}
/*finally // hata alsın yada almasın çalışacak blok 
{
    Console.WriteLine("işlem tamamlandı");
}*/

try
{
    int a = int.Parse("test");
}
catch (FormatException ex)
{
    Console.WriteLine("veri tipi uygun değil");
    Console.WriteLine(ex);
}
