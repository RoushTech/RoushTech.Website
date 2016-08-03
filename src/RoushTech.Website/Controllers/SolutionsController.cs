
namespace RoushTech.Website.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    [Route("Solutions")]
    public class SolutionsController : Controller
    {
        [Route("")]
        public Task<IActionResult> Index()
        {
            return Task.FromResult<IActionResult>(this.View());
        }

        [Route("Automation")]
        public Task<IActionResult> Automation()
        {
            return Task.FromResult<IActionResult>(this.View());
        }

        [Route("Infrastructure")]
        public Task<IActionResult> Infrastructure()
        {
            return Task.FromResult<IActionResult>(this.View());
        }

        [Route("Software")]
        public Task<IActionResult> Software()
        {
            return Task.FromResult<IActionResult>(this.View());
        }

        [Route("Virtualization")]
        public Task<IActionResult> Virtualization()
        {
            return Task.FromResult<IActionResult>(this.View());
        }
    }
}
