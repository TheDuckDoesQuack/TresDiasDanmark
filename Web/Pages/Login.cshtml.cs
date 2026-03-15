using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Admin;

public class Login : PageModel
{
    [BindProperty] [Required] public string Username { get; set; } = "";

    [BindProperty] [Required] public string Password { get; set; } = "";
    
    public IActionResult OnGet()
    {
        if (User.Identity?.IsAuthenticated == true)
        {
            return RedirectToPage("/Admin/Weekends");
        }

        return Page();
    }

    public IActionResult OnPost()
    {
        if (Username == "admin" && Password == "password")
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, Username)
            };

            var identity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            var principal = new ClaimsPrincipal(identity);

            HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal
            );

            return RedirectToPage("/Admin/Weekends");
        }

        ModelState.AddModelError("", "Fejl i login forsøg");
        return Page();
    }
}
