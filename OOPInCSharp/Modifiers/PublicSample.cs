namespace OOPInCSharp.Modifiers;

public class PublicSample
{
    public int Id { get; set; }
    public string? Name { get; set; }
    private InternalSample internalSample = new InternalSample();
}
