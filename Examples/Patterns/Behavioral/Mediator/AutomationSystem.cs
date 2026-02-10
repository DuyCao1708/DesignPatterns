namespace Examples.Patterns.Behavioral.Mediator;

public class AutomationSystem : IMediator
{
    private AlarmClock _alarmClock;
    private CoffeeMachine _coffeeMachine;
    private Curtains _curtains;
    private SmartLights _smartLights;
    public AutomationSystem()
    {
        _alarmClock = new AlarmClock(this);
        _coffeeMachine = new CoffeeMachine(this);
        _curtains = new Curtains(this);
        _smartLights = new SmartLights(this);
    }

    public void SimulateGoodMorningRoutine()
    {
        _alarmClock.Ring();
    }

    public void Notify(SmartDevice device)
    {
        if (device == _alarmClock)
        {
            HandleAlarmClockNotify();
        }
        else if (device == _coffeeMachine)
        {
            HandleCoffeeMachineNotify();
        }
        else if (device == _curtains)
        {
            HandleCurtainsNotify();
        }
    }

    private void HandleAlarmClockNotify()
    {
        _coffeeMachine.Brew();
    }

    private void HandleCoffeeMachineNotify()
    {
        _curtains.Open();
    }

    private void HandleCurtainsNotify()
    {
        _smartLights.TurnOff();
    }
}
