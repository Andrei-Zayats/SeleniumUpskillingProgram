using TestUI.Pages;

namespace TestUI.Tests;
public class LoginTests
{
    private Login? _loginPage;

    [Test]
    public void LoginFailed()
    {
        _loginPage = new Login();
        _loginPage.InputUserName("");
        _loginPage.InputPassword("");
        _loginPage.ClickLoginButton();
        _loginPage.ValidateFlashMessage("Your username is invalid!");
        _loginPage.ClosePage();
    }
    
    [Test]
    public void LoginSuccessful()
    {
        _loginPage = new Login();
        _loginPage.InputUserName("tomsmith");
        _loginPage.InputPassword("SuperSecretPassword!");
        _loginPage.ClickLoginButton();
        _loginPage.ValidateFlashMessage("You logged into a secure area!");
        _loginPage.ClosePage();
    }
}