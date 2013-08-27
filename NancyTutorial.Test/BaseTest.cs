using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy.Bootstrapper;
using Nancy.Testing;
using NUnit.Framework;

namespace NancyTutorial.Test
{
    [TestFixture]
    public abstract class BaseTest
    {
        private INancyBootstrapper _bootsrapper = new ConfigurableBootstrapper(with =>
        {
            with.RootPathProvider(new TestRootPathProvider());
        });

        protected INancyBootstrapper Bootstrapper
        {
            get { return _bootsrapper; }
        }
    }
}
