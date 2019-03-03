using Microsoft.AspNetCore.Antiforgery;
using ide2www.Controllers;

namespace ide2www.Web.Host.Controllers
{
    public class AntiForgeryController : ide2wwwControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
