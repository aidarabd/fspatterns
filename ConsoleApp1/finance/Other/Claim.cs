using System;
using System.ComponentModel;
using ConsoleApp1.finance.ConcreteCreators;
using ConsoleApp1.finance.Interfaces;
using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.Other
{
    public class Claim : IOrder
    {
        public Transport _Transport { get; set; }
        public Company _Company { get; set; }
        public void makeOrder(bool isUrgent = false, bool isCrystal=false, bool isTrack=false)
        {
            if (_Company is null || _Transport is null)
            {
                Console.WriteLine(Notifier.GetInstance().NotifyUser());
                return;
            } 
            Console.WriteLine(_Company.GetCompanyInfo() + " will deliver || " + _Company.Deliver(_Transport));
        }
    }
}