using System;

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());

//datetime format
Console.WriteLine(DateTime.Now.ToString("dd")); //sayı halinde gün
Console.WriteLine(DateTime.Now.ToString("ddd")); //günün string hali ama 3 harf
Console.WriteLine(DateTime.Now.ToString("dddd")); //günün string hali
// bunların aylar ve yıllar için olan versiyonları da var tek fark d yerine m ve y kullanılıyor


//MATH

Console.WriteLine(Math.Abs(-5)); // mutlak alır
Console.WriteLine(Math.Sin(10)); // sayının sinüsünü alır bunu tan cos cot hali de var

Console.WriteLine(Math.Ceiling(22.3)); // 22.3 den en küçük tam sayı
Console.WriteLine(Math.Round(22.3)); // hangi tam sayıya daha yakınsa
Console.WriteLine(Math.Floor(22.7)); // aşşağı yuvarlar


Console.WriteLine(Math.Max(2, 6));
Console.WriteLine(Math.Min(2, 6));

Console.WriteLine(Math.Pow(3, 4));
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Log(9));
Console.WriteLine(Math.Exp(3)); // e^3 verir
Console.WriteLine(Math.Log10(10)); // sayının log10 tabanında ki karşılığı
