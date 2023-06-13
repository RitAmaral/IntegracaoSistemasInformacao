using System;
using TrabalhoISI.Entities;
using TrabalhoISI.Entities.Enums;

namespace TrabalhoISI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Restaurant!");
            Console.WriteLine();

            /* --------------------------------------------------------//só colocar isto se usar ciclo for:
            Console.WriteLine("How many orders do you want to make? ");
            int N = int.Parse(Console.ReadLine());
            */

            /*---------------------Customer Places Order------------------------*/

            //for (int i = 1; i <= N; i++)
            //{
                Console.WriteLine();
                Console.WriteLine("Order #1: "); //se usar ciclo for, colocar: ($"Order #{i}: ")
                int orderNumber = 1; //se usar ciclo for ponho igual a = i
                DateTime dateTime = DateTime.Now;
                Console.Write("What is your name? ");
                string customerName = Console.ReadLine();
                Console.Write("What food do you want to eat? ");
                string food = Console.ReadLine();
                Console.Write("What drink do you want to consume? ");
                string drink = Console.ReadLine();
                OrderStatus status = Enum.Parse<OrderStatus>("Pending");
                Console.WriteLine();
                
                Order order = new Order(orderNumber, dateTime, customerName, food, drink, status);
                order.AddOrder(order);

                order.ShowOrder();
            //}

            /*---------------------Customer Modifies Order or Checks Order Status------------------------*/
            Console.WriteLine();
            Console.Write("Do you want to change your order? (Y/N) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'y' || resp == 'Y')
            {
                Console.Write("Food or Drink? ");
                string resp2 = Console.ReadLine();
                if (resp2 == "Food") 
                {
                    Console.Write("What food do you want to eat? ");
                    food = Console.ReadLine(); //não é assim que se atualiza uma lista. isto não funciona.
                    order.AddOrder(order);
                    order.ShowOrder();
                }
                else
                {
                    Console.Write("What drink do you want to consume? ");
                    drink = Console.ReadLine();
                    order.AddOrder(order);
                    order.ShowOrder();
                }
            }
            else
            {
                Console.Write("The status of your order is: ");
                order.UpdateOrderStatus(orderNumber, OrderStatus.Preparing);
                Console.WriteLine();
                Console.WriteLine("ORDER DETAILS: ");
                order.ShowOrder();
            }
        }
    }
}