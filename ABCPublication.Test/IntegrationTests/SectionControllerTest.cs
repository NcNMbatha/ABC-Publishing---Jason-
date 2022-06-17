using ABCPublication.Web.Controllers;
using ABCPublication.Web.Services;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Threading.Tasks;

namespace ABCPublication.Test.IntegrationTests
{
    public class SectionControllerTest
    {
        private JsonService _jsonService;
        private SectionController _sectionController;

        [SetUp]
        public void Setup()
        {
            _jsonService = new JsonService();    
            _sectionController = new SectionController(new JsonService());
        }

        [Test]
        public async Task Given_()
        {
           var expected = _jsonService.LoadJsonData().BohemiaChapter1;
           var actual = await _sectionController.BohamiaChapter1() as ViewResult;

           Assert.AreEqual(expected,actual.Model);
        }
    }
}
