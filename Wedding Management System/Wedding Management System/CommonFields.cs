using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Management_System
{
    public class CommonFields
    {
        public int createdBy { get; set; }
        public DateTime createdOn { get; set; }
        public int modifiedBy { get; set; }
        public DateTime modifiedOn { get; set; }
        public bool isDeleted { get; set; }
    }
}
