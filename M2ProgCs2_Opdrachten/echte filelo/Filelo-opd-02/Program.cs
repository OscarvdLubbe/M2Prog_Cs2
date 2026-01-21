namespace echte_filelo;

class Program
{
    static string welkomTekst = "Hello world";
    static string saveFile = "welkomState.txt";
    static void Main(string[] args)
    {
        Run();
    }
    static void Run()
    {
        while (true)
        {
            Console.WriteLine($"{welkomTekst}");
            Console.WriteLine("Enter a text, then press enter");
            welkomTekst = Console.ReadLine();
            File.WriteAllText(saveFile, welkomTekst);
            bool bestaatDeFile = File.Exists(saveFile);
            if (bestaatDeFile == true)
            {
                Console.WriteLine(File.ReadAllText(saveFile));
            }
        }
    }
}
