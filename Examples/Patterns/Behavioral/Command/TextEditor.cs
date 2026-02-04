namespace Examples.Patterns.Behavioral.Command;

public class TextEditor
{
    private string _font { get; set; } = "Time New Roman";
    public string Font { get => _font; }
    private string _paragraph { get; set; } = "";
    public string Paragraph { get => _paragraph; }

    public void SetFont(string font)
    {
        _font = font;
    }

    public void Input(char character)
    {
        _paragraph += character;
    }

    public void SetParagraph(string paragraph)
    {
        _paragraph = paragraph;
    }

    public void Backspace()
    {
        _paragraph = Paragraph.Substring(0, Paragraph.Length - 1);
    }

    public void DisplayParagraph()
    {
        Console.WriteLine($"Font: {Font}; Paragraph: {Paragraph}");
    }
}
