namespace func;

internal class Program
{

    static void Main(string[] args)
    {
        //ik heb hier een variabel gemaakt die heet program van het typen program.
        Program program = new Program();
        program.Run();
        //iets laten starten of iets door laten gaan
    }
    internal void Run()
    {
        Console.WriteLine(Vraag1());
    }
    internal string Vraag1()
    {
        Console.WriteLine("How long do you think you can survive in a zombie apocalipse");
        string antwoord = Console.ReadLine();
        return antwoord;
    }

    internal string Vraag2()
    {
        Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
        string antwoord = Console.ReadLine();
        return antwoord;
    }


    internal string Vraag3()
    {
        Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
        string antwoord = Console.ReadLine();
        return antwoord;
    }


    internal string Vraag4()
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string antwoord = Console.ReadLine();
        return antwoord;
    }


    internal string Vraag5()
    {
        Console.WriteLine("What is the worst game you played but that you liked anyway?");
        string antwoord = Console.ReadLine();
        return antwoord;
    }
}
