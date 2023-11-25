using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Management_System
{
    public class Child
    {
        public int childId { get; set; }
        public int parentId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string surName { get; set; }
        public string prefix { get; set; }
        public int age { get; set; }
        public string dob { get; set; }
        public string address { get; set; }
        public string latituteAndLongitute { get; set; }
        public string gender { get; set; }
        public int phoneNo { get; set; }
        public string qualification { get; set; }
        public string email { get; set; }
    }

    /// <summary>
    /// common fields for all other DTO's
    /// </summary>
    public class CommonChildDTO
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
    /// <summary>
    /// for creating we use this class only instead of class userRegistation
    /// </summary>
    public class PostChildDTO : CommonChildDTO
    {

    }
    /// <summary>
    /// for updating we use this class instead of class userRegistration
    /// </summary>
    public class PutChildDTO : CommonChildDTO
    {
        public int userId { get; set; }
    }
    /// <summary>
    /// for selecting we use this class instead of class userRegistration
    /// </summary>
    public class ListChildDTO : PutChildDTO
    {

    }
    /// <summary>
    /// for searching we use this class instead of class userRegistration
    /// </summary>
    public class SearchChildDTO : PutChildDTO
    {

    }
}
