namespace Lists;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }
    internal void run()
    {
        string[] caracters = {
        "Pac-Man",
        "Samus",
        "Crash Bandicoot",
        "Spyro the Dragon",
        "Donkey Kong",
        "Mario",
        "Luigi",
        "Astro",
        "Solid Snake",
        "Master Chief",
        "Kratos",
        "Sonic the Hedgehog",
        "Link",


    };
        List<string> charaterList = new List<string>();
        
            for (int i = 0; i < caracters.Length; i++)
            {
                charaterList.Add(caracters[i]);
            }

            for (int i = 0; i < charaterList.Count; i++)
            {
                Console.WriteLine(charaterList[i]);
            }
        
    }

}
