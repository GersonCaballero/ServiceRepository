using System.Threading.Tasks;
using Consultarte.Models.TokenAuth;
using Consultarte.Web.Controllers;
using Shouldly;
using Xunit;

namespace Consultarte.Web.Tests.Controllers
{
    public class HomeController_Tests: ConsultarteWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}