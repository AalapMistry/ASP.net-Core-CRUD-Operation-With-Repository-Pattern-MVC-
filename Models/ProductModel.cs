using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public List<string> Categories { get; set; }

        public string Stock { get; set; }

        public int Price { get; set; }
    }
}
