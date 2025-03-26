using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;
using PlayWright_Orders.Pages;

namespace PlayWright_Orders;

public class UnitTest : PageTest
{
    private readonly LoginPage _loginPage;
    
    [Fact]
    public async Task Test1()
    {
      
            await Page.GotoAsync("http://secure.smartbearsoftware.com/samples/testcomplete12/weborders/");
            LoginPage loginPage = new LoginPage(Page);
            await loginPage.Login();
    }
}