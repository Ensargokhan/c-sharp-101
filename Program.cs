using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cumartesi);
        }
    }
    enum Gunler
    {
        pazartesi,
        sali,
        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar
    }
}