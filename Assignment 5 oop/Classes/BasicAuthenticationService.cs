using Assignment_5_oop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Classes
{
    internal class BasicAuthenticationService:IAuthenticationService
    {
        #region Properties

        string userName = "Mohammed Ali";
        string password = "passw@rd";
        string Role = "Admin";

        #endregion
        #region Methods

        public bool AuthenticateUser(string? user , string? pass)
        {
            if (user == userName && pass == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AuthorizeUser(string? user, string? role)
        {
            if (user == userName)
            {
                return role == Role;
            }
            else
            {
                return false;
            }

        } 
        #endregion
    }
}
