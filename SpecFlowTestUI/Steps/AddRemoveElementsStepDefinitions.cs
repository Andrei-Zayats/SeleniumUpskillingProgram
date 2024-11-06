using SpecFlowTestUI.Pages;

namespace SpecFlowTestUI.Steps;

[Binding]
public class AddRemoveElementsStepDefinitions
{
    private AddRemoveElements? _addRemoveElementsPage;
    
    [Given(@"user open Add Remove page")]
    public void GivenUserOpenAddRemovePage()
    {
        _addRemoveElementsPage = new AddRemoveElements();
        _addRemoveElementsPage.PageIsLoaded();
    }

    [When(@"user add '(.*)' elements on page")]
    public void WhenUserAddElementsOnPage(int elementsAmount)
    {
        _addRemoveElementsPage?.AddNewElement(elementsAmount);
    }

    [Then(@"'(.*)' elements on page")]
    public void ThenElementsWasAddedOnPage(int elementsAmount)
    {
        _addRemoveElementsPage?.ValidateElementsAmount(elementsAmount);
    }

    [Then(@"user close Add Remove page")]
    public void ThenUserCloseAddRemovePage()
    {
        _addRemoveElementsPage?.ClosePage();
    }

    [When(@"user delete '(.*)' elements on page")]
    public void WhenUserDeleteElementsOnPage(int elementsAmount)
    {
        _addRemoveElementsPage?.DeleteElement(elementsAmount);
    }
}