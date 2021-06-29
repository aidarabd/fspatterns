using ConsoleApp1.finance.Interfaces.BaseInterfaces;

namespace ConsoleApp1.finance.ConcreteCreators
{
    public abstract class Company
    {
        public abstract ICompany createCompany();
        public abstract string Deliver(Transport transport, bool isTrackable=false);
        public string GetCompanyInfo()
        {
            ICompany company = createCompany();
            return company.GetCompanyInfo();
        }

    
        
    }
}