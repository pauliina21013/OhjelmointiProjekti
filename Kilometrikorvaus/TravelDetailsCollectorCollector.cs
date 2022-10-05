using Kilometrikorvaus;

internal class TravelDetailsCollectorCollector
{
    private List<TravelDetailsCollector> travelDetailsCollectorsList = new();
    public void CreateNewTravelDetailsCollectorToList()
    {
        travelDetailsCollectorsList.Append(new TravelDetailsCollector());
    }
    public TravelDetailsCollector GetLatestTravelDetailsCollector()
    {
        if (travelDetailsCollectorsList.Count == 0)
        {
            CreateNewTravelDetailsCollectorToList();
        }
        return travelDetailsCollectorsList[^1];
    }
    public TravelDetailsCollector CreateAndGetLatest()
    {
        CreateNewTravelDetailsCollectorToList();
        return travelDetailsCollectorsList[^1];
    }
    public List<TravelDetailsCollector> GetAll()
    {
        return travelDetailsCollectorsList;
    }
    public void AddTravelDetails(TravelDetailsCollector tdc)
    {
        travelDetailsCollectorsList.Add(tdc);
    }
}