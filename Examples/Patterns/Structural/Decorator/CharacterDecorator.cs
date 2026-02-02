namespace Examples.Patterns.Structural.Decorator;

public abstract class CharacterDecorator : ICharacter
{
    protected ICharacter _character;

    public CharacterDecorator(ICharacter character)
    {
        _character = character;
    }

    public abstract CharacterStatus GetStatus();
}
