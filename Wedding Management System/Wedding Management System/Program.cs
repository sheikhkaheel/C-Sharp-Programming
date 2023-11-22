using System;

namespace Wedding_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wedding Management Ststem");
        }
    }
}

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

public class UserRegisration
{
    public int userId { get; set; }
    public int roleId { get; set; }
    public string userName { get; set; }
    public string password { get; set; }

}

public class Parent
{
    public int parentId { get; set; }
    public string firstName { get; set; }
    public string middleName { get; set; }
    public string surName { get; set; }
    public int age { get; set; }
    public string prefix { get; set; }
    public string dob { get; set; }
    public string address { get; set; }
    public int phoneNo { get; set; }
    public string latituteAndLongitute { get; set; }
    public string gender { get; set; }
    public string familyHead { get; set; }
    public string houseImg { get; set; }
    public string email { get; set; }

}

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

public class Waza
{
    public int wazaId { get; set; }
    public string CompanyName { get; set; }
    public string address { get; set; }
    public int age { get; set; }
    public int phoneNo { get; set; }
    public string yearsOfExp { get; set; }
    public string RateOfMeatPer100Kg { get; set; }
    public string RateOfChickenPer100Kg { get; set; }
}