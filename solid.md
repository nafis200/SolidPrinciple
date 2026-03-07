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



public interface INotification
{
    void send();
    void log();
    void save();
}

public class EmailNotification : INotification
{
    public void send()
    {
        Console.WriteLine("Email Send");
    }
    public void log()
    {
        Console.WriteLine("Email log");
    }

    public void save()
    {
       Console.WriteLine("Email Save");   
    }
}


public class SMSNotification : INotification
{
      public void send()
    {
        Console.WriteLine("Sms Send");
    }
    public void log()
    {
        Console.WriteLine("Sms log");
    }

    public void save()
    {
       Console.WriteLine("Sms Save");   
    }
}

public class whatsAppNotification : INotification
{
    public void send()
    {
        Console.WriteLine("WhatsApp Send");
    }
    public void log()
    {
        Console.WriteLine("WhatsApp log");
    }

    public void save()
    {
       Console.WriteLine("WhatsApp Save");   
    }
}


public class PushNotification : INotification
{
    public void send()
    {
        Console.WriteLine("Push Send");
    }
    public void log()
    {
        Console.WriteLine("Push log");
    }

    public void save()
    {
       Console.WriteLine("Push Save");   
    }
}


public class NotificationContext
{
    private INotification notification;

    public NotificationContext(INotification notification)
    {
        this.notification = notification;
    }

    public void process()
    {
        notification.send();
        notification.log();
        notification.save();
    }
}



class Program
{
    static void Main(string[] args)
    {
       
       INotification Emailnotification = new EmailNotification();


     NotificationContext notificationContext = new NotificationContext(Emailnotification);

     notificationContext.process();


    //    Emailnotification.send();
    //    Emailnotification.log();
    //    Emailnotification.save();

       INotification Smsnotification = new SMSNotification();

       notificationContext = new NotificationContext(Smsnotification);
       notificationContext.process();

    //    Smsnotification.send();
    //    Smsnotification.log();
    //    Smsnotification.save();
     
       INotification whatsAppNotication = new whatsAppNotification();

       notificationContext = new NotificationContext(whatsAppNotication);

       notificationContext.process();

       INotification pushnotification = new PushNotification();
       notificationContext = new NotificationContext(pushnotification);

       notificationContext.process();

       


    //    whatsAppNotication.send();

    //    whatsAppNotication.log();

    //    whatsAppNotication.save();

    }
}


<!-- D == dependency inversion principle -->



using System;

public class Student
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}

public class StudentRepository
{
    public void AddStudent(Student student)
    {
        Console.WriteLine($"Student Name: {student.Name}");
    }
}
 
public class StudentService{
    private StudentRepository studentRepository;

    public StudentService(StudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    public void AddStudent(Student student)
    {
          studentRepository.AddStudent(student);
    }


}

class Program
{
    static void Main(string[] args)
    {
      StudentRepository studentRepository = new StudentRepository();

      StudentService studentService = new StudentService(studentRepository);

      Student student = new Student
      {
          Name = "nafis",
          Email = "n@gmail.com",
          Phone = "019xxxxx"
      };

      studentService.AddStudent(student);
    }
}


<!-- solve dependency inversion principle -->


using System;

public class Student
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Id { get; set; }
}

public interface IStudentRepository
{
    void AddStudent(Student student);
    void UpdateStudent(Student student);

    void DeleteStudent(int Id);
}

public class StudentRepository : IStudentRepository
{
    public void AddStudent(Student student)
    {
        Console.WriteLine($"Student Name: {student.Name}");
    }
    public void UpdateStudent(Student student)
    {
        Console.WriteLine($"Student Name: {student.Name}");
    }
    public void DeleteStudent(int Id)
    {
        Console.WriteLine($"Student {Id} is delete");
    }
}

public interface IStudentService
{
    void AddStudent(Student student);

    void UpdateStudent(Student student);

    void DeleteStudent(int Id);
}

public class StudentService : IStudentService
{
    private IStudentRepository studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    public void AddStudent(Student student)
    {
        studentRepository.AddStudent(student);
    }

    public void UpdateStudent(Student student)
    {
        studentRepository.UpdateStudent(student);
    }
    public void DeleteStudent(int Id)
    {
        studentRepository.DeleteStudent(Id);
    }


}

class Program
{
    static void Main(string[] args)
    {
        IStudentRepository studentRepository = new StudentRepository();

        IStudentService studentService = new StudentService(studentRepository);

        Student student = new Student
        {
            Name = "nafis",
            Email = "n@gmail.com",
            Phone = "019xxxxx"
        };

        studentService.AddStudent(student);
        studentService.UpdateStudent(student);
        studentService.DeleteStudent(10);
    }
}


<!-- Liskov substitution principle -->

<!-- child gulo er implementation difference beshi hoye jay -->



public interface IShape
{
    double Area();
}

public class Rectangle : IShape
{
    public double width { get; set; }
    public double height { get; set; }
    public double Area()
    {
        return width * height;
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}


class Program
{
    static void Main(string[] args)
    {

    }

}


<!-- liskov -->



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