using ShoppingCart.Commands;
using ShoppingCart.Invoker;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Item steak = new Item() { Name = "Steak", Price = 10 };
            Item chicken = new Item() { Name = "Chicken", Price = 5 };

            Order order = new Order();

            OrderInvoker invoker = new OrderInvoker();

            IOrderCommand insertSteakCommand = new InsertItemCommand(order, steak);
            invoker.SetOrderCommand(insertSteakCommand);
            invoker.Invoke();
            
            Console.WriteLine("Order Items after InsertSteakCommand Execute: " + order.OrderItems[0].Name);

            IOrderCommand modifySteakCommand = new ModifyItemCommand(order, steak, chicken);
            invoker.SetOrderCommand(modifySteakCommand);
            invoker.Invoke();

            Console.WriteLine("Order Items after ModifySteakCommand Execute: " + order.OrderItems[0].Name);

            invoker.SetOrderCommand(insertSteakCommand);
            invoker.Invoke();

            Console.WriteLine("Order Items after InsertSteakCommand Execute: " + order.OrderItems[0].Name + " " + order.OrderItems[1].Name);


            IOrderCommand removeChickenCommand = new RemoveItemCommand(order, chicken);
            invoker.SetOrderCommand(removeChickenCommand);
            invoker.Invoke();

            Console.WriteLine("Order Items after RemoveChickenCommand Execute: " + order.OrderItems[0].Name);
        }
    }
}
