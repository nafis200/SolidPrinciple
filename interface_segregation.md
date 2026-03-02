
<!-- interface segretion problem -->

<!-- push notification e Save method lagbe na but implement korte hole ditei hobe -->

using System;

public interface INotify
{
    public void sendMessage();
    public void log();
    public void Save();
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
<!-- interface segregation problem at solid where i forcefully implement this -->
<!-- but not problem code performance -->

<!-- if not give this then create problem -->

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

        INotify pushNotify = new PushNotify{Token ="abcd"};

        NotifyContext pushNotifyContext = new NotifyContext(pushNotify);

        notifies.Add(pushNotifyContext);

        foreach (var item in notifies)
        { 
            item.Process();  
        }

    }
}


<!-- solve interface seggrettion -->

<!-- if interface method need this class then just break interface -->