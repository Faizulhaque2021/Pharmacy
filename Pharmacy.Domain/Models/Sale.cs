using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineShop.Domain.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string SaleItem { get; set; }
        public int Unit { get; set; }
        public int Quentity { get; set; }
        public int TotalPrice { get; set; }
    }
}
