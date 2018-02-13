using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Products
{
    [Table("Accessories", Schema = "Product")]
    public class Accessories : ProductsCommon
    {
        [Key]
        public int AccessoryId { get; set; }
        public int AccessoryType { get; set; } //get from enum
    }
}
