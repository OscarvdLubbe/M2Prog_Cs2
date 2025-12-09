namespace voorHerhaling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program program = new Program();
        program.run();
    }
    private void run()
    {
        double[] prijzen = new double[] { 0.99, 1.11, 2.00 };
        string[] artiekelen = { "snoepjes", "luxe broodjes", "lunch menu" };
        Formulier[] formulieren = new Formulier[2];


        formulieren[0] = new Formulier()
        {
            Feedback = "prijzig maar lekker",
            sterren = 5
        };
        formulieren[1] = new Formulier()
        {
            Feedback = "lekker",
            sterren = 7
        };

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(artiekelen[i] + " " + prijzen[i]);
        }
        foreach (Formulier formulier in formulieren)
        {
            Console.WriteLine(formulier.Feedback +"");
        }
    }

}
