namespace Kilometrikorvaus
{
    internal class TravelDetails
    {
        private string timeOfLeaving = "01/01/1999 00:00";
        private string timeOfReturning = "01/01/1999 00:00";
        private List<int> kilometersTravelled = new();
        private List<int> hoursTravelled = new();
        private string dateOfInput = "";
        public List<List<int>> TripLengthVariablesInAList()
        {
            List<List<int>> trip = new()
            {
                kilometersTravelled,
                hoursTravelled
            };
            return trip;
        }
        public void AddKilometersTravelledInAList(int kilometers)
        {
            kilometersTravelled.Add(kilometers);
        }
        public void AddHoursTravelledInAList(int hours)
        {
            hoursTravelled.Add(hours);
        }
        public string GetTimeOfLeaving()
        {
            return timeOfLeaving;
        }
        public void SetTimeOfLeaving(string timeOfLeaving)
        {
            this.timeOfLeaving = timeOfLeaving;
        }
        public string GetTimeOfReturning()
        {
            return timeOfReturning;
        }
        public void SetTimeOfReturning(string timeOfReturning)
        {
            this.timeOfReturning = timeOfReturning;
        }
        public void SetDateOfInput()
        {
            dateOfInput = DateTime.Now.ToShortDateString();
        }
        public string GetDateOfInput()
        {
            return dateOfInput;
        }
    }
}
