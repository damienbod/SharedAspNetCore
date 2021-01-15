using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharedRazorPages.Pages
{
    public class SomePageModel : PageModel
    {
        private readonly ILogger<SomePageModel> _logger;

        public SomePageModel(ILogger<SomePageModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
