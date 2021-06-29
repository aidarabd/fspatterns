using System;
using ConsoleApp1.finance.ConcreteCreators;
using ConsoleApp1.finance.EntityObjects;
using ConsoleApp1.finance.Other;

namespace ConsoleApp1.finance
{
    public class ClientCall
    {
        static void Main(string[] args)
        {

            Claim claim = new Claim
            {
                _Transport = null,
                _Company = new EvergreenLineCompany()
            };
            claim.makeOrder();




        }
                     
    }
   
    
}