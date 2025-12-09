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
        QuizVraag quizVraag = new QuizVraag("Vraag","Antwoord");
        Quiz quiz = new Quiz(10);

        quiz.VoegVraagToeOpIndex(0,"vraag1","antwoord1");
        quiz.VoegVraagToeOpIndex(1,"vraag2","antwoord2");
        quiz.VoegVraagToeOpIndex(2,"vraag3","antwoord3");
        quiz.VoegVraagToeOpIndex(3,"vraag4","antwoord4");
        quiz.VoegVraagToeOpIndex(4,"vraag5","antwoord5");
        quiz.VoegVraagToeOpIndex(5,"vraag6","antwoord6");
        quiz.VoegVraagToeOpIndex(6,"vraag7","antwoord7");
        quiz.VoegVraagToeOpIndex(7,"vraag8","antwoord8");
        quiz.VoegVraagToeOpIndex(8,"vraag9","antwoord9");
        quiz.VoegVraagToeOpIndex(9,"vraag10","antwoord10");
    }
}
