using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Products
{
    [Table("Watches", Schema = "Product")]
    public class Watches : ProductsCommon
    {
        [Key]
        public int WatchId { get; set; }
        public int BeltType { get; set; }//get from enum
    }
}
