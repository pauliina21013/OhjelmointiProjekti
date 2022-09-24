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
    }
}
