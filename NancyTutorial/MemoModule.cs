using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyTutorial
{
    public class MemoModule : NancyModule
    {
        public MemoModule()
        {
            Get["/"] = parameters =>
            {
                return View["memo/index"];
            };
        }
    }
}