using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineShop.Domain.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public int RoleId { get; set; }
        public string Title { get; set; }
        public string Module { get; set; }
        public string Description { get; set; }
    }
}
