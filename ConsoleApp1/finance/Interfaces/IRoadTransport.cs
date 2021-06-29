using ConsoleApp1.finance.ConcreteCreators;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.Interfaces
{
    public interface IRoadTransport 
    {
        void CheckRoadTraffic();
        void RoadDeliver();
    }
}