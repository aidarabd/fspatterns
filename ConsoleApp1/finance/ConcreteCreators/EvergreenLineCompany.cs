using ConsoleApp1.finance.EntityObjects;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.ConcreteCreators
{
    public class EvergreenLineCompany : Company
    {
        public override ICompany createCompany()
        {
            return new EvergreenLine();
        }
        public override string Deliver(Transport transport, bool isTrackable=false)
        {
            switch (transport)
            {
                case ShipTransport shipTransport:
                    return shipTransport.Deliver();
                case TruckTransport truckTransport:
                    return "sorry, we do not provide road transportation";
                default:
                    return "";
            }
        }
    }
}
