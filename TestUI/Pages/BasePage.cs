using OpenQA.Selenium;
using TestUI.Core;

namespace TestUI.Pages;

public class BasePage
{
    protected IWebDriver _driver;

    protected BasePage()
    {
        try
        {
            _driver ??= Browser.GetWebDriver(Environment.GetEnvironmentVariable("BROWSER"));
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine(e);
            _driver ??= Browser.GetWebDriver("CHROME");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        MaximizePage();
    }

    protected void OpenUrl(string url)
    {
        _driver.Navigate().GoToUrl(url);
    }

    public void MaximizePage()
    {
        _driver.Manage().Window.Maximize();
    }
    
    public void ClosePage()
    {
        _driver.Close();
        _driver.Dispose();
    }
}