using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab "Hello World!" tagurpidi

            Console.WriteLine("Hello World!");
            string fullSentence = "Hello World!";

            for (int i = fullSentence.Length - 1; i >= 0; i--)
            {
                Console.Write(fullSentence[i]);
            }





        }
    }
}
