namespace Examples.Patterns.Creational.Builder;

public interface IPCBuilder
{
    public void Reset();
    public IPCBuilder SetGPU();
    public IPCBuilder SetCPU();
    public IPCBuilder SetRAM();
}
