using System.Web.Mvc;
using ALM.Demo.Controllers;
using ALM.Demo.Models.Home;
using Xunit;

namespace ALM.Demo.Tests
{
    public class HomeController_Index_Tests
    {
        private readonly ActionResult _result;

        public HomeController_Index_Tests()
        {
            _result = new HomeController().Index();
        }

        [Fact]
        public void Returns_a_ViewResult()
        {
            Assert.IsAssignableFrom<ViewResult>(_result);
        }

        [Fact]
        public void Passes_an_IndexModel_to_the_View()
        {
            var viewResult = (ViewResult)_result;
            Assert.IsAssignableFrom<IndexModel>(viewResult.Model);
        }

        [Fact]
        public void Puts_a_Message_and_Version_on_the_Model()
        {
            var viewResult = (ViewResult)_result;
            var model = (IndexModel)viewResult.Model;
            Assert.Equal(string.Format("Hello world from Tests"), model.Message);
            Assert.NotNull(model.Version);
        }
    }
}
