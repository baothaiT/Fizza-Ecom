using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thinh_Ecom.Data;

namespace Thinh_Ecom.Controllers.ClientPage
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AboutController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: AboutController
        [Route("about")]
        public ActionResult Index()
        {
            return View();
        }

        
    }
}
