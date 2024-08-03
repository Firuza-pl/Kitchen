using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIKITCHEN.DBL.Entity
{
    public class ShopBasket
    {
        public int M_ID { get; set; }
        public string M_NAME { get; set; }
        public double M_PRICE { get; set; }
        public double M_QTY { get; set; }
        public double M_TOTAL { get; set; }
    }
}
