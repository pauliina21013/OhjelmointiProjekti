namespace Kilometrikorvaus;
class MainProgram
{
    public void TextUserInterface()
    {
        while (true) // loops until the input is valid
        {
            Console.WriteLine("Kilometrikorvaus | Kirjoita numero" + Environment.NewLine + "[1] Syötä matkoja" + Environment.NewLine +
            "[2] Tarkastele maksuja" + Environment.NewLine + "[0] Lopetus");
            Console.WriteLine();
            string mm1 = Console.ReadLine(); //TODO: fix this CS8600 issue
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
                // if syötäMatkoja == empty, Console.WriteLine("Ei maksamattomia maksuja");
                Console.WriteLine("Tähän tulee esille ohjelmaan jo syötetyt tiedot");
                break;
            }

            else
            {
                Console.WriteLine("Syötettä ei voida hyväksyä." + Environment.NewLine);
                continue; // restart the loop
            }

            //TODO: fix this unreachable code
            break; // out of the loop
        }




        while (true) // loop
        {
            Console.WriteLine(Environment.NewLine + "Kirjoita numero" + Environment.NewLine
            + "[1] Luo uusi matka" + Environment.NewLine + "[2] Korvauksen maksutiedot"
            + Environment.NewLine + "[0] Takaisin");
            Console.WriteLine();
            string mm2 = Console.ReadLine(); //TODO: fix this CS8600 issue
            int mainMenu2 = Convert.ToInt32(mm2);

            if (mainMenu2 == 1)
            {
                Console.WriteLine("Tähän koodi, millä täytät matkan tiedot: ");
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


        // luo uusi matka
        Console.WriteLine("Matkan lähtöpiste ja päämäärä: ");

        // onko 24h kellosta hankalaa laskea koodilla tunnit? 
        // kannattaako lähtö- / saapumisaika vaihtaa siten, että asiakas syöttää suoraan vain tunnit?
        Console.WriteLine("Lähtöaika: ");
        Console.WriteLine("Saapumisaika: ");

        Console.WriteLine("Matkaan yhteensä kuluneet kilometrit: ");
        // jos syöte ei kokonaisluku int
        Console.WriteLine("Syötä vain kokonaiset kilometrit. Pyöristä lähimpään kokonaislukuun: ");

        /*
        x: Name = "departureLabel"  Text = "Syöte muodossa 00:00, 24h mukaan"
        x: Name = "departureInput1" Content = "Matkaan lähtöaika"

        x: Name = "arrivalLabel" Content = "Saapumisaika kohteeseen"
        x: Name = "arrivalInput"  Text = "Syöte muodossa 00:00, 24h mukaan"

        x: Name = "kmLabel" Content = "Matkaan yhteensä kuluneet kilometrit" 
        x: Name = "kmINput" Text = "Syöte muodossa 00,0km" 
        */
    }
}