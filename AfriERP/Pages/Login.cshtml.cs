using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class LoginModel : PageModel
{
    [BindProperty]
    public required string Username { get; set; }

    [BindProperty]
    public required string Password { get; set; }

    public IActionResult OnPost()
    {
        if (Username == "admin" && Password == "1234")
        {
            return RedirectToPage("/Index");
        }

        ModelState.AddModelError(string.Empty, "Invalid username or password");
        return Page();
    }
}
