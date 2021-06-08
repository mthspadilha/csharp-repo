using System;
using System.Collections.Generic;
using System.Text;

namespace Compositon.entities
{
    class Product
    {
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }

        public Product()
        {

        }

        public Product(string nameProduct, double priceProduct)
        {
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
        }
    }
}
