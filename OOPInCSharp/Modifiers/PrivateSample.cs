

namespace OOPInCSharp.Modifiers;

public class PrivateSample
{
    public PrivateSample()
    {
        Print();
    }
    private void Print()
        => Console.WriteLine("ProtectedSample");
}
