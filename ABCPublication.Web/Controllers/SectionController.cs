using ABCPublication.Web.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ABCPublication.Web.Controllers
{
    public class SectionController : Controller
    {
        private readonly IJsonService _jsonService;

        public SectionController(IJsonService jsonService)
        {
            _jsonService = jsonService;
        }

        public async Task<IActionResult> Preface()
        {
            var jsonData = _jsonService.LoadJsonData();
            return View(jsonData.Preface);
        }

        [ActionName("table-of-contents")]
        public async Task<IActionResult> TableOfContents()
        {
            var jsonData = _jsonService.LoadJsonData();

            return View(jsonData.TableOfContents);
        }

        [ActionName("a-scandal-in-bohemia")]
        public async Task<IActionResult> ScandalInBohemia()
        {
            var jsonData = _jsonService.LoadJsonData();

            return View(jsonData.AScandalInBohemia);
        }

        [ActionName("bohemia-chapter-1")]
        public async Task<IActionResult> BohamiaChapter1()
        {
            var jsonData = _jsonService.LoadJsonData();

            return View(jsonData.BohemiaChapter1);
        }

        [ActionName("bohemia-chapter-2")]
        public async Task<IActionResult> BohamiaChapter2()
        {
            var jsonData = _jsonService.LoadJsonData();

            return View(jsonData.BohemiaChapter2); 
        }

        [ActionName("bohemia-chapter-3")]
        public async Task<IActionResult> BohamiaChapter3()
        {
            var jsonData = _jsonService.LoadJsonData();

            return View(jsonData.BohemiaChapter3);
        }

    }
}