using System;

namespace ConsoleApp1
{
    public class Decorator
    {
        // static void Main(string[] args)
        // {
        //     var baseSender = new ConcreteNotifier();
        //     SmsDecorator smsDecorator = new SmsDecorator(baseSender);
        //     FacebookDecorator facebookDecorator = new FacebookDecorator(smsDecorator);
        //     facebookDecorator.send();
        // }
    }
}

public abstract class Notifier
{
    public abstract void send();
}

public class ConcreteNotifier : Notifier
{
    public override void send()
    {
        Console.WriteLine("default notification sender");
    }
    
}

public class BaseDecorator : Notifier
{
    private Notifier _notifier;

    public BaseDecorator(Notifier notifier)
    {
        _notifier = notifier;
    }

    public override void send()
    {
        if (_notifier != null)
        {
            _notifier.send();
        }
    }
}

public class SmsDecorator : BaseDecorator
{
    public SmsDecorator(Notifier notifier) : base(notifier)
    {
    }

    public override void send()
    {
        base.send();
        Console.WriteLine("sms sent");
    }
}
public class FacebookDecorator : BaseDecorator
{
    public FacebookDecorator(Notifier notifier) : base(notifier)
    {
    }
    public override void send()
    {
        base.send();
        Console.WriteLine("facebook message sent");
    }
}
public class SlackDecorator : BaseDecorator
{
    public SlackDecorator(Notifier notifier) : base(notifier)
    {
    }
    public void send()
    {
        base.send();
        Console.WriteLine("slack message sent");
    }
}
