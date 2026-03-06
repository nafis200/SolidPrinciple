<!-- solid -->

<!-- S == Single responsiblity Principle -->



public class Student
{
    public void ShowInfo()
    {
        Console.WriteLine("student Info");
    }

    public void AddStudents()
    {
        Console.WriteLine("Add student");
    }

    public void EnrollCourse()
    {
        Console.WriteLine("enrolled course");
    }

    public void Paytution()
    {
        Console.WriteLine("Tution Paid");
    }

    public void EmailNotification()
    {
        Console.WriteLine("EmailNotication");
    }
}


<!-- violet single responsibility prinicple -->

<!-- now solve this -->


public class Payment
{
    public void Paytution()
    {
        Console.WriteLine("Tution Paid");
    }
}

public class Notification
{
    public void EmailNotification()
    {
        Console.WriteLine("EmailNotication");
    }
}

public class Course
{
    public void EnrollCourse()
    {
        Console.WriteLine("enrolled course");
    }
}

public class Student
{
    public void ShowInfo()
    {
        Console.WriteLine("student Info");
    }

    public void AddStudents()
    {
        Console.WriteLine("Add student");
    }

}

<!-- Solve this -->


<!-- 2 open closed priciple -->