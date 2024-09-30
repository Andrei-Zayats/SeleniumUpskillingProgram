using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestUI.Pages;
public class AddRemoveElements : BasePage 
{
    public AddRemoveElements()
    {
        OpenUrl("https://the-internet.herokuapp.com/add_remove_elements/");
    }
    public void PageIsLoaded()
    {
        new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(d => _driver.FindElement(By.CssSelector("div button")));
    }
    public void AddNewElement(int count)
    {
        var addElementButton = _driver.FindElement(By.CssSelector("div button"));
         for (int i = 0; i < count; i++)
         {
             addElementButton.Click();
         }
    }
    public void DeleteElement(int count)
    {
        var deleteButton = _driver.FindElements(By.CssSelector("#elements button"));
        for (int i = 0; i < count; i++)
        {
            deleteButton[i].Click();
            Assert.That(_driver.FindElements(By.CssSelector("#elements button")).Count, Is.EqualTo(count - i), $"Expect {count} elements on page, but found {deleteButton.Count}");
        }
    }
    public void ValidateElementsAmount(int count)
    {
        var deleteButton = _driver.FindElements(By.CssSelector("#elements button"));
        Assert.That(deleteButton.Count, Is.EqualTo(count), $"Expect {count} elements on page, but found {deleteButton.Count}");

    }
}