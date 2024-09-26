using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestUI.Pages;

public class Login : BasePage
{
    public Login()
    {
        OpenUrl("https://the-internet.herokuapp.com/login");
    }
    
    public void PageIsLoaded()
    {
        new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(d => _driver.FindElement(By.CssSelector("div button")));
    }

    public void InputUserName(string userName)
    {
        _driver.FindElement(By.CssSelector("#username")).SendKeys(userName);
    }
    
    public void InputPassword(string password)
    {
        _driver.FindElement(By.CssSelector("#password")).SendKeys(password);
    }

    public void ClickLoginButton()
    {
        _driver.FindElement(By.XPath(".//*[@type='submit']")).Click();
    }
    
    public void ValidateFlashMessage(string message)
    {
        var flashMessage = _driver.FindElement(By.CssSelector("#flash"));
        StringAssert.Contains(message,flashMessage.Text, $"Expect '{message}' on page, but found '{flashMessage.Text}'");
    }
}