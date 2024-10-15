using TestUI.Pages;

namespace TestUI.Tests;

[Parallelizable(scope: ParallelScope.Fixtures)]
public class DragAndDropTests
{
    private DragAndDrop? _dragAndDropPage;
        
    [Test]
    public void DragAndDropElementOnPageTest()
    {
        _dragAndDropPage = new DragAndDrop();
        _dragAndDropPage.PageIsLoaded();
        _dragAndDropPage.DragFirstElement();
        _dragAndDropPage.ValidateFirstElementName("B");
        _dragAndDropPage.ClosePage();
    }
}