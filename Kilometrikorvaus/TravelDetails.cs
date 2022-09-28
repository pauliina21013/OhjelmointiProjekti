namespace Kilometrikorvaus
{
    internal class TravelDetails
    {
        private string timeOfLeaving = "01/01/1999 00:00";
        private string timeOfReturning = "01/01/1999 00:00";
        private List<int> kilometersTravelled = new();
        private List<int> hoursTravelled = new();
        private List<string> travelDates = new();
        //TODO: tähän lista joka pitää sisällään kaikki poikkeukset listassa
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
        public void SetTravelDates()
        {
            Console.WriteLine("Syötä lähdön päivä");
            var travelDate = Console.ReadLine();
            Console.WriteLine("Syötä lähdön kuukausi");
            var travelMonth = Console.ReadLine();
            Console.WriteLine("Syötä lähdön vuosi");
            var travelYear = Console.ReadLine();
            Console.WriteLine("Syötä lähdön tunti");
            var travelHour = Console.ReadLine();
            Console.WriteLine("Syötä lähdön minuutti");
            var travelMinute = Console.ReadLine();
            if(travelDate != null && travelMonth != null && travelYear != null && travelHour != null && travelMinute != null)
            {
                string formattedDate = "";
                //travelDate checks
                if(travelDate.Length < 2)
                {
                    formattedDate += "0" + travelDate + "/";
                }
                else
                {
                    formattedDate += travelDate + "/";
                }
                //travelMonth checks
                if(travelMonth.Length < 2)
                {
                    formattedDate += "0" + travelMonth + "/";
                }
                else 
                {
                    formattedDate += travelMonth + "/";
                }
                //travelYear checks
                if(travelYear.Length < 2)
                {
                    formattedDate += "0" + travelYear + " ";
                }
                else
                {
                    formattedDate = travelYear + " ";
                }
                //travel hour time checks
                if (travelHour.Length < 2)
                {
                    formattedDate += "0" + travelHour + ":";
                }
                else
                {
                    formattedDate = travelHour + ":";
                }
                //travel minute time checks
                if (travelMinute.Length < 2)
                {
                    formattedDate += ":" + "0" + travelMinute;
                }
                else
                {
                    formattedDate = ":" + travelMinute;
                }
                travelDates.Add(formattedDate);
            }
        }
        //TODO: peräkärrypoikkeukset yms. tähän omana funktionaan joka kysyy ne kaikki
    }
}
