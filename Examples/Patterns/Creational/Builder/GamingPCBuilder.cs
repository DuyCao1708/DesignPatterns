namespace Examples.Patterns.Creational.Builder;

public class GamingPCBuilder : IPCBuilder
{
    private PC _pc = new PC();

    public IPCBuilder SetCPU()
    {
        _pc.CPU = "Intel i9";
        return this;
    }

    public IPCBuilder SetGPU()
    {
        _pc.GPU = "RTX 4090";
        return this;
    }

    public IPCBuilder SetRAM()
    {
        _pc.RAM = 32;
        return this;
    }

    public void Reset()
    {
        _pc = new PC();
    }

    public PC GetPC()
    {
        return _pc;
    }
}
