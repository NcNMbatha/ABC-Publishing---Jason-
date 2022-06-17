using ABCPublication.Web.Services;
using NUnit.Framework;

namespace ABCPublication.Test.IntegrationTests
{
    public class JsonServiceTests
    {
        private JsonService _jsonService;

        [SetUp]
        public void SetUp()
        {
            _jsonService = new JsonService();
        }

        [Test]
        public void Given_JsonDocument_When_LoadingJsonData_Returns_True()
        {
            var expected = true;
            var jsonDataModel = _jsonService.LoadJsonData(); 
            var actual = _jsonService.Equals(jsonDataModel);

            Assert.AreEqual(expected, actual);
        }
    }
}
