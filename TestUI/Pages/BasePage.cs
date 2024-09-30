using OpenQA.Selenium;
using TestUI.Core;

namespace TestUI.Pages;
public class BasePage
{
    protected IWebDriver _driver;
    protected BasePage()
    {
        _driver = Browser.GetWebDriver();
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