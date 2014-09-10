using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoCTesting.IoC.LightInject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IoCTesting.Tests
{
    [TestClass]
    public class LightInjectTests : BaseTests
    {
        protected override IoC.IIoC GetContainer()
        {
            return new LightInjectIoC();
        }
    }
}