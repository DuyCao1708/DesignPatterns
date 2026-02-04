namespace Examples.Patterns.Creational.Builder;

public class StandardPCBuilder : IPCBuilder
{
    private PC _pc = new PC();

    public IPCBuilder SetCPU()
    {
        _pc.CPU = "Intel i5";
        return this;
    }

    public IPCBuilder SetGPU()
    {
        _pc.GPU = "GTX 1660";
        return this;
    }

    public IPCBuilder SetRAM()
    {
        _pc.RAM = 16;
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
