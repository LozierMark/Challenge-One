using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    public enum BakeType { Bread, Cake, Pastery, Pie }
    public class Product
    {
        public string ProductName { get; set; }
        public BakeType BakeType { get; set; }
        public int OrderBatchSize { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderCost { get; set; }

        public Product(string productName, BakeType bakeType, int batchOrder, string customerName, decimal orderCost)
        {
            ProductName = productName;
            BakeType = bakeType;
            OrderBatchSize = batchOrder;
            CustomerName = customerName;
            OrderCost = orderCost;
        }

        public Product()
        {

        }
    }
}