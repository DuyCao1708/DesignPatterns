namespace Examples.Patterns.Structural.Decorator;

public class SwordDecorator : CharacterDecorator
{
    public SwordDecorator(ICharacter character) : base(character) { }

    public override CharacterStatus GetStatus()
    {
        var status = _character.GetStatus();
        return new CharacterStatus(status.Attack + 10, status.Defense, status.Magic);
    }
}
