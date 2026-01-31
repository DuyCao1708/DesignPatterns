using Examples.Enums;

namespace Examples.Interfaces;

public interface IPatternExample
{
    string Name { get; }
    PatternGroup Group { get; }
    void Run();
}
