namespace Examples.Patterns.Behavioral.Memento;

public class Editor
{
    private EditorState _state = new EditorState(50, 50, "None");

    public Memento CreateStateMemento()
    {
        return new Memento(_state);
    }

    public void Restore(Memento memento)
    {
        _state = memento.GetState();
    }

    public int GetBrightness()
    {
        return _state.Brightness;
    }

    public int GetContrast()
    {
        return _state.Contrast;
    }

    public string GetFilter()
    {
        return _state.Filter;
    }

    public void SetBrightness(int brightness)
    {
        _state = _state with { Brightness = brightness };
    }

    public void SetContrast(int contrast)
    {
        _state = _state with { Contrast = contrast };
    }

    public void SetFilter(string filter)
    {
        _state = _state with { Filter = filter };
    }
}
