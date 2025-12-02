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

}
