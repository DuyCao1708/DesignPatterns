namespace Examples.Patterns.Behavioral.Command;

public class DeleteCommand : IUndoableCommand
{
    private TextEditor _editor;
    private History _history;

    private string? _prevParagraph;

    public DeleteCommand(TextEditor editor, History history)
    {
        _editor = editor;
        _history = history;
    }

    public void Execute()
    {
        _prevParagraph = _editor.Paragraph;
        _editor.Backspace();
        _history.Push(this);
    }

    public void Unexecute()
    {
        if (_prevParagraph != null)
        {
            _editor.SetParagraph(_prevParagraph);
        }
    }
}
