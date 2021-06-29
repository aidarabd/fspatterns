using ConsoleApp1.finance.ConcreteCreators;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.Interfaces
{
    public interface ISeaTransport 
    {
        void CheckWeather();
        void seaDeliver(Transport transport);
    }
}
