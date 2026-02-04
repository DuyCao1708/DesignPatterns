using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.Command;

public class CommandExample : IPatternExample
{
    public string Name => "Command";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        var editor = new TextEditor();
        var history = new History();

        ICommand command = new WriteCommand(editor, history, 'H');
        var invoker = new Invoker(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new WriteCommand(editor, history, 'e');
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new WriteCommand(editor, history, 'l');
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new WriteCommand(editor, history, 'l');
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new WriteCommand(editor, history, 'o');
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new ChangeFontCommand(editor, history, "Arial");
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new DeleteCommand(editor, history);
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new DeleteCommand(editor, history);
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new DeleteCommand(editor, history);
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new DeleteCommand(editor, history);
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        command = new UndoCommand(history);
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        invoker.ExecuteCommand();
        editor.DisplayParagraph();

        invoker.ExecuteCommand();
        editor.DisplayParagraph();
    }
}
