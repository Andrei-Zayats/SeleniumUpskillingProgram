using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace TestUI.Core;
public static class Browser
{
    public static WebDriver GetWebDriver()
    {
        switch (Environment.GetEnvironmentVariable("BROWSER")?.ToLower())
        {
            case "firefox":
                return new FirefoxDriver();
            case "edge":
                return new EdgeDriver();
            default:
                return new ChromeDriver();
        }
    }
}