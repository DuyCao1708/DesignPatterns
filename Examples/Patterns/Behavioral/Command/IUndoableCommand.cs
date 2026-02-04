namespace Examples.Patterns.Behavioral.Command;

public interface IUndoableCommand : ICommand
{
    public void Unexecute();
}
