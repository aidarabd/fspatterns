using ConsoleApp1.finance.ConcreteCreators;
using ConsoleApp1.finance.Interfaces;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.EntityObjects
{
    public class EvergreenLine : ICompany, ISeaTransport
    {
        public void CheckWeather()
        {
            throw new System.NotImplementedException();
        }

        public void seaDeliver(Transport transport)
        {
            transport.Deliver();
        }

        public string GetCompanyInfo() => "Evergreen Lines, probka maker";
    }
}