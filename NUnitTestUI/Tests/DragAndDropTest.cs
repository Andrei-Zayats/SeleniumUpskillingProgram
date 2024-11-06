using NUnitTestUI.Pages;

namespace NUnitTestUI.Tests;

[Parallelizable(scope: ParallelScope.Fixtures)]
public class DragAndDropTests
{
    private DragAndDrop? _dragAndDropPage;
        
    [Test]
    public void DragAndDropElementOnPageTest()
    {
        _dragAndDropPage = new DragAndDrop();
        _dragAndDropPage.PageIsLoaded();
        _dragAndDropPage.ValidateFirstElementName("A");
        _dragAndDropPage.DragFirstElement();
        _dragAndDropPage.ValidateFirstElementName("B");
        _dragAndDropPage.DragFirstElement();
        _dragAndDropPage.ValidateFirstElementName("A");
        _dragAndDropPage.ClosePage();
    }
}