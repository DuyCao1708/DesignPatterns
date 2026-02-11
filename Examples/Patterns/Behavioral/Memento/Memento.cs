namespace Examples.Patterns.Behavioral.Memento;

public class Memento
{
    private readonly EditorState _state;

    public Memento(EditorState state)
    {
        _state = state;
    }

    public EditorState GetState()
    {
        return _state;
    }
}
