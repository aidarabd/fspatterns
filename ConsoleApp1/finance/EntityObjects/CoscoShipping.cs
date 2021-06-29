using System;
using ConsoleApp1.finance.ConcreteCreators;
using ConsoleApp1.finance.Interfaces;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.EntityObjects
{
    public class CoscoShipping : ICompany, IRoadTransport, IPlaneTransport
    {
        public string GetCompanyInfo() => "Cosco Shipping";

        public void CheckRoadTraffic()
        {
            Console.WriteLine("check road traffic");
        }

        public void RoadDeliver()
        {
            var transport = new ShipTransport();
            transport.Deliver();
        }

        public bool IsFoggy { get; set; }
        public void AviaDeliver()
        {
            var transport = new AviaTransport();
            transport.Deliver();
        }
    }
}