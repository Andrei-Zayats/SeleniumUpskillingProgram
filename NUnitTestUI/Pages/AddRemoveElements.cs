using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestUI.Pages;
public class AddRemoveElements : BasePage 
{
    public AddRemoveElements()
    {
        OpenUrl("https://the-internet.herokuapp.com/add_remove_elements/");
    }
    
    public void PageIsLoaded()
    {
        new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(d => Driver.FindElement(By.CssSelector("div button")));
    }
    
    public void AddNewElement(int count)
    {
        var addElementButton = Driver.FindElement(By.CssSelector("div button"));
         for (int i = 0; i < count; i++)
         {
             addElementButton.Click();
         }
    }
    
    public void DeleteElement(int count)
    {
        var deleteButtons = Driver.FindElements(By.CssSelector("#elements button"));
        for (int i = 0; i < count; i++)
        {
            deleteButtons[i].Click();
        }
    }
    
    public void ValidateElementsAmount(int count)
    {
        var deleteButton = Driver.FindElements(By.CssSelector("#elements button"));
        Assert.That(deleteButton.Count, Is.EqualTo(count), $"Expect {count} elements on page, but found {deleteButton.Count}");

    }
}