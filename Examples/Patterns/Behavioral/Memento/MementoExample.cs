using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.Memento;

public class MementoExample : IPatternExample
{
    public string Name => "Memento";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        var editor = new Editor();
        var history = new History(editor);

        history.Save();
        editor.SetBrightness(75);
        Console.WriteLine($"Current state: Brightness - {editor.GetBrightness()}; Contrast - {editor.GetContrast()}; Filter - {editor.GetFilter()}");

        history.Save();
        editor.SetContrast(25);
        Console.WriteLine($"Current state: Brightness - {editor.GetBrightness()}; Contrast - {editor.GetContrast()}; Filter - {editor.GetFilter()}");

        history.Save();
        editor.SetFilter("Vintage");
        Console.WriteLine($"Current state: Brightness - {editor.GetBrightness()}; Contrast - {editor.GetContrast()}; Filter - {editor.GetFilter()}");

        Console.WriteLine("\nUndo those previous changes");
        history.Undo();
        Console.WriteLine($"Current state: Brightness - {editor.GetBrightness()}; Contrast - {editor.GetContrast()}; Filter - {editor.GetFilter()}");

        history.Undo();
        Console.WriteLine($"Current state: Brightness - {editor.GetBrightness()}; Contrast - {editor.GetContrast()}; Filter - {editor.GetFilter()}");

        history.Undo();
        Console.WriteLine($"Current state: Brightness - {editor.GetBrightness()}; Contrast - {editor.GetContrast()}; Filter - {editor.GetFilter()}");
    }
}
