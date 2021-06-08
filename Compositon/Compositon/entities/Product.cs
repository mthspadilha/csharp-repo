using System;
using System.Collections.Generic;
using System.Text;

namespace Compositon.entities
{
    class Produtcts
    {
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }

        public Produtcts()
        {

        }

        public Produtcts(string nameProduct, double priceProduct)
        {
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
        }
    }
}
