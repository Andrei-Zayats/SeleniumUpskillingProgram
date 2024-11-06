using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace NUnitTestUI.Core;
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
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("headless");
                return new ChromeDriver(chromeOptions);
        }
    }
}