using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebsiteRazor.Areas.Identity.Data;

namespace MyWebsiteRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, SignInManager<ApplicationUser> signinManager)
        {
            _signinManager = signinManager;
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            if (!_signinManager.IsSignedIn(User))
            {
                return LocalRedirect("/Identity/Account/Login");
            }

            return Page();
        }
    }
}