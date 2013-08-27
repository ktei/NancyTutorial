using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using Nancy.Testing;
using NUnit.Framework;

namespace NancyTutorial.Test
{
    public class AccountTest : BaseTest
    {
        [Test]
        public void signup_route_should_be_successful()
        {
            var browser = new Browser(Bootstrapper);
            var response = browser.Get("/signup");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
