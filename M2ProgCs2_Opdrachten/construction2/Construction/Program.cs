namespace Construction;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }
    private void run()
    {
        QuizVraag quizVraag = new QuizVraag("","");
        Quiz quiz = new Quiz(10);
    }
}
