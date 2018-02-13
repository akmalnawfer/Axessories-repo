using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Products
{
    [Table("Audios", Schema = "Product")]
    public class Audios : ProductsCommon
    {
        [Key]
        public int AudioId { get; set; }
        public int AudioType { get; set; }
    }
}
