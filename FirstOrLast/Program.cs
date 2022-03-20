using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab, kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            if(firstName.Length < lastName.Length)
            {
                Console.WriteLine($"Sinu perekonnanimi on pikem. {lastName.Length} sümbolit");
            }
            else if(firstName.Length > lastName.Length)
            {
                Console.WriteLine($"Sinu eesnimi on pikem. {firstName.Length} sümbolit");
            }
            else
            {
                Console.WriteLine($"Sinu ees- ja perekonnanimi on ühepikkused. {firstName.Length} sümbolit");
            }


            Console.WriteLine("Kena päeva!");





        }
    }
}
