using NUnitTestUI.Pages;

namespace NUnitTestUI.Tests;

[Parallelizable(scope: ParallelScope.Fixtures)]
public class LoginTests
{
    private Login? _loginPage;

    [TestCase("tomsmith", "SuperSecretPassword!", "You logged into a secure area!")]
    [TestCase("tomsmith", "SecretPassword", "Your password is invalid!")]
    [TestCase("tom", "SecretPassword", "Your username is invalid!")]
    public void UserTryLogin(string userName, string userPassword, string expectedMessage)
    {
        _loginPage = new Login();
        _loginPage.InputUserName(userName);
        _loginPage.InputPassword(userPassword);
        _loginPage.ClickLoginButton();
        _loginPage.ValidateFlashMessage(expectedMessage);
        _loginPage.ClosePage();
    }
}