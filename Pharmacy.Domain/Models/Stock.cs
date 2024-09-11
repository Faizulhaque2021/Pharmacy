using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineShop.Domain.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Item { get; set; }
        public int Unit { get; set; }
    }
}
