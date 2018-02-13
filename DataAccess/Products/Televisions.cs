using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Products
{
    [Table("Televisions", Schema = "Product")]
    public class Televisions : ProductsCommon
    {
        [Key]
        public int TelevisionId { get; set; }
        public int ScreenSize { get; set; }
        public bool IsSmartTV { get; set; }

    }
}
