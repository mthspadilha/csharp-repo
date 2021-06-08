using System;
using System.Collections.Generic;
using System.Text;
using Compositon.enums;
using Compositon.entities;
using System.Globalization;

namespace Compositon.entities
{
    class Order
    {
        public DateTime Moment { set; get; }
        public OrderStatus Status { set; get; }

        public Client Client { set; get; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem Item)
        {
            Items.Add(Item);
        }

        public void RemoveItem(OrderItem Item)
        {
            Items.Remove(Item);
        }
        
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum = sum + item.subTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }

}

