using TestUI.Pages;

namespace TestUI.Tests;

[Parallelizable(scope: ParallelScope.Fixtures)]
public class AddRemoveElementsTests
{
    private AddRemoveElements? _addRemoveElementsPage;

    [Test]
    public void AddElementsTest()
    {
        const int elementsAmount = 5;

        _addRemoveElementsPage = new AddRemoveElements();
        _addRemoveElementsPage.PageIsLoaded();
        _addRemoveElementsPage.AddNewElement(elementsAmount);
        _addRemoveElementsPage.ValidateElementsAmount(elementsAmount);
        _addRemoveElementsPage.ClosePage();
    }
    
    [Test]
    public void DeleteElementsTest()
    {
        const int totalElementsAmount = 3;
        const int deleteElementsAmount = 2;

        _addRemoveElementsPage = new AddRemoveElements();
        _addRemoveElementsPage.PageIsLoaded();
        _addRemoveElementsPage.AddNewElement(totalElementsAmount);
        _addRemoveElementsPage.DeleteElement(deleteElementsAmount);
        _addRemoveElementsPage.ValidateElementsAmount(totalElementsAmount - deleteElementsAmount);
        _addRemoveElementsPage.ClosePage();
    }
}