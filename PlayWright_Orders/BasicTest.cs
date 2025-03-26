using Microsoft.Playwright;

namespace PlayWright_Orders;

public class BasicTest 
{
    [Fact]
    public async Task Test1()
    {
       using var playwright = await Playwright.CreateAsync();
         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
         {
              Headless = false
         });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("http://secure.smartbearsoftware.com/samples/testcomplete12/weborders/");
           
            await page.FillAsync("input[name='ctl00$MainContent$username']", "Tester");
            await page.FillAsync("input[name='ctl00$MainContent$password']", "test");
            await page.ClickAsync("input[name='ctl00$MainContent$login_button']");
            await page. ScreenshotAsync(new PageScreenshotOptions 
                { Path = "screenshot.png" });
    }
}