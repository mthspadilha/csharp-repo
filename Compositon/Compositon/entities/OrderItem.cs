using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Compositon.entities
{
    class OrderItem
    {
        public int Quantity { set; get; }
        public double Price { set; get; }

        public Product Product { set; get; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.NameProduct
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
