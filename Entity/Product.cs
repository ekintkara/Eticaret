using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; } 
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        public DateTime ProductDate  { get; set; }

        public int Quantity { get; set; }

        public int CategoryId{ get; set; }

        public Category Category { get; set;}
    }
}
