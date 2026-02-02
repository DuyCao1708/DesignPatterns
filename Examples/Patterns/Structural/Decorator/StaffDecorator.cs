namespace Examples.Patterns.Structural.Decorator;

public class StaffDecorator : CharacterDecorator
{
    public StaffDecorator(ICharacter character) : base(character) { }

    public override CharacterStatus GetStatus()
    {
        var status = _character.GetStatus();
        return new CharacterStatus(status.Attack, status.Defense, status.Magic + 10);
    }
}
