namespace ConsoleApp1.finance.Other
{
    public class Notifier
    {
        private Notifier(){}
        private static Notifier _Notifier;

        public static Notifier GetInstance()
        {
            return _Notifier == null ? new Notifier() : _Notifier;
        }

        public string NotifyUser()
        {
            return "Choose company and delivery transport";
        }
        
    }
}