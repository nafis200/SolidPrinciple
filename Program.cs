

public interface ICourse
{
    public void Access();
}

public class JIPCourse : ICourse
{
    // authentication not need

    public string authentication{get;set;}

    public void Access()
    {
        Console.WriteLine("Accessing JIPC Course");
    }
}

public class BootCampCourse : ICourse
{
    public void Access()
    {
        Console.WriteLine("Accessing BootCamp Course");
    }
}
class Program
{
    static void Main(string[] args)
    {

    }

}