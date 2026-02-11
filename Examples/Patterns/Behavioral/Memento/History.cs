namespace Examples.Patterns.Behavioral.Memento;

public class History
{
    private readonly Editor _editor;
    private Stack<Memento> _mementos = new Stack<Memento>();

    public History(Editor editor)
    {
        _editor = editor;
    }

    public void Save()
    {
        _mementos.Push(_editor.CreateStateMemento());
    }

    public void Undo()
    {
        if (_mementos.Count == 0) return;

        var memento = _mementos.Pop();

        _editor.Restore(memento);
    }
}
