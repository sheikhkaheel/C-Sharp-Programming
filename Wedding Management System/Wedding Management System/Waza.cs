using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Management_System
{
    public class Waza
    {
        public int wazaId { get; set; }
        public string CompanyName { get; set; }
        public string address { get; set; }
        public string latitudeAndLongitude { get; set; }
        public int age { get; set; }
        public int phoneNo { get; set; }
        public string yearsOfExp { get; set; }
        public string RateOfMeatPer100Kg { get; set; }
        public string RateOfChickenPer100Kg { get; set; }
    }

    /// <summary>
    /// common fields for all other DTO's
    /// </summary>
    public class CommonWazaDTO
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
    /// <summary>
    /// for creating we use this class only instead of class userRegistation
    /// </summary>
    public class PostWazaDTO : CommonWazaDTO
    {

    }
    /// <summary>
    /// for updating we use this class instead of class userRegistration
    /// </summary>
    public class PutWazaDTO : CommonWazaDTO
    {
        public int userId { get; set; }
    }
    /// <summary>
    /// for selecting we use this class instead of class userRegistration
    /// </summary>
    public class ListWazaDTO : PutWazaDTO
    {

    }
    /// <summary>
    /// for searching we use this class instead of class userRegistration
    /// </summary>
    public class SearchWazaDTO : PutWazaDTO
    {

    }
}
