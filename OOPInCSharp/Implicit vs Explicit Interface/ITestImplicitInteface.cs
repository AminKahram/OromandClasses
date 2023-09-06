namespace OOPInCSharp.Implicit_vs_Explicit_Interface;

internal interface ITestImplicitInteface
{
    public void Temp();
    void Test();
    
}
internal interface ITestImplicitInteface2
{
    public void Temp();

}
public class TestImplicitIntefaceImplemnet : ITestImplicitInteface
{
    public void Temp()
    {
        throw new NotImplementedException();
    }

    public void Test()
    {
        throw new NotImplementedException();
    }
}
public class TestExplicitIntefaceImplemnet : ITestImplicitInteface , ITestImplicitInteface2 
{
    void ITestImplicitInteface2.Temp()
    {
        throw new NotImplementedException();
    }
    void ITestImplicitInteface.Temp()
    {
        throw new NotImplementedException();
    }

    public void Test()
    {
        throw new NotImplementedException();
    }
}