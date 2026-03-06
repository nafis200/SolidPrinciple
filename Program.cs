
public interface INotification
{
    void send();
    void log();
    void save();
}


public interface Isend
{
    public void send();
}

public interface Ilog
{
    public void log();
}

public interface Isave
{
    public void save();
}


public class EmailNotification : Isend,Ilog,Isave
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


public class SMSNotification : Isend,Ilog,Isave
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

public class whatsAppNotification : Isend,Ilog,Isave
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


public class PushNotification : Isend,Ilog
{
    public void send()
    {
        Console.WriteLine("Push Send");
    }
    public void log()
    {
        Console.WriteLine("Push log");
    }

}


public class NotificationContext
{
    private Isend send {get;set;}
    private Ilog log{get;set;}

    private Isave save{get;set;}

    public NotificationContext(Isend send, Ilog log, Isave save)
    {
        this.send = send;
        this.log = log;
        this.save = save;
    }

    public void process()
    {
        send.send();
        log.log();
        if(save != null)
        {
            save.save();
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
       NotificationContext emailNotifyContext = new NotificationContext(new EmailNotification(),new EmailNotification(),new EmailNotification());

       emailNotifyContext.process();
    }
}