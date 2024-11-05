using SpecFlowTestUI.Pages;

namespace SpecFlowTestUI.Steps;

[Binding]
public class DragAndDropStepDefinitions
{
    private DragAndDrop? _dragAndDropPage;
    
    [Given(@"user open Drag And Drop page")]
    public void GivenUserOpenDragAndDropPage()
    {
        _dragAndDropPage = new DragAndDrop();
        _dragAndDropPage.PageIsLoaded();
    }

    [Then(@"first element name is '(.*)'")]
    public void ThenFirstElementNameIs(string name)
    {
        _dragAndDropPage.ValidateFirstElementName(name);
    }

    [When(@"user drag first element")]
    public void WhenUserDragFirstElement()
    {
        _dragAndDropPage.DragFirstElement();
    }

    [Then(@"user close Drag And Drop page")]
    public void ThenUserCloseDragAndDropPage()
    {
        _dragAndDropPage.ClosePage();
    }
}