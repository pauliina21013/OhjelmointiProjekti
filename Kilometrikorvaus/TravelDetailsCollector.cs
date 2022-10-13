namespace Kilometrikorvaus
{
    internal class TravelDetailsCollector
    {
        private List<TravelDetails> allTravelDetails = new();
        public void AddToTravelDetails(TravelDetails travelDetails)
        {
            allTravelDetails.Add(travelDetails);
        }
        public void CreateAnEmptyTravelDetailToTheList()
        {
            TravelDetails td = new();
            AddToTravelDetails(td);
        }
        public TravelDetails GetTheLatestTravelDetails()
        {
            if(allTravelDetails.Count == 0)
            {
                CreateAnEmptyTravelDetailToTheList();
            }
            return allTravelDetails[^1];
        }
        public List<TravelDetails> GetAllTravelDetails()
        {
            return allTravelDetails;
        }
        public void ReplaceTheLatestTravelDetails(TravelDetails td)
        {
            allTravelDetails[^1] = td;
        }
        public void InputAllTheNeccessaryValuesForASingleTrip()
        {
            TravelDetails td = new();
            td = GetTheLatestTravelDetails();
            while (true)
            {
                Console.WriteLine("Syötä yhden päivän kilometrit (kokonaislukuna): ");
                var kilometersForOneDay = Console.ReadLine();
                Console.WriteLine("Syötä yhden päivän matkustetut tunnit (1-24): ");
                var hoursForOneDay = Console.ReadLine();
                td.SetTravelDates();
                if(kilometersForOneDay != null && hoursForOneDay != null)
                {
                    td.AddHoursTravelledInAList(int.Parse(hoursForOneDay));
                    td.AddKilometersTravelledInAList(int.Parse(kilometersForOneDay));
                }
                Console.WriteLine("Syötitkö varmasti kaikki päivässä olleet kilometrit? (k/e)");
                var answerInput = Console.ReadLine();
                if(answerInput != null)
                {
                    if(answerInput.Equals("k"))
                    {
                        break;
                    }
                }
            }
        }
    }
}
