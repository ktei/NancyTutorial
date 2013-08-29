using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyTutorial
{
    public class AccountModule : NancyModule
    {
        public AccountModule()
        {
            Get["/signup"] = parameters =>
            {
                return View["account/create.sshtml"];
            };
        }
    }
}