namespace Examples.Patterns.Creational.Builder;

public class Director
{
    private IPCBuilder _builder;
    public Director(IPCBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IPCBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder.Reset();
        _builder.SetCPU().SetGPU().SetRAM();
    }
}
