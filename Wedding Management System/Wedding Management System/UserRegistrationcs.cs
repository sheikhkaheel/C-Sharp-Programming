using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Management_System
{
    public class UserRegistration:CommonFields
    {
        public int userId { get; set; }
        public int roleId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }

    /// <summary>
    /// common fields for all other DTO's
    /// </summary>
    public class CommonUserDTO
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
    /// <summary>
    /// for creating we use this class only instead of class userRegistation
    /// </summary>
    public class PostUserDTO:CommonUserDTO
    {

    }
    /// <summary>
    /// for updating we use this class instead of class userRegistration
    /// </summary>
    public class PutUserDTO:CommonUserDTO
    {
        public int userId { get; set; }
    }
    /// <summary>
    /// for selecting we use this class instead of class userRegistration
    /// </summary>
    public class ListUserDTO:PutUserDTO
    {

    }
    /// <summary>
    /// for searching we use this class instead of class userRegistration
    /// </summary>
    public class SearchUserDTO:PutUserDTO
    {

    }
}
