using mvc.Models;
using mvc.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Services.Business
{
    public class SecurityService
    {
        SecurityDAO daoService = new SecurityDAO();

        public bool Authenticate(userModel user)
        {
            return daoService.FindByUser(user);

        }

            
    }
}