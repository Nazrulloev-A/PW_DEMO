using Microsoft.Playwright;

namespace PlayWright_Orders.Pages;

public class LoginPage
{
    private IPage _page;
    public LoginPage(IPage page)
    {
        _page = page;
    }
    
    private ILocator username => _page.Locator("input[name='ctl00$MainContent$username']");
    private ILocator password => _page.Locator("input[name='ctl00$MainContent$password']");
    private ILocator loginButton => _page.Locator("input[name='ctl00$MainContent$login_button']");
    private ILocator welcomeMessage => _page.Locator("text=Welcome, Tester!");

    public async Task Login()
    {
        await username.FillAsync("Tester");
        await password.FillAsync("test");
        await loginButton.ClickAsync();
      
    }
}