using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik o tähed lauses "Dont Panic" numbriga 0
            //programm asendab kõik a tähed numbriga 4

            string helloW = "Don't Panic";

           
            helloW = helloW.Replace('o', '0');
            helloW = helloW.Replace('a', '4');
            Console.WriteLine(helloW);




        }
    }
}
