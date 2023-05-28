namespace SharedRazorPages.Services;

public class SomeSharedPageService
{
    public List<string> GetData()
    {
        return new List<string> { "data from shared api", "more data" };
    }
}
