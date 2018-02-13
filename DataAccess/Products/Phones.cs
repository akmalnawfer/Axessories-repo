using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Products
{
    [Table("Phones", Schema = "Product")]
    public class Phones : ProductsCommon
    {
        [Key]
        public int PhoneId { get; set; }
        public string Capacity { get; set; }
        public string RAM { get; set; }
        public double DisplaySize { get; set; }
        public string PrimaryCamera { get; set; }
        public string SecondaryCamera { get; set; }
        public string Processor { get; set; }
        public int SimSlots { get; set; } //get from enum
        public int BatteryCapacity { get; set; }
        public string OperatingSystem { get; set; }
    }
}
