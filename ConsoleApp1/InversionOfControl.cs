using System;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Book b = new Book();
        //    b.name = "1984";
        //    MySQLRepo msrepo = new MySQLRepo();
        //    HomeController hc = new HomeController(msrepo);
        //    hc.save(b);


        //}
    }

    public class Book
    {
        public string name { get; set; }
    }

    public interface IRepository
    {
        Book doors { get; set; }
        void save(Book b);
    }

    public class MySQLRepo : IRepository
    {
        public Book doors { get; set; }
        public void save(Book book)
        {
            Console.WriteLine("MySQL saved " + book.name);
        }
    }

    public class MsSQLRepo : IRepository
    {
        public Book doors { get; set; }
        public void save(Book book)
        {
            Console.WriteLine("MsSQL saved " + book.name);
        }
    }

    public class HomeController
    {
        public IRepository _repo;

        public HomeController(IRepository repo)
        {
            _repo = repo;
        }

        public void save(Book b)
        {
           
            _repo.save(b);
        }
    }

}
