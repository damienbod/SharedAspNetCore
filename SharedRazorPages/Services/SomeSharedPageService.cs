namespace SharedRazorPages.Services;

public class SomeSharedPageService
{
    public static List<string> GetData()
    {
        return new List<string> { "data from shared api", "more data" };
    }
}
