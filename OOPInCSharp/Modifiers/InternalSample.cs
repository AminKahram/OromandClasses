

namespace OOPInCSharp.Modifiers;

internal class InternalSample
{
    public InternalSample()
    {
        Print();
    }
    private void Print()
        => Console.WriteLine("ProtectedSample");
}
