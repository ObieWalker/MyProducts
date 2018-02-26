using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jichibi.Models
{
    public class Products
    {
        public int ID { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        [Display(Name = "Price (₦)")]
        public decimal price { get; set; }
    }
}
