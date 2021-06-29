using System;
using ConsoleApp1.finance.ConcreteCreators;
using ConsoleApp1.finance.Interfaces;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.EntityObjects
{
    public class Ship : ITransport
    {
        public string Deliver()
        {
            return "ship delivery started";
        }

        public void Track()
        {
            throw new NotImplementedException();
        }

        public bool isTrackable { get; set; }
    }
}