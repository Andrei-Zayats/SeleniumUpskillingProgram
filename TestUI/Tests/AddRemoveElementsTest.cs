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
    
    [TestCase(3, 3)]
    [TestCase(3, 2)]
    [TestCase(10, 6)]
    public void DeleteElementsTest(int totalElementsAmount, int deleteElementsAmount)
    {
        _addRemoveElementsPage = new AddRemoveElements();
        _addRemoveElementsPage.PageIsLoaded();
        _addRemoveElementsPage.AddNewElement(totalElementsAmount);
        _addRemoveElementsPage.ValidateElementsAmount(totalElementsAmount);
        _addRemoveElementsPage.DeleteElement(deleteElementsAmount);
        _addRemoveElementsPage.ValidateElementsAmount(totalElementsAmount - deleteElementsAmount);
        _addRemoveElementsPage.ClosePage();
    }
}