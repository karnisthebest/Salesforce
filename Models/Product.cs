using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesForce.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string detail { get; set; }
        
        // public string picture { get; set; }
     
    }
}