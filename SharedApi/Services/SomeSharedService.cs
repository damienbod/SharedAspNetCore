namespace SharedApi.Services;

public class SomeSharedService
{
    public static List<string> GetData()
    {
        return new List<string> { "data from shared api", "more data" };
    }
}
