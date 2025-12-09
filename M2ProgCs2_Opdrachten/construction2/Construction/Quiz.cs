namespace Construction;


class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldAntwoord;
    
    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldAntwoord = new QuizVraagAntwoord[aantalVragen];
    }
    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }
    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag quizVraag = new QuizVraag("Hoe oud ben jij","Weet ik veel, ik ben jou niet");
    }
}
