using TestUI.Pages;

namespace TestUI.Tests;

public class LoginTests
{
    private Login LoginPage;
    
    [Test]
    public void LoginFailed()
    {
        LoginPage = new Login();
        LoginPage.InputUserName("");
        LoginPage.InputPassword("");
        LoginPage.ClickLoginButton();
        LoginPage.ValidateFlashMessage("Your username is invalid!");
        LoginPage.ClosePage();
    }
    
    [Test]
    public void LoginSuccessful()
    {
        LoginPage = new Login();
        LoginPage.InputUserName("tomsmith");
        LoginPage.InputPassword("SuperSecretPassword!");
        LoginPage.ClickLoginButton();
        LoginPage.ValidateFlashMessage("You logged into a secure area!");
        LoginPage.ClosePage();
    }
}