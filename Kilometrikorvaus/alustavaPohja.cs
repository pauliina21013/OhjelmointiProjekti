namespace Kilometrikorvaus;
class MainProgram
{

    static void Main(string[] args)
    {
        var newMainProgram = new MainProgram();
        newMainProgram.TextUserInterface();
    }
    public void TextUserInterface()
    {
        TravelDetailsCollectorCollector tdcc = new();
        List<decimal> korvaukset = new();
        while (true) // loops until the input is valid
        {
            Console.WriteLine("Kilometrikorvaus | Kirjoita numero" + Environment.NewLine + "[1] Syötä matkoja" + Environment.NewLine +
            "[2] Tarkastele maksuja" + Environment.NewLine + "[3] Korvauksen maksutiedot" + Environment.NewLine + "[0] Lopetus");
            Console.WriteLine();
            var mainMenu1 = Console.ReadLine();

            if (mainMenu1 == "0")
            {
                System.Environment.Exit(0); // shuts the program down
            }

            if (mainMenu1 == "1")
            {
                // syötä matkoja
                Console.WriteLine("Anna syötteet ilman loppuliitettä, esim km tai h. Syötä vain numeroja. Syötä ohjelmaan vain yksi matka kerrallaan.");

                decimal kilometriKorvaus = 0.46m; //korvaus euroina per kilometri
                decimal puolipäiväRaha = 20m;     // 20 euroa jos yli 6 tuntia
                decimal kokopäiväRaha = 45m;      // 45 euroa jos yli 10 tuntia

                //Console.WriteLine("Syötä matkan pituus kilometreinä");
                TravelDetailsCollector tdc = new();
                tdc.InputAllTheNeccessaryValuesForASingleTrip();
                List<TravelDetails> allDetails = tdc.GetAllTravelDetails();
                tdcc.AddTravelDetails(tdc);
                int hours = 0;
                int kilometers = 0;
                foreach (var item in allDetails)
                {
                    hours += item.GetSumOfHours();
                    kilometers += item.GetSumOfKilometers();
                }
                var syote = kilometers;
                if (syote > 0)
                {
                    int syötetytKilometrit = syote;

                    Console.WriteLine("syötä matkan kesto tunteina");
                    //TODO: fix argumentoutofrangeexception
                    var matkanKestoSyote = hours;
                    if (matkanKestoSyote > 0)
                    {
                        int MatkanKesto = matkanKestoSyote;

                        if (syötetytKilometrit <= 14)
                        {
                            Console.WriteLine("Alle 15 km matkasta ei saa korvausta");
                        }
                        else
                        {

                            Console.WriteLine();

                            decimal maksettavaKorvaus = syötetytKilometrit * kilometriKorvaus;

                            decimal paivaraha = 0;

                            if (MatkanKesto >= 6 && MatkanKesto <= 9)
                            {
                                Console.WriteLine("päivärahasi on " + puolipäiväRaha + " euroa");
                                decimal korvausYhteensä = maksettavaKorvaus + puolipäiväRaha; // matkan korvaus yhteensä (kilometrit + päiväraha)
                                Console.WriteLine("Kilometrikorvauksesi on " + maksettavaKorvaus + " Euroa");
                                Console.WriteLine();
                                Console.WriteLine("korvauksesi yhteensä on  " + korvausYhteensä + " Euroa");
                                paivaraha += puolipäiväRaha;

                            }
                            else if (MatkanKesto >= 9)
                            {
                                Console.WriteLine("päivärahasi on " + kokopäiväRaha + " euroa");
                                decimal korvausYhteensä = maksettavaKorvaus + kokopäiväRaha; // matkan korvaus yhteensä (kilometrit + päiväraha)
                                Console.WriteLine("Kilometrikorvauksesi on " + maksettavaKorvaus + " Euroa");
                                Console.WriteLine();
                                Console.WriteLine("korvauksesi yhteensä on  " + korvausYhteensä + " Euroa");
                                paivaraha += kokopäiväRaha;


                            }
                            else if (MatkanKesto <= 5)
                            {
                                Console.WriteLine("päivärahasi on 0 euroa");

                                Console.WriteLine("Kilometrikorvauksesi on " + maksettavaKorvaus + " Euroa");
                                Console.WriteLine();
                                Console.WriteLine("korvauksesi yhteensä on  " + maksettavaKorvaus + " Euroa");


                            }
                            decimal lisattavakorvaus = maksettavaKorvaus + paivaraha;
                            korvaukset.Add(lisattavakorvaus);
                        }
                    }

                }
                continue; // jatkaa, jotta maksuja voi myös tarkastella

            }

            if (mainMenu1 == "2")
            {
                // tarkastele maksuja
                Console.WriteLine("=== Lista maksuista ===");
                Console.WriteLine("Matka: " + /*sijanti +*/ Environment.NewLine + "Matkaan kulunut aika: "
                /*+ lähtöaika*/ + ", " /*+ saapumisaika*/ + Environment.NewLine + "Matkan pituus: " +
                /*syötetytKilometrit +*/ Environment.NewLine + "Maksettava korvaus: " /*+ maksettavaKorvaus*/
                + Environment.NewLine);

                // luo satunnaisen koodin laskulle, ei välttämättä tarpeellinen laisinkaan :D
                // Random paymentID = new Random();
                int id = 0;
                foreach (var item in tdcc.GetAll())
                {
                    foreach (var item2 in item.GetAllTravelDetails())
                    {
                        Console.WriteLine("sijainti "+item2.GetSumOfHours()+" "+item2.GetSumOfKilometers()+" "+korvaukset[id]);
                        id++;
                    }
                }

                continue;
            }

            if (mainMenu1 == "3")
            {
                Console.WriteLine("Kilometrikorvausta maksetaan vain 15 km ylittävästä matkasta." + Environment.NewLine
                + "Korvausta maksetaan 0,46 euroa kilometriltä." + Environment.NewLine
                + "Kilometrikorvauksen lisäksi matkasta voidaan maksaa osapäivä- tai kokopäivärahaa." + Environment.NewLine
                + "Osapäivärahaa maksetaan yli 6 tunnin matkasta 20 euroa." + Environment.NewLine
                + "Kokopäivärahaa maksetaan yli 10 tunnin matkasta 45 euroa." + Environment.NewLine);
                continue;
            }

            else
            {
                Console.WriteLine("Syötettä ei voida hyväksyä." + Environment.NewLine);
                continue; // restart the loop
            }
        }
    }
}