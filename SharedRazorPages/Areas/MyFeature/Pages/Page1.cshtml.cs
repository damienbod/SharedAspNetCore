using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedRazorPages.Services;

namespace SharedRazorPages.MyFeature.Pages;

public class Page1Model : PageModel
{
    private readonly SomeSharedPageService _someSharedPageService;

    public Page1Model(SomeSharedPageService someSharedPageService)
    {
        _someSharedPageService = someSharedPageService;
    }

    public List<string> Data = new();

    public void OnGet()
    {
        Data = _someSharedPageService.GetData();
    }
}
