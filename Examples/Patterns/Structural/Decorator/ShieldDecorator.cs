namespace Examples.Patterns.Structural.Decorator;

public class ShieldDecorator : CharacterDecorator
{
    public ShieldDecorator(ICharacter character) : base(character) { }

    public override CharacterStatus GetStatus()
    {
        var status = _character.GetStatus();
        return new CharacterStatus(status.Attack, status.Defense + 10, status.Magic);
    }
}
