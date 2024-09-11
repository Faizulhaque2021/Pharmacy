using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineShop.Domain.Models
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int MedicineId { get; set; }
    }
}
