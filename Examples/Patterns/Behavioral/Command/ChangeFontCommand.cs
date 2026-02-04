namespace Examples.Patterns.Behavioral.Command;

public class ChangeFontCommand : IUndoableCommand
{
    private TextEditor _editor;
    private History _history;
    private readonly string _font;
    private string? _prevFont;

    public ChangeFontCommand(TextEditor editor, History history, string font)
    {
        _editor = editor;
        _history = history;
        _font = font;
    }

    public void Execute()
    {
        _prevFont = _editor.Font;
        _editor.SetFont(_font);
        _history.Push(this);
    }

    public void Unexecute()
    {
        if (_prevFont != null)
        {
            _editor.SetFont(_prevFont);
        }
    }
}
