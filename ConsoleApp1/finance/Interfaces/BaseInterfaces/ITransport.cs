namespace ConsoleApp1.finance.Interfaces.BaseInterfaces
{
    public interface ITransport
    {
        string Deliver();
        void Track();
        bool isTrackable { get; set; }
    }
}