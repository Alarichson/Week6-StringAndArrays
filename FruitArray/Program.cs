using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab mis puuvilja kasutaja sööb

            //string[] fruit = new string[5];
            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };

            //Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);
            //...
            Random rnd = new Random();
            int useNumber = rnd.Next(0, fruit.Length); //mingi osa puudu, hetkel kohad 1 kuni 5 aga programm saab aru 0 kuni 4

            Console.WriteLine($"Today you will have {fruit[useNumber]}.");


        }
    }
}
