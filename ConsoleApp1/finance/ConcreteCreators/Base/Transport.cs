using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.ConcreteCreators
{
    public abstract class Transport 
    {
        public abstract ITransport createTransport();
     
        public string Deliver()
        {
            ITransport transport = createTransport();
            return transport.Deliver();
        }
    }
}