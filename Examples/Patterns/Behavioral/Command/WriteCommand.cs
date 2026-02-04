namespace Examples.Patterns.Behavioral.Command;

public class WriteCommand : IUndoableCommand
{
    private TextEditor _editor;
    private History _history;
    private readonly char _character;
    private string? _prevParagraph;

    public WriteCommand(TextEditor editor, History history, char character)
    {
        _editor = editor;
        _history = history;
        _character = character;
    }

    public void Execute()
    {
        _prevParagraph = _editor.Paragraph;
        _editor.Input(_character);
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
