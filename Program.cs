
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

class Program
{
    static void Main(string[] args)
    {
       
       INotification Emailnotification = new EmailNotification();

       Emailnotification.send();
       Emailnotification.log();
       Emailnotification.save();

       INotification Smsnotification = new SMSNotification();

       Smsnotification.send();
       Smsnotification.log();
       Smsnotification.save();

    }
}