using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fotomarket.Attribute
{
  
        public class AdminAuthorizeAttribute : AuthorizeAttribute
        {
            public override void OnAuthorization(AuthorizationContext filterContext)
            {
            string Rol = (string)HttpContext.Current.Session["Rol"];
 
            if (Rol == "admin")
                {
                    base.OnAuthorization(filterContext);
                }
                else
                {
                    HandleUnauthorizedRequest(filterContext);
                }
            }
        }
    }

