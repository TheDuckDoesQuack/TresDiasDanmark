using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages;

[Authorize]
public class Weekends : PageModel
{
    public void OnGet()
    {
        
    }
}