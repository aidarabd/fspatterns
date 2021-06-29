// using System;
//
// namespace ConsoleApp1
// {
//     
//     public abstract class Logistics
//     {
//         
//         public void planDelivery()
//         {
//             ITransport transport = CreateTransport();
//             transport.deliver();
//         }
//
//         public abstract ITransport CreateTransport();
//
//     }
//
//     public class RoadLogistics : Logistics
//     {
//         public override ITransport CreateTransport()
//         {
//             return new Truck();
//         }
//     }
//     public class SeaLogistics : Logistics
//     {
//         public override ITransport CreateTransport()
//         {
//             return new Ship();
//         }
//     }
//
//
//     public interface ITransport
//     {
//         void deliver();
//     }
//
//     public class Truck : ITransport
//     {
//         public void deliver()
//         {
//             Console.WriteLine("by road");
//         }
//     }
//     public class Ship : ITransport
//     {
//         public void deliver()
//         {
//             Console.WriteLine("by sea");
//         }
//     }
//     public class Factory
//     {
//         // static void Main(string[] args)
//         // {
//         //     WindowsDialog wd =new WindowsDialog();
//         //     wd.render();
//         // }
//     }
//
//     
//
//     public interface IButton
//     {
//         void render();
//         void onclick();
//     }
//
//     public class Windows : IButton
//     {
//         public void render()
//         {
//             Console.WriteLine("windows render");
//         }
//
//         public void onclick()
//         {
//             Console.WriteLine("windows click");
//         }
//     }
//
//     public class HTML : IButton
//     {
//         public void render()
//         {
//             Console.WriteLine("html render");
//         }
//
//         public void onclick()
//         {
//             Console.WriteLine("html click");
//         }
//     }
//
//     public abstract class Dialog
//     {
//         public abstract IButton createButton();
//         public void render()
//         {
//             IButton button = createButton();
//             button.render();
//         }
//     }
//
//     public class WindowsDialog : Dialog
//     {
//         public override IButton createButton()
//         {
//             return new Windows();
//         }
//     }
//
//     public class HTMLDialog : Dialog
//     {
//         public override IButton createButton()
//         {
//             return new HTML();
//         }
//     }
//
// }