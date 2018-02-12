using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Products
{
    public class ProductsCommon
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ProductName { get; set; }
        public int Category { get; set; }
        public string ModelNumber { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Colour { get; set; }
        public string ImageURL { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
