using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using Nancy.Testing;
using NUnit.Framework;

namespace NancyTutorial.Test
{
    public class MemoTest : BaseTest
    {
        [Test]
        public void root_route_should_be_successful()
        {
            var browser = new Browser(Bootstrapper);
            var response = browser.Get("/");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
