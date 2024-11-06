using OpenQA.Selenium;
using NUnitTestUI.Core;

namespace NUnitTestUI.Pages;
public class BasePage
{
    protected readonly IWebDriver Driver;
    
    protected BasePage()
    {
        Driver = Browser.GetWebDriver();
        MaximizePage();
    }
    
    protected void OpenUrl(string url)
    {
        Driver.Navigate().GoToUrl(url);
    }
    
    private void MaximizePage()
    {
        Driver.Manage().Window.Maximize();
    }
    
    public void ClosePage()
    {
        Driver.Close();
        Driver.Dispose();
    }
}