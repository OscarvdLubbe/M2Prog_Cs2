namespace Rijschool;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    private void Run()
    {

        Auto auto1 = new Auto()
        {
            automaat = false,
            kenteken = "AA824H",
            kilometerStand = 20567,
            merk = "volkswagen"
        };

        Auto auto2 = new Auto()
        {
            automaat = true,
            kenteken = "KU786G",
            kilometerStand = 65739,
            merk = "volvo",
        };

        RijLeraar rijLeraar = new RijLeraar()
        {
            leeftijd = 30,
            naam = "John",
            zzp = false
        };

        
        LesPakket lesPakket = new LesPakket
        {
            urenGekocht = 40,
            urenVerbruikt = 40,
            examenPogingen = 3,
            automaat = false
        };

        TheorieTest theorieTest = new TheorieTest
        {
            aantalFouten = 6,
            gehaalt = false,
            afnameDatum = new DateTime(2000, 2, 20, 20, 20, 20)
        };

        RijTest RijTest = new RijTest
        {
            gehaald = true,
            afnameDatum = new DateTime(2000, 2, 20, 20, 20, 20)
        };

        Student student = new Student
        {
            naam = "pieter",
            leeftijd = 17,
            LesPakket = lesPakket,
            RijLeraar = rijLeraar,
            theorieTest = theorieTest,
            rijTest = RijTest,
            // lesUur = lesUur
        };
        Student student1 = new Student
        {
            naam = "pietar",
            leeftijd = 117,
            LesPakket = lesPakket,
            RijLeraar = rijLeraar,
            theorieTest = theorieTest,
            rijTest = RijTest,
            // LesUur = lesUur
        };

        LesUur lesUur = new LesUur
        {
            auto = auto1,
            rijleraar = rijLeraar,
            student = student,
            tijd = 1130
        };

        Dag Dag = new Dag
        {
            datum = new DateTime(2000, 2, 20, 4, 20, 20),
            lesuren = new LesUur[]
            {
                lesUur
            }
        };
    }
}
