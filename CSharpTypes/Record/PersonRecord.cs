namespace CSharpTypes.Record;

public record PersonRecord
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public record PersonRecord2(int Id, string FirstName, string LastName) 
{
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
};
