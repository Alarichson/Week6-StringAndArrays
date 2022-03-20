using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //program kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"
            //luua vähemalt 3 counter-it

            Console.WriteLine("Hello World!");
            string fullSentence = "Hello World!".ToLower();

            
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0; 

            for (int i = 0; i < fullSentence.Length; i++)
            {
                if (fullSentence[i] == 'h') //char a = 'a';
                {
                    hCounter++;
                }
                if (fullSentence[i] == 'o')
                {
                    oCounter++;
                }
                if (fullSentence[i] == 'l')
                {
                    lCounter++;
                }
            }
            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' tähte");
            }
            else
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' täht");
            }
            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses on {oCounter} 'o' tähte");
            }
            else
            {
                Console.WriteLine($"Lauses on {oCounter} 'o' täht");
            }
            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses on {lCounter} 'l' tähte");
            }
            else
            {
                Console.WriteLine($"Lauses on {lCounter} 'l' täht");
            }




        }
    }
}
