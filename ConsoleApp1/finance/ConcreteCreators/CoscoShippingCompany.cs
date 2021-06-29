using ConsoleApp1.finance.EntityObjects;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.ConcreteCreators
{
    public class CoscoShippingCompany : Company
    {
        public override ICompany createCompany()
        {
            return new CoscoShipping();
        }

        public override string Deliver(Transport transport, bool isTrackable=false)
        {
            switch (transport)
            {
                case ShipTransport shipTransport:
                    return shipTransport.Deliver();
                case AviaTransport aviaTransport:
                    return "sorry, we do not provide air transportation";
                default:
                    return "";
            }
        }
       
    }
}