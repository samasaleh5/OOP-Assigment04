using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment04.Interface
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }
}
