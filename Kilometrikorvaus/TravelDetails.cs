namespace Kilometrikorvaus
{
    internal class TravelDetails
    {
        private string timeOfLeaving = "01/01/1999 00:00";
        private string timeOfReturning = "01/01/1999 00:00";
        private List<int> kilometersTravelled = new List<int>();
        private List<int> hoursTravelled = new List<int>();
        public List<List<int>> tripLengthVariablesInAList()
        {
            List<List<int>> trip = new List<List<int>>();
            trip.Add(kilometersTravelled);
            trip.Add(hoursTravelled);
            return trip;
        }
    }
}
