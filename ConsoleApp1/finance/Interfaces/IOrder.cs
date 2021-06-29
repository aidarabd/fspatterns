using ConsoleApp1.finance.ConcreteCreators;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.Interfaces
{
    public interface IOrder 
    {
        Transport _Transport { get; set; }
        Company _Company { get; set; }
        void makeOrder(bool isUrgent, bool isCrystal, bool isTrack);
    }
}