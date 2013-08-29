using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyTutorial
{
    public class LoginModule : NancyModule
    {
        public LoginModule()
        {
            Get["/login"] = parameters =>
            {
                return View["login/login.sshtml"];
            };
        }
    }
}