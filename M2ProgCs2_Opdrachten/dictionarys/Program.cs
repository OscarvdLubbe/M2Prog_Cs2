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

            // foreach (KeyValuePair<int, string> item in personeelOpNummer)
            // {
            //     Console.WriteLine(item.Key + ": " + item.Value);
            // }
            foreach (KeyValuePair<int, string> item in personeelOpNummer)
            {
                Console.WriteLine();
            }
            foreach (int key in personeelOpNummer.Keys)
            {
                int Pn = key;
                Console.WriteLine(Pn);
            }
            foreach (KeyValuePair<int , string> item in personeelOpNummer)
            {
                
                Console.WriteLine(item.Value);
            }
        }
    }
}
