namespace Examples.Patterns.Structural.Decorator;

public class Warrior : ICharacter
{
    public CharacterStatus GetStatus()
    {
        return new CharacterStatus(0, 0, 0);
    }
}
