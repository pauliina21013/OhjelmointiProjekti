namespace Kilometrikorvaus;
class MainProgram
{
    public void TextUserInterface()
    {
        TravelDetailsCollector travelDetailsCollector = new();
        while (true) // loops until the input is valid
        {
            Console.WriteLine("Kilometrikorvaus | Kirjoita numero" + Environment.NewLine + "[1] Syötä matkoja" + Environment.NewLine +
            "[2] Tarkastele maksuja" + Environment.NewLine + "[0] Lopetus");
            Console.WriteLine();
            var mm1 = Console.ReadLine();
            int mainMenu1 = Convert.ToInt32(mm1);

            if (mainMenu1 == 0)
            {
                System.Environment.Exit(0); // shuts the program down
            }

            if (mainMenu1 == 1)
            {
                // syötä matkoja
                // avaa toisen valikon (vielä alla)
                // toinen valikko liitettävä tähän
                Console.WriteLine("Toinen valikko avautuu tämän jälkeen.");
                break; // out of the loop
            }

            if (mainMenu1 == 2)
            {
                 // tarkastele maksuja
                // vielä työn alla
                Console.WriteLine("=== Lista maksuista ===");
                Console.WriteLine("Matka: " + /*sijanti +*/ Environment.NewLine + "Matkaan kulunut aika: "
                /*+ lähtöaika*/ + ", " /*+ saapumisaika*/ + Environment.NewLine + "Matkan pituus: " + 
                /*syötetytKilometrit +*/ Environment.NewLine + "Maksettava korvaus: " /*+ maksettavaKorvaus*/
                + Environment.NewLine);

                /*if (syötetytKilometrit != null)
                {
                    Console.WriteLine("Ei maksettavia korvauksia.");
                }*/
                break;
            }

            else
            {
                Console.WriteLine("Syötettä ei voida hyväksyä." + Environment.NewLine);
                continue; // restart the loop
            }
        }




        while (true) // loop
        {
            Console.WriteLine(Environment.NewLine + "Kirjoita numero" + Environment.NewLine
            + "[1] Luo uusi matka" + Environment.NewLine + "[2] Korvauksen maksutiedot"
            + Environment.NewLine + "[0] Takaisin");
            Console.WriteLine();
            var mm2 = Console.ReadLine();
            int mainMenu2 = Convert.ToInt32(mm2);


            if (mainMenu2 == 1)
            {
                decimal kilometriKorvaus = 0.46m; //korvaus euroina per kilometri

                Console.WriteLine("Syötä matkan pituus kilometreinä");
                var syote = Console.ReadLine();
                if (syote != null) {
                    int syötetytKilometrit = Int32.Parse(syote);

                    if (syötetytKilometrit < 15)
                    {
                        Console.WriteLine("Alle 15 km matkasta ei saa korvausta");
                    }

                    else
                    {
                        Console.WriteLine();
                        decimal maksettavaKorvaus = syötetytKilometrit * kilometriKorvaus;

                        Console.WriteLine("Kilometrikorvauksesi on " + maksettavaKorvaus + " Euroa");


                    }
                }

                continue;
            }

            if (mainMenu2 == 2)
            {
                Console.WriteLine("Kilometrikorvausta maksetaan vain 15 km ylittävästä matkasta." + Environment.NewLine
                + "Korvausta maksetaan 0,46 euroa kilometriltä." + Environment.NewLine
                + "Kilometrikorvauksen lisäksi matkasta voidaan maksaa osapäivä- tai kokopäivärahaa." + Environment.NewLine
                + "Osapäivärahaa maksetaan yli 6 tunnin matkasta 20 euroa." + Environment.NewLine
                + "Kokopäivärahaa maksetaan yli 10 tunnin matkasta 45 euroa." + Environment.NewLine);
                continue;
            }

            if (mainMenu2 == 0)
            {
                break;
            }

            else
            {
                Console.WriteLine("Syötettä ei voida hyväksyä." + Environment.NewLine);
                continue; // restart the loop
            }
        }
    }
}
