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
        string[] vragen = new string[]
        {
            "How long do you think you can survive in a zombie apocalipse",
            "What secret conspiracy would you like to actually start letting other people know?",
            "If you can still remember, what are your funniest childhood memories?",
            "What would you do if you won a million dollars?",
            "What is the worst game you played but that you liked anyway?"
        };
    
    internal void Run()
    {
        string vraag0 = GetVraag(0);
        Console.WriteLine(vraag0);
    }

    internal string GetVraag(int vraagIndex)
    {
        return vragen[vraagIndex];
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
