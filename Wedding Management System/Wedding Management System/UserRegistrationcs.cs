using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Management_System
{
    public class UserRegistration
    {
        public int userId { get; set; }
        public int roleId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int createdBy { get; set; }
        public DateTime createdOn { get; set; }
        public int modifiedBy { get; set; }
        public DateTime modifiedOn { get; set; }
        public bool isDeleted { get; set; }

    }

    /// <summary>
    /// for creating we use this class only instead of class userRegistation
    /// </summary>
    public class PostDTO
    {

    }
    /// <summary>
    /// for updating we use this class instead of class userRegistration
    /// </summary>
    public class PutDTO
    {

    }
}
