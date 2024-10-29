using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Build.Framework;

using Xunit.Sdk;

namespace crudLogin.Pages
{
    public class IndexModel : PageModel
    {
       
        public class InputModel
        {
           
            public string? Username { get; set; }

           
            public string? Password { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public void OnGet()
        {
            // Limpiar mensajes de error al cargar la página
            TempData["EmailError"] = null;
            TempData["PasswordError"] = null;
            TempData["ErrorMessage"] = null;
        }
    }
}
