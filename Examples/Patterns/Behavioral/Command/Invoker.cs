namespace Examples.Patterns.Behavioral.Command;

public class Invoker
{
    private ICommand _command;

    public Invoker(ICommand command)
    {
        _command = command;
    }

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.Execute();
    }
}
