using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenTraining.Models
{
    public class Product
    {
        public int Id { get; set; }
        public virtual Picture ProductPicture { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}