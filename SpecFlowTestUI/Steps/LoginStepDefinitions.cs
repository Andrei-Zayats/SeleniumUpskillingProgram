using SpecFlowTestUI.Pages;

namespace SpecFlowTestUI.Steps;

[Binding]
public class UserTryLoginStepDefinitions
{
    private Login _loginPage;
    
    [Given(@"user open login page")]
    public void GivenUserOpenLoginPage()
    {
        _loginPage = new Login();
    }

    [Then(@"user close login page")]
    public void ThenUserClosePageLogin()
    {
        _loginPage.ClosePage();
    }

    [Given(@"input user name (.*)")]
    public void GivenInputUserName(string userName)
    {
        _loginPage.InputUserName(userName);
    }

    [Given(@"input user password (.*)")]
    public void GivenInputUserPassword(string userPassword)
    {
        _loginPage.InputPassword(userPassword);
    }

    [When(@"click login button")]
    public void WhenClickLoginButton()
    {
        _loginPage.ClickLoginButton();
    }

    [Then(@"user get message (.*)")]
    public void ThenUserGetMessage(string expectedMessage)
    {
        _loginPage.ValidateFlashMessage(expectedMessage);
    }
}