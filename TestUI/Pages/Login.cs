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
        new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(d => Driver.FindElement(By.CssSelector("div button")));
    }

    public void InputUserName(string userName)
    {
        Driver.FindElement(By.CssSelector("#username")).SendKeys(userName);
    }
    
    public void InputPassword(string password)
    {
        Driver.FindElement(By.CssSelector("#password")).SendKeys(password);
    }

    public void ClickLoginButton()
    {
        Driver.FindElement(By.XPath(".//*[@type='submit']")).Click();
    }
    
    public void ValidateFlashMessage(string message)
    {
        var flashMessage = Driver.FindElement(By.CssSelector("#flash"));
        StringAssert.Contains(message,flashMessage.Text, $"Expect '{message}' on page, but found '{flashMessage.Text}'");
    }
}