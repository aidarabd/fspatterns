using System;

namespace ConsoleApp1
{
    public class MyObject
    {
        public static MyObject _myObject;
        public static string someText = "unchangable";
        private MyObject() { }
        public static MyObject getInstance()
        {
            _myObject = _myObject == null ? new MyObject() : _myObject;
            DoWork();
            return _myObject;
        }

        public static void DoWork()
        {
            Console.WriteLine(someText);
        }
    }
    

     static class RunTheApp
     {
        //static void Main(string[] args)
        //{
        //    var mo = MyObject.getInstance();
        //    var mo2 = MyObject.getInstance();
        //    Console.WriteLine(mo == mo2);
        //}
    }
}