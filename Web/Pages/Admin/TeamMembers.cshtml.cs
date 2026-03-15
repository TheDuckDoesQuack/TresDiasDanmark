using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages;

[Authorize]
public class TeamMembers : PageModel
{
    public void OnGet()
    {
        
    }
}