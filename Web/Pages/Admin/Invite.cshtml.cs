using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages;

[Authorize]
public class Invite : PageModel
{
    public void OnGet()
    {
        
    }
}