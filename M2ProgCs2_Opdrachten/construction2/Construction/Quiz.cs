namespace Construction;


class QuizVraag
{
    internal string vraag;
    internal string antwoord;

    internal QuizVraag(string vraag, string antwoord)
    {
        this.vraag = vraag;
        this.antwoord = antwoord;
    }
    private void run()
    {
        QuizVraag quizVraag = new QuizVraag("","");
    }
}