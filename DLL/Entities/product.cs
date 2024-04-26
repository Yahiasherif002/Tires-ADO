using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Product
    {
        public int id { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? Package { get; set; }
        public bool IsDiscontinued { get; set; }
    }
}
