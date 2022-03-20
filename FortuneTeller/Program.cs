using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis kasutajaga juhtub homme (kasutame Random klassi)

            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "turn the darkside for cookies" };

            Random rnd = new Random();
            int useNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Tomorrow you will {predictions[useNumber]}.");

        }
    }
}
