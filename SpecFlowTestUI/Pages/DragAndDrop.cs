using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowTestUI.Pages;

public class DragAndDrop : BasePage
{
    public DragAndDrop()
    {
        OpenUrl("https://the-internet.herokuapp.com/drag_and_drop");
    }
    
    public void PageIsLoaded()
    {
        new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(d => Driver.FindElement(By.Id("column-a")));
    }

    public void DragFirstElement()
    {
        var firstElement = Driver.FindElement(By.CssSelector("div.column"));
        var secondElement = Driver.FindElement(By.Id("column-b"));
        new Actions(Driver).ClickAndHold(firstElement)
            .MoveToElement(secondElement)
            .Release(secondElement)
            .Perform();
    }

    public void ValidateFirstElementName(string name)
    {
        var firstElement = Driver.FindElement(By.CssSelector("div.column"));
        firstElement.Text.Should().Be(name);
    }
}