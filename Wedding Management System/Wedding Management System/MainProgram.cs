using System;
using System.Collections.Generic;

namespace Wedding_Management_System
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wedding Management System");

            UserRole role1 = new UserRole();
            role1.roleId = 01;
            role1.roleName = "mual";
            role1.displayName = "father";
            role1.isParent = true;

            Console.WriteLine($"Role1\n RoleId {role1.roleId} RoleName {role1.roleName} DisplayName {role1.displayName} IsFather {role1.isParent}");

            UserRegistration user1 = new UserRegistration();
            user1.userId = 01;
            user1.roleId = role1.roleId;
            user1.firstName = "sheikh";
            user1.middleName = "muhammad";
            user1.lastName = "kaheel";
            user1.userName = "sheikhkaheel";
            user1.password = "1234";

            Console.WriteLine($"User1\n UserID {user1.userId} UserRoleId {user1.roleId} FirstName {user1.firstName} MiddleName {user1.middleName} LastName {user1.lastName} UserName {user1.userName} Password {user1.password}");

            PostUserDTO post = new PostUserDTO();
            post.firstName = "Zubair";
            post.middleName = "Altaf";
            post.lastName = "Rangrez";
            post.userName = "abc";
            post.password = "abc@123";

            List<PostUserDTO> listuser = new List<PostUserDTO>();
            listuser.Add(post);

            UserAction action1 = new UserAction();
            action1.Save(post);
        }
    }
}











