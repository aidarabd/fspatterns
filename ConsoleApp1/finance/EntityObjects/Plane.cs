using ConsoleApp1.finance.Interfaces;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.EntityObjects
{
    public class Plane : ITransport
    {
        public string Deliver() => "Plane transport started";
        public void Track()
        {
            throw new System.NotImplementedException();
        }

        public bool isTrackable { get; set; }
    }
}