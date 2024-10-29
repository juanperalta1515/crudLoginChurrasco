using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crudLogin.Controllers
{
    [Authorize]
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public ActionResult Index()
        {
            return View("Index20");
        }

    }
}
