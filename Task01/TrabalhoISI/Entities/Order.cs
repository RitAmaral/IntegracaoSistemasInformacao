using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoISI.Entities.Enums;

namespace TrabalhoISI.Entities
{
    internal class Order
    {
        //Propriedades
        public int OrderNumber { get; set; }
        public DateTime OrderMoment { get; set; }
        public string CustomerName { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }

        public OrderStatus Status { get; set; }

        //Lista
        public List<Order> Orders { get; set; } = new List<Order>();

        //Construtores
        public Order() { } //construtor padrão - vazio
        public Order(int orderNumber, DateTime orderMoment, string customerName, string food, string drink, OrderStatus status)
        {
            OrderNumber = orderNumber;
            OrderMoment = orderMoment;
            CustomerName = customerName;
            Food = food;
            Drink = drink;
            Status = status;
        }

        //Métodos
        public void AddOrder(Order order) //método para adicionar pedido
        {
            Orders.Add(order);
        }

        public void RemoveOrder(Order order) //método para remover pedido
        {
            Orders.Remove(order);
        }

        public void UpdateOrderStatus(int orderNumber, OrderStatus status) //método para alterar order status
        {
            var order = Orders.Find(o => o.OrderNumber == orderNumber);
            if (order != null)
            {
                order.Status = status;
                Console.WriteLine($"Order {order.OrderNumber} status updated to {status}");
            }
            else
            {
                Console.WriteLine($"Order {orderNumber} not found");
            }
        }

        public void ShowOrder()
        {
            foreach (Order order in Orders)
            {
                Console.WriteLine("Order Number: " + order.OrderNumber
                + "\n"
                + "Order Moment: " + order.OrderMoment
                + "\n"
                + "Food ordered: " + order.Food
                + "\n"
                + "Drink ordered: " + order.Drink
                + "\n"
                + "Order Status: " + order.Status);
            }
        }

        public override string ToString()
        {
            return "\n"
                + "Order Number: " + OrderNumber
                + "\n"
                + "Order Moment: " + OrderMoment
                + "\n"
                + "Food ordered: " + Food
                + "\n"
                + "Drink ordered: " + Drink
                + "\n"
                + "Order Status: " + Status;
        }


    }
}
