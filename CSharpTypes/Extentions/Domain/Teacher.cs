namespace CSharpTypes.Extentions.Domain;

public class Teacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullName(Teacher teacher)
    {
        return $"{FirstName}, {LastName}";
    }
}
