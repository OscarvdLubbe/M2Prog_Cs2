using System.Runtime.CompilerServices;

namespace dictionaries
{
    class Program
    {
        static Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            personeelOpNummer.Add(52185, "pim");
            personeelOpNummer.Add(53185, "tim");

            string pim = personeelOpNummer[52185];
            string tim = personeelOpNummer[53185];

            Console.WriteLine(pim);
            Console.WriteLine(tim);

            //Dit kan ook gewoon.
            // foreach (KeyValuePair<int, string> item in personeelOpNummer)
            // {
            //     Console.WriteLine(item.Key + ": " + item.Value);
            // }
            foreach (int key in personeelOpNummer.Keys)
            {
                int Pn = item.Key;
                string naam = item.naam;
                Console.WriteLine($"{Pn}:{naam}");
            }
            foreach (int key in personeelOpNummer.Keys)
            {
                int Pn = key;
                Console.WriteLine(Pn);
            }
            foreach (string Value in personeelOpNummer.Values)
            {
                string naam = Value;
                Console.WriteLine(naam);
            }
        }

    }
}
