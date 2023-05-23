using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace wa3213123.Pages.Shared
{
    public class AuthModel : PageModel
    {
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost(string? returnUrl) 
        {
            var form = HttpContext.Request.Form;
            if (!form.ContainsKey("login") || !form.ContainsKey("password"))
                return BadRequest("Email и/или пароль не установлены");

            string email = form["login"];
            string password = form["password"];

            var db = new MaindbContext();
            var staff = db.Staffs 
        }
    }
}
