using TestUI.Pages;

namespace TestUI.Tests;

public class AddRemoveElementsTests
{
    private AddRemoveElements AddRemoveElementsPage;
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddElementsTest()
    {
        const int elementsAmount = 5;

        AddRemoveElementsPage = new AddRemoveElements();
        AddRemoveElementsPage.PageIsLoaded();
        AddRemoveElementsPage.AddNewElement(elementsAmount);
        AddRemoveElementsPage.ValidateElementsAmount(elementsAmount);
        AddRemoveElementsPage.ClosePage();
    }
    
    [Test]
    public void DeleteElementsTest()
    {
        const int totalElementsAmount = 3;
        const int deleteElementsAmount = 2;

        AddRemoveElementsPage = new AddRemoveElements();
        AddRemoveElementsPage.PageIsLoaded();
        AddRemoveElementsPage.AddNewElement(totalElementsAmount);
        AddRemoveElementsPage.DeleteElement(deleteElementsAmount);
        AddRemoveElementsPage.ValidateElementsAmount(totalElementsAmount - deleteElementsAmount);
        AddRemoveElementsPage.ClosePage();
    }

    [TearDown]
    public void TearDown()
    {
    }
}