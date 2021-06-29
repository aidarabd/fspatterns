using ConsoleApp1.finance.EntityObjects;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.ConcreteCreators
{
    public class TruckTransport : Transport
    {
        public override ITransport createTransport()
        {
            return new Truck();
        }
    }
}