using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Management_System
{
    public class UserRole
    {
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string displayName { get; set; }
        public bool isSuperAdmin { get; set; }
        public bool isAdmin { get; set; }
        public bool isParent { get; set; }
        public bool isWaza { get; set; }
        public bool isShopkeeper { get; set; }
        public bool isActive { get; set; }
    }
}
