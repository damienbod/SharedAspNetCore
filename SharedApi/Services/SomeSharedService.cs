namespace SharedApi.Services;

public class SomeSharedService
{
    public List<string> GetData()
    {
        return new List<string> { "data from shared api", "more data" };
    }
}
