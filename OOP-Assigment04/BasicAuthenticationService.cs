using OOP_Assigment04.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment04
{
    internal class BasicAuthenticationService:IAuthenticationService
    {
        private string _adminUsername = "admin";
        private string _adminPassword = "12345";
        private string[] _adminRoles = { "Admin", "User" };

        private string _userUsername = "sama";
        private string _userPassword = "123";
        private string[] _userRoles = { "User" };

        public bool AuthenticateUser(string username, string password)
        {
            if (username == _adminUsername && password == _adminPassword)
            {
                return true;   
            }
            else if(username== _userUsername && password == _userPassword) 
            {
                return true; 
            }
           return false;
        }
        public bool AuthorizeUser(string username, string role) 
        {
            if (username == _adminUsername)
            {
                return _adminRoles.Contains(role);
            }
            else if (username == _userUsername)
            {
                return _userRoles.Contains(role);
            }
            return false;
        }


    }
}
