namespace Lists
{
    class Program
    {
        internal class Pickup
        {
            internal int x, y;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
        }

        internal void run()
        {
            string[] caracters = {
                "Pac-Man",
                "Samus",
                "Crash Bandicoot",
                "Spyro the Dragon",
                "Donkey Kong",
                "Mario",
                "Luigi",
                "Astro",
                "Solid Snake",
                "Master Chief",
                "Kratos",
                "Sonic the Hedgehog",
                "Link",
            };

            List<string> charaterList = new List<string>();

            for (int i = 0; i < caracters.Length; i++)
            {
                charaterList.Add(caracters[i]);
            }

            for (int i = 0; i < charaterList.Count; i++)
            {
                Console.WriteLine(charaterList[i]);
            }


            List<double> revieuws = new List<double> { 1.11, 2.22, 3.33 };

            for (int i = 0; i < revieuws.Count; i++)
            {
                Console.WriteLine(revieuws[i]);
            }

            revieuws.Remove(1.11);
            revieuws.Remove(2.22);


            List<Pickup> pickups = new List<Pickup>();

            for (int i = 0; i < 10; i++)
            {
                Pickup pickup = new Pickup()
                {
                    x = i,
                    y = 0
                };
                pickups.Add(pickup);
            }
            foreach (var item in collection)
            {
                if (pickups[i].x == 4)
                {
                    pickups.RemoveAt(i);
                }
            }
        }
    }
}
