<!-- dry violate -->



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
     
       INotification whatsAppNotication = new whatsAppNotification();

       whatsAppNotication.send();

       whatsAppNotication.log();

       whatsAppNotication.save();

    }
}

<!-- Dry violates -->


<!-- solve this -->


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

    //    whatsAppNotication.send();

    //    whatsAppNotication.log();

    //    whatsAppNotication.save();

    }
}