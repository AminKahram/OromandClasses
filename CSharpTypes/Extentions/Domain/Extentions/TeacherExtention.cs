namespace CSharpTypes.Extentions.Domain.Extentions;

public static class TeacherExtention
{
    public static string GetFullName(this Teacher teacher)
    {
        return $"{teacher.FirstName}, {teacher.LastName}";
    }
}
