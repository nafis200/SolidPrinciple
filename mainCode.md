using System;

public interface INotify
{
    public void sendMessage();
    public void log();
    public void Save();
}

public class EmailNotify : INotify
{
    public string Email { get; set; }
    public void sendMessage()
    {
        Console.WriteLine($"Sending Email to {Email}");
    }

    public void log()
    {
        Console.WriteLine("Log Email");
    }

    public void Save()
    {
        Console.WriteLine("Email Save");
    }
}



public class SmsNotify : INotify
{
    public string MobileNumber { get; set; }

    public void sendMessage()
    {
        Console.WriteLine($"Sending SMS to {MobileNumber}");
    }

    public void log()
    {
        Console.WriteLine("Log Email");
    }

    public void Save()
    {
        Console.WriteLine("Email Save");
    }
}

public class PushNotify : INotify
{
    public string Token {get; set;}

     public void sendMessage()
    {
        Console.WriteLine($"Sending Token to {Token}");
    }

    public void log()
    {
        Console.WriteLine("Log Email");
    }

//    interface segregation problem solid rule violation
    public void Save(){}

}

public class NotifyContext
{
    public INotify notify { get; set; }

    public NotifyContext(INotify notify)
    {
        this.notify = notify;
    }

    public void Process()
    {
        notify.sendMessage();
        notify.log();
        notify.Save();
    }
}


class Program
{
    static void Main(string[] args)
    {
    
        IList<NotifyContext> notifies = new List<NotifyContext>();

        INotify emailNotify = new EmailNotify
        {
            Email = "nafis@gmail.com"
        };



        INotify smsNotify = new SmsNotify { MobileNumber = "01922208141" };

        INotify pushNotify = new PushNotify{Token ="abcd"};


        NotifyContext emailNotifyContext = new NotifyContext(emailNotify);

        NotifyContext smsNotifyContext = new NotifyContext(smsNotify);

        NotifyContext pushNotifyContext = new NotifyContext(pushNotify);

        notifies.Add(emailNotifyContext);
        notifies.Add(smsNotifyContext);
        notifies.Add(pushNotifyContext);

        foreach (var item in notifies)
        { 
            item.Process();  
        }

    }
}