namespace RoushTech.Website.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    [Route("/")]
    public class HomeController : Controller
    {
        [Route("About")]
        public Task<IActionResult> About()
        {
            return Task.FromResult<IActionResult>(this.View());
        }

        [Route("Contact")]
        public Task<IActionResult> Contact()
        {
            return Task.FromResult<IActionResult>(this.View());
        }

        [Route("/Error")]
        public Task<IActionResult> Error()
        {
            return Task.FromResult<IActionResult>(this.View());
        }

        [Route("Home")]
        public Task<IActionResult> Index()
        {
            return Task.FromResult<IActionResult>(this.View());
        }

        [Route("/")]
        public Task<IActionResult> Redirect()
        {
            return Task.FromResult<IActionResult>(this.Redirect("https://blog.roushtech.net"));
        }
    }
}
