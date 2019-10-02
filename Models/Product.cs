using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginationTaskDZ.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Details { get; set; }
        public string ImagePath { get; set; }
        public string Notes { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}