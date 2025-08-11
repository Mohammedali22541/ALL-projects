using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Interfaces
{
    internal interface IAuthenticationService
    {
        #region Methods
        public bool AuthenticateUser(string user , string pass);
        public bool AuthorizeUser(string user, string role);
        #endregion
    }
}
