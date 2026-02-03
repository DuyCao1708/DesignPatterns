namespace Examples.Patterns.Structural.Facade;

public class HomeTheaterFacade
{
    private LightControl _lightControl;
    private SoundControl _soundControl;
    private TelevisionControl _televisionControl;

    public HomeTheaterFacade(
        LightControl lightControl,
        SoundControl soundControl,
        TelevisionControl televisionControl)
    {
        _lightControl = lightControl;
        _soundControl = soundControl;
        _televisionControl = televisionControl;
    }

    public void StartMovieSession()
    {
        _televisionControl.TurnOn();
        _soundControl.TurnOn();
        _soundControl.SetVolume(75);
        _televisionControl.SetHDMIChannel(1);
        _lightControl.Dim();
    }
}
