using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Testing;
using NUnit.Framework;

namespace NancyTutorial.Test
{
    public class LoginTest : BaseTest
    {
        [Test]
        public void login_route_should_be_successful()
        {
            var browser = new Browser(Bootstrapper);
            var response = browser.Get("/login");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
