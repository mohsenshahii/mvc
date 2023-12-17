using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(userModel user)
        {
            return (user.UserName == "admin" && user.Password == "secret");
        }
    }
}