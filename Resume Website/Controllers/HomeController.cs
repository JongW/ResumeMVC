using Microsoft.AspNetCore.Mvc;
using Resume_Website.Models;
using ResumeWebsite.Services;
using System.Diagnostics;

namespace Resume_Website.Controllers
{
    public class HomeController : Controller
    {

        private readonly IResumeService _resumeService;

        public HomeController(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        public async Task<IActionResult> Index(CancellationToken ct)
        {
            var model = await _resumeService.GetResumeAsync(ct);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
