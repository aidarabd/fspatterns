using System;

namespace ConsoleApp1
{
    public class Chain
    {
        // static void Main(string[] args)
        // {
        //     IHandler handler = new PrivateCustomer();
        //     handler.handle();
        //     
        // }
    }

    public interface IHandler
    {
        void setNext(IHandler handler);
        void handle();
    }

    public abstract class BaseHandler : IHandler
    {
        public IHandler _Handler;

        public virtual void setNext(IHandler handler)
        {
            _Handler = handler;
        }

        public void handle()
        {
            Console.WriteLine("base");
        }
    }

    public class PrivateCustomer : BaseHandler
    {
        public void setNext(IHandler handler)
        {
            throw new NotImplementedException();
        }

        public void handle()
        {
            Console.WriteLine("concrete");
        }
        
    }

    public class LegalCustomer : BaseHandler, IHandler
    {
        public void handle()
        {
            Console.WriteLine("concrete");
        }
    }
    
}