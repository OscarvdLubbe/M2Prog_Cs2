using System.ComponentModel.DataAnnotations;

namespace echte_filelo;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }
    static void Run()
    {
        Console.WriteLine(Environment.CurrentDirectory);
        string[] lines = File.ReadAllLines("quiz.txt");
        
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}
